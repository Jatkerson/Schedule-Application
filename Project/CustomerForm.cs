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


namespace Project
{
    public partial class CustomerForm : Form
    {

        private string changeType;

        public CustomerForm()
        {
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
                tbCustomerName.Text = "Name";
                tbCustomerAddress.Text = "";
                tbCustomerCity.Text = "";
                tbCustomerCountry.Text = "";
                tbCustomerPhoneNumber.Text = "";
                buttonCustomerChange.Text = "Update";
                buttonCustomerChange.Enabled = false;
            }
        }

        private void buttonCustomerCancel_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
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
            if (tbCustomerPhoneNumber.TextLength >= 10)
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


            if (tbCustomerPhoneNumber.TextLength < 10)
            {
                valid = false;
            }


            if (valid)
            {
                buttonCustomerChange.Enabled = true;
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
            

            if(changeType == "add")
            {

                MySqlConnection c = DBConnection.conn;

                try
                {

                    // Get country, address and city id
                    string query = "SELECT IFNULL(country.countryId, 0), IFNULL(city.cityId, 0), IFNULL(address.addressId, 0) FROM country INNER JOIN city ON city.countryId=country.countryId INNER JOIN address ON address.cityId=city.cityId WHERE country='" + customerCountry + "'";
                    MySqlCommand cmd = new MySqlCommand(query, c);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    int countryId = 0;
                    int cityId = 0;
                    int addressId = 0;

                    while (rdr.Read())
                    {
                        countryId = Convert.ToInt32(rdr[0]);
                        cityId = Convert.ToInt32(rdr[1]);
                        addressId = Convert.ToInt32(rdr[2]);
                    }

                    rdr.Close();


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

                }
                catch(Exception ex)
                {
                    MessageBox.Show("error: " + ex.ToString());
                }
            }
            else if(changeType == "update")
            {

            }

        }
    }
}
