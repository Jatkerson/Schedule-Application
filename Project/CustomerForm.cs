using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project.Database;
using static Project.Login;
using static Project.MainForm;


namespace Project
{
    public partial class CustomerForm : Form
    {

        public static CustomerForm form;
        private string changeType;
        private int customerIndex = -1;


        public CustomerForm()
        {
            if (form == null)
            {
                form = this;
            }

            InitializeComponent();
        }

        public CustomerForm(string type)
        {
            InitializeComponent();

            changeType = type;

            if(type == "add")
            {
                tbCustomerName.Text = "";
                tbCustomerAddress.Text = "";
                tbCustomerCity.Text = "";
                tbCustomerCountry.Text = "";
                tbCustomerPhoneNumber.Text = "";
                buttonCustomerChange.Text = "Add";
                buttonCustomerChange.Enabled = false;
            }
            else if(type == "update")
            {
                customerIndex = -1;

                for (int i = 0; i < Customer.allCustomers.Count(); i++)
                {
                    if(Customer.allCustomers[i].id == selectedCustomerId)
                    {
                        customerIndex = i;
                        break;
                    }
                }






                if(customerIndex > -1)
                {
                    tbCustomerName.Text = Customer.allCustomers[customerIndex].name;
                    tbCustomerAddress.Text = Customer.allCustomers[customerIndex].address;
                    tbCustomerCity.Text = Customer.allCustomers[customerIndex].city;
                    tbCustomerCountry.Text = Customer.allCustomers[customerIndex].country;
                    tbCustomerZipCode.Text = Customer.allCustomers[customerIndex].postalCode;
                    tbCustomerPhoneNumber.Text = Customer.allCustomers[customerIndex].phone;

                    buttonCustomerChange.Text = "Update";
                    buttonCustomerChange.Enabled = true;
                }
            }
        }

        private void buttonCustomerCancel_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm("customers");
            newForm.Show();
            this.Visible = false;
        }

        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerName.TextLength > 0)
            {
                tbCustomerName.BackColor = SystemColors.Window;
            }
            else
            {
                tbCustomerName.BackColor = Color.IndianRed;
            }

            checkNewCustomerInputs();
        }

        private void tbCustomerAddress_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerAddress.TextLength > 0)
            {
                tbCustomerAddress.BackColor = SystemColors.Window;
            }
            else
            {
                tbCustomerAddress.BackColor = Color.IndianRed;
            }

            checkNewCustomerInputs();
        }

        private void tbCustomerCity_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerCity.TextLength > 0)
            {
                tbCustomerCity.BackColor = SystemColors.Window;
            }
            else
            {
                tbCustomerCity.BackColor = Color.IndianRed;
            }

            checkNewCustomerInputs();
        }

        private void tbCustomerCountry_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerCountry.TextLength > 0)
            {
                tbCustomerCountry.BackColor = SystemColors.Window;
            }
            else
            {
                tbCustomerCountry.BackColor = Color.IndianRed;
            }

            checkNewCustomerInputs();
        }

        private void tbCustomerZipCode_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerZipCode.TextLength >= 5)
            {
                tbCustomerZipCode.BackColor = SystemColors.Window;
            }
            else
            {
                tbCustomerZipCode.BackColor = Color.IndianRed;
            }

            checkNewCustomerInputs();
        }

        private void tbCustomerPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerPhoneNumber.TextLength >= 7)
            {
                tbCustomerPhoneNumber.BackColor = SystemColors.Window;
            }
            else
            {
                tbCustomerPhoneNumber.BackColor = Color.IndianRed;
            }

            checkNewCustomerInputs();
        }


        private void checkNewCustomerInputs()
        {
            bool valid = true;

            if (tbCustomerName.TextLength <= 0)
            {
                valid = false;
            }


            if (tbCustomerAddress.TextLength <= 0)
            {
                valid = false;
            }


            if (tbCustomerCity.TextLength <= 0)
            {
                valid = false;
            }


            if (tbCustomerCountry.TextLength <= 0)
            {
                valid = false;
            }


            if (tbCustomerZipCode.TextLength < 5)
            {
                valid = false;
            }


            if (tbCustomerPhoneNumber.TextLength < 7)
            {
                valid = false;
            }


            if (valid)
            {
                buttonCustomerChange.Enabled = true;
            }
            else
            {
                buttonCustomerChange.Enabled = false;
            }


        }

        private void buttonCustomerChange_Click(object sender, EventArgs e)
        {
            string customerName = tbCustomerName.Text;
            string customerAddress = tbCustomerAddress.Text;
            string customerCity = tbCustomerCity.Text;
            string customerCountry = tbCustomerCountry.Text;
            string customerZipCode = tbCustomerZipCode.Text;
            string customerPhoneNumber = tbCustomerPhoneNumber.Text;
            
            int countryId = 0;
            int cityId = 0;
            int addressId = 0;

            MySqlConnection c = DBConnection.conn; 
            string query = "";
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            object result = null;

            try
            {
                // Get country, address and city id
                query = "SELECT IFNULL(country.countryId, 0), IFNULL(city.cityId, 0), IFNULL(address.addressId, 0) FROM country INNER JOIN city ON city.countryId=country.countryId INNER JOIN address ON address.cityId=city.cityId WHERE country='" + customerCountry + "'";
                cmd = new MySqlCommand(query, c);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    countryId = Convert.ToInt32(rdr[0]);
                    cityId = Convert.ToInt32(rdr[1]);
                    addressId = Convert.ToInt32(rdr[2]);
                }

                rdr.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            if (changeType == "add")
            {

                try
                {

                    if(countryId == 0)
                    {
                        query = "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + customerCountry + "', NOW(), '" + Login.userName + "', NOW(), '" + Login.userName + "')";
                        cmd = new MySqlCommand(query, c);
                        cmd.ExecuteNonQuery();
                        countryId = Convert.ToInt32(cmd.LastInsertedId);
                    }


                    if (cityId == 0)
                    {
                        query = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + customerCity + "', '" +countryId + "', NOW(), '" + Login.userName + "', NOW(), '" + Login.userName + "')";
                        cmd = new MySqlCommand(query, c);
                        cmd.ExecuteNonQuery();
                        cityId = Convert.ToInt32(cmd.LastInsertedId);
                    }


                    if (addressId == 0)
                    {
                        query = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + customerAddress + "', '', '" + cityId + "', '" + customerZipCode + "', '" + customerPhoneNumber + "', NOW(), '" + Login.userName + "', NOW(), '" + Login.userName + "')";
                        cmd = new MySqlCommand(query, c);
                        cmd.ExecuteNonQuery();
                        addressId = Convert.ToInt32(cmd.LastInsertedId);
                    }


                    query = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + customerName + "', '" + addressId + "', '1', NOW(), '" + Login.userName + "', NOW(), '" + Login.userName + "')";
                    cmd = new MySqlCommand(query, c);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("New customer added");


                    this.Visible = false;
                    MainForm newForm = new MainForm("customers");
                    newForm.Show();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("error: " + ex.ToString());
                }
            }
            else if(changeType == "update")
            {

                try
                {
                    bool addressChange = false;
                    bool cityChange = false;
                    bool countryChange = false;
                    bool customerChange = false;


                    // Check if country is changed
                    if (Customer.allCustomers[customerIndex].country != customerCountry)
                    {
                        query = "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + customerCountry + "', NOW(), '" + Login.userName + "', NOW(), '" + Login.userName + "')";
                        cmd = new MySqlCommand(query, c);
                        cmd.ExecuteNonQuery();
                        countryId = Convert.ToInt32(cmd.LastInsertedId);

                        countryChange = true;
                    }


                    // Check if city is changed
                    if (Customer.allCustomers[customerIndex].city != customerCity || countryChange)
                    {
                        query = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + customerCity + "', '" + countryId + "', NOW(), '" + Login.userName + "', NOW(), '" + Login.userName + "')";
                        cmd = new MySqlCommand(query, c);
                        cmd.ExecuteNonQuery();
                        cityId = Convert.ToInt32(cmd.LastInsertedId);

                        cityChange = true;
                    }

                    // Check if address is changed
                    if (Customer.allCustomers[customerIndex].address != customerAddress || Customer.allCustomers[customerIndex].postalCode != customerZipCode || Customer.allCustomers[customerIndex].phone != customerPhoneNumber || cityChange)
                    {
                        query = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + customerAddress + "', '', '" + cityId + "', '" + customerZipCode + "', '" + customerPhoneNumber + "', NOW(), '" + Login.userName + "', NOW(), '" + Login.userName + "')";
                        cmd = new MySqlCommand(query, c);
                        cmd.ExecuteNonQuery();
                        addressId = Convert.ToInt32(cmd.LastInsertedId);

                        addressChange = true;
                    }


                    // Check if customer name is changed
                    if (Customer.allCustomers[customerIndex].name != customerName || addressChange)
                    {
                        query = "UPDATE customer SET customerName='" + customerName + "', addressId='" + addressId +"', lastUpdate=NOW(), lastUpdateBy='" + Login.userName + "' WHERE customerId=" + Customer.allCustomers[customerIndex].id;
                        cmd = new MySqlCommand(query, c);
                        cmd.ExecuteNonQuery();

                        customerChange = true;
                    }

                    if (customerChange || addressChange || cityChange || countryChange)
                    {
                        MessageBox.Show("Customer record updated");

                        this.Visible = false;
                        MainForm newForm = new MainForm("customers");
                        newForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("No changes made");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }
}
