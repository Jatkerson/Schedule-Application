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

namespace Project
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            displayCustomers();

        }

        private void displayCustomers()
        {

            // Ensure no customers in list
            for(int i = 0; i < Customer.allCustomers.Count; i++)
            {
                Customer.allCustomers.RemoveAt(i);
            }

            MySqlConnection c = DBConnection.conn;

            try
            {
                // Get all customers
                string query = "SELECT customerId, customerName, address, city, postalCode, country, phone FROM customer INNER JOIN address ON address.addressId=customer.addressId INNER JOIN city ON city.cityId=address.cityId INNER JOIN country ON country.countryId=city.countryId";
                MySqlCommand cmd = new MySqlCommand(query, c);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    Customer newCustomer = new Customer(Convert.ToInt32(rdr[0]), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString());

                    Customer.allCustomers.Add(newCustomer);
                }

                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }

            /*
            // Ensure no customers in list
            for (int i = 0; i < Customer.allCustomers.Count; i++)
            {
                MessageBox.Show(Customer.allCustomers[i].name);
            }
            */

            dgvCustomers.DataSource = Customer.allCustomers;


            labelDisplayHeading.Text = "Customers";

            panelCustomers.Visible = true;
            panelAppointments.Visible = false;
            panelCalendar.Visible = false;
            panelReports.Visible = false;

            buttonCustomers.BackColor = SystemColors.ActiveCaption;
            buttonAppointments.BackColor = SystemColors.Control;
            buttonCalendar.BackColor = SystemColors.Control;
            buttonReports.BackColor = SystemColors.Control;

            buttonCustomerAdd.Enabled = true;
            buttonCustomerDelete.Enabled = false;
            buttonCustomerUpdate.Enabled = false;
        }

        private void displayAppointments()
        {

            // Ensure no customers in list
            for (int i = 0; i < Appointment.allAppointments.Count; i++)
            {
                Appointment.allAppointments.RemoveAt(i);
            }

            MySqlConnection c = DBConnection.conn;

            try
            {
                // Get all customers
                string query = "SELECT appointmentId, userId, type, customerName, start, end FROM appointment INNER JOIN customer ON customer.customerId=appointment.customerId";
                MySqlCommand cmd = new MySqlCommand(query, c);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    Appointment newAppointment = new Appointment(Convert.ToInt32(rdr[0]), Convert.ToInt32(rdr[1]), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString());

                    Appointment.allAppointments.Add(newAppointment);
                }

                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }

            /*
            // Ensure no customers in list
            for (int i = 0; i < Customer.allCustomers.Count; i++)
            {
                MessageBox.Show(Customer.allCustomers[i].name);
            }
            */

            dgvAppointments.DataSource = Appointment.allAppointments;


            labelDisplayHeading.Text = "Appointments";

            panelAppointments.Visible = true;
            panelCustomers.Visible = false;
            panelCalendar.Visible = false;
            panelReports.Visible = false;

            buttonAppointments.BackColor = SystemColors.ActiveCaption;
            buttonCustomers.BackColor = SystemColors.Control;
            buttonCalendar.BackColor = SystemColors.Control;
            buttonReports.BackColor = SystemColors.Control;

            buttonAppointmentAdd.Enabled = true;
            buttonAppointmentUpdate.Enabled = false;
            buttonAppointmentDelete.Enabled = false;
        }

        private void displayCalendar()
        {

            labelDisplayHeading.Text = "Calendar";

            panelCalendar.Visible = true;
            panelAppointments.Visible = false;
            panelCustomers.Visible = false;
            panelReports.Visible = false;

            buttonCalendar.BackColor = SystemColors.ActiveCaption;
            buttonAppointments.BackColor = SystemColors.Control;
            buttonCustomers.BackColor = SystemColors.Control;
            buttonReports.BackColor = SystemColors.Control;

            buttonCalendarAll.BackColor = SystemColors.ActiveCaption;
            buttonCalendarWeek.BackColor = SystemColors.Control;
            buttonCalendarMonth.BackColor = SystemColors.Control;
        }

        private void displayReports()
        {

            labelDisplayHeading.Text = "Reports";

            panelReports.Visible = true;
            panelAppointments.Visible = false;
            panelCustomers.Visible = false;
            panelCalendar.Visible = false;

            buttonReports.BackColor = SystemColors.ActiveCaption;
            buttonCalendar.BackColor = SystemColors.Control;
            buttonAppointments.BackColor = SystemColors.Control;
            buttonCustomers.BackColor = SystemColors.Control;

            cbReportType.SelectedIndex = 0;
            cbReportMonth.SelectedIndex = 0;
            cbReportConsultant.SelectedIndex = 0;

            buttonReportTypeByMonth.Enabled = false;
            buttonReportConsultantSchedule.Enabled = false;
            buttonReport3.Enabled = true;
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            displayCustomers();
        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            displayAppointments();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            displayCalendar();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            displayReports();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login newForm = new Login();
            newForm.Show();
        }

        private void buttonCustomerAdd_Click(object sender, EventArgs e)
        {
            CustomerForm newForm = new CustomerForm("add");
            newForm.Show();
            this.Visible = false;
        }

        private void buttonCustomerUpdate_Click(object sender, EventArgs e)
        {
            CustomerForm newForm = new CustomerForm("update");
            newForm.Show();
            this.Visible = false;
        }

        private void buttonAppointmentAdd_Click(object sender, EventArgs e)
        {
            AppointmentForm newForm = new AppointmentForm("add");
            newForm.Show();
            this.Visible = false;
        }
    }
}
