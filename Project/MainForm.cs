using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public static MainForm form;
        public static int selectedCustomerId = -1;
        public static int selectedAppointmentId = -1;
        public static TimeSpan timezoneOffset = DateTime.Now - DateTime.UtcNow;
        public static int timezoneOffsetHour = (DateTime.Now - DateTime.UtcNow).Hours;

        public MainForm()
        {
            if (form == null)
            {
                form = this;

            }

            InitializeComponent();
        }

        public MainForm(string display)
        {
            if (form == null)
            {
                form = this;

            }

            InitializeComponent();


            // Determine which display to show - reloads class data
            if (display == "customers")
            {
                displayCustomers();
            }
            else if(display == "appointments")
            {
                displayAppointments();
            }
        }


        public void displayCustomers()
        {
            // Clear out existing data
            dgvCustomers.DataSource = null;
            dgvCustomers.Refresh();

            // Ensure no customers in list
            while(Customer.allCustomers.Count > 0)
            {
                Customer.allCustomers.RemoveAt(0);
            }


            // Attempt to get all customers from database
            // Add each customer to the allCustomers list
            try
            {

                MySqlConnection c = DBConnection.conn;

                string query = "SELECT customerId, customerName, address, city, country, postalCode, phone FROM customer INNER JOIN address ON address.addressId=customer.addressId INNER JOIN city ON city.cityId=address.cityId INNER JOIN country ON country.countryId=city.countryId";
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


            // Set data and values to initial view for customer datagridview
            dgvCustomers.DataSource = Customer.allCustomers;
            dgvCustomers.ClearSelection();
            selectedCustomerId = -1;

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

        public void displayAppointments()
        {

            // Clear out existing data
            dgvAppointments.DataSource = null;
            dgvAppointments.Refresh();
            selectedAppointmentId = -1;


            // Ensure no appointments in list
            while (Appointment.allAppointments.Count > 0)
            {
                Appointment.allAppointments.RemoveAt(0);
            }


            // Attepmt to get all appointments from database
            // Add each appointment to the allAppointments list
            try
            {

                MySqlConnection c = DBConnection.conn;

                string query = "SELECT appointmentId, userId, type, customerName, ADDDATE(start, INTERVAL " + timezoneOffsetHour.ToString() + " HOUR), ADDDATE(end, INTERVAL " + timezoneOffsetHour.ToString() + " HOUR)  FROM appointment INNER JOIN customer ON customer.customerId=appointment.customerId";
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


            // Set data and values to initial view for appointment datagridview
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

        private void displayCalendar(string view)
        {

            // Clear out existing data
            dgvCalendar.DataSource = null;
            dgvCalendar.Refresh();

            // Ensure no appointments in list
            while (Appointment.allAppointments.Count > 0)
            {
                Appointment.allAppointments.RemoveAt(0);
            }


            string calendarFilter = "";

            // Determine which calendar view to display
            // Set additional WHERE statement if user has selected week or month view
            if (view == "all")
            {
                calendarFilter = "";

                buttonCalendarAll.BackColor = SystemColors.ActiveCaption;
                buttonCalendarWeek.BackColor = SystemColors.Control;
                buttonCalendarMonth.BackColor = SystemColors.Control;
            }
            else if(view == "week")
            {
                calendarFilter = " WHERE start >= DATE_SUB(NOW(), INTERVAL 7 DAY)";

                buttonCalendarAll.BackColor = SystemColors.Control;
                buttonCalendarWeek.BackColor = SystemColors.ActiveCaption;
                buttonCalendarMonth.BackColor = SystemColors.Control;
            }
            else if(view == "month")
            {
                calendarFilter = " WHERE YEAR(start) = YEAR(CURRENT_DATE()) AND MONTH(start) = MONTH(CURRENT_DATE())";
                
                buttonCalendarAll.BackColor = SystemColors.Control;
                buttonCalendarWeek.BackColor = SystemColors.Control;
                buttonCalendarMonth.BackColor = SystemColors.ActiveCaption;
            }


            // Attempt to get all appointments in the selected timeframe
            // Add each appointment to the allAppointments list
            try
            {

                MySqlConnection c = DBConnection.conn;
                DateTime start;

                // Get all appointments
                string query = "SELECT appointmentId, userId, type, customerName, ADDDATE(start, INTERVAL " + timezoneOffsetHour.ToString() + " HOUR), ADDDATE(end, INTERVAL " + timezoneOffsetHour.ToString() + " HOUR) FROM appointment INNER JOIN customer ON customer.customerId=appointment.customerId" + calendarFilter;
                MySqlCommand cmd = new MySqlCommand(query, c);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    Appointment newAppointment = new Appointment(Convert.ToInt32(rdr[0]), Convert.ToInt32(rdr[1]), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString());

                    Appointment.allAppointments.Add(newAppointment);

                    start = (DateTime)rdr[4];

                    if (start <= DateTime.Now.AddMinutes(15) && start > DateTime.Now)
                    {
                        MessageBox.Show("You have an upcoming appointment, check the calendar");
                    }
                }

                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }


            // Set data and values to view for calendar datagridview
            dgvCalendar.DataSource = Appointment.allAppointments;

            labelDisplayHeading.Text = "Calendar";

            panelCalendar.Visible = true;
            panelAppointments.Visible = false;
            panelCustomers.Visible = false;
            panelReports.Visible = false;

            buttonCalendar.BackColor = SystemColors.ActiveCaption;
            buttonAppointments.BackColor = SystemColors.Control;
            buttonCustomers.BackColor = SystemColors.Control;
            buttonReports.BackColor = SystemColors.Control;
        }

        private void displayReports()
        {

            // Set view for initial report display
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
            buttonReport3.Enabled = false;


            // Clear all consultants from the combobox and add blank first value
            cbReportConsultant.Items.Clear();
            cbReportConsultant.Items.Add("");


            // Attempt to get all users from database
            // Add each user to the consultant combobox
            try
            {

                MySqlConnection c = DBConnection.conn;

                string query = "SELECT userName FROM user";
                MySqlCommand cmd = new MySqlCommand(query, c);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    cbReportConsultant.Items.Add(rdr[0]);
                }

                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }


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
            displayCalendar("all");
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

        private void buttonAppointmentUpdate_Click(object sender, EventArgs e)
        {
            AppointmentForm newForm = new AppointmentForm("update");
            newForm.Show();
            this.Visible = false;
        }

        private void dgvCustomers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCustomers.ClearSelection();
        }

        private void dgvAppointments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAppointments.ClearSelection();
        }

        private void dgvCalendar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCalendar.ClearSelection();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCustomerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);

            if(selectedCustomerId > 0)
            {
                buttonCustomerDelete.Enabled = true;
                buttonCustomerUpdate.Enabled = true;
            }
            else
            {
                buttonCustomerDelete.Enabled = false;
                buttonCustomerUpdate.Enabled = false;
            }
        }

        private void buttonCustomerDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo);
            
            if(dialogResult == DialogResult.Yes)
            {

                // Attempt to delete customer
                // Customer appointments must first be deleted as Primary/Foreign key relation exists
                // Reload customer display
                try
                {

                    MySqlConnection c = DBConnection.conn;

                    // Delete all appointments for customer
                    string query = "DELETE FROM appointment WHERE customerId = " + selectedCustomerId;
                    MySqlCommand cmd = new MySqlCommand(query, c);
                    cmd.ExecuteNonQuery();

                    // Delete only the customer record
                    query = "DELETE FROM customer WHERE customerId = " + selectedCustomerId;
                    cmd = new MySqlCommand(query, c);
                    cmd.ExecuteNonQuery();

                    displayCustomers();
                    MessageBox.Show("Customer deleted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.ToString());
                }

            }
        }

        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedAppointmentId = Convert.ToInt32(dgvAppointments.CurrentRow.Cells[0].Value);

            if (selectedAppointmentId > 0)
            {
                buttonAppointmentDelete.Enabled = true;
                buttonAppointmentUpdate.Enabled = true;
            }
            else
            {
                buttonAppointmentDelete.Enabled = false;
                buttonAppointmentUpdate.Enabled = false;
            }
        }

        private void buttonAppointmentDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete Appointment", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                // Attempt to delete appointment
                // Reload appointment display
                try
                {

                    MySqlConnection c = DBConnection.conn;

                    // Delete appointment record
                    string query = "DELETE FROM appointment WHERE appointmentId = " + selectedAppointmentId;
                    MySqlCommand cmd = new MySqlCommand(query, c);
                    cmd.ExecuteNonQuery();

                    displayAppointments();
                    MessageBox.Show("Appointment deleted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.ToString());
                }

            }
        }

        private void buttonCalendarAll_Click(object sender, EventArgs e)
        {
            displayCalendar("all");
        }

        private void buttonCalendarWeek_Click(object sender, EventArgs e)
        {
            displayCalendar("week");
        }

        private void buttonCalendarMonth_Click(object sender, EventArgs e)
        {
            displayCalendar("month");
        }

        private void cbReportConsultant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReportConsultant.SelectedIndex > 0)
            {
                buttonReportConsultantSchedule.Enabled = true;
            }
            else
            {
                buttonReportConsultantSchedule.Enabled = false;
            }
        }

        private void buttonReportConsultantSchedule_Click(object sender, EventArgs e)
        {
            string userName = cbReportConsultant.SelectedItem.ToString();


            // Attempt to get appointment count for consultant - based on consultant userName
            // Reload appointment display
            try
            {

                MySqlConnection c = DBConnection.conn;

                string query = "SELECT COUNT(appointmentId) FROM appointment INNER JOIN user ON user.userId=appointment.userId WHERE userName='" + userName + "'";
                MySqlCommand cmd = new MySqlCommand(query, c);
                object result = cmd.ExecuteScalar();

                MessageBox.Show("Consultant has " + result.ToString() + " appointment(s)");

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }
        }

        private void buttonReportTypeByMonth_Click(object sender, EventArgs e)
        {
            
            string appointmentType = cbReportType.SelectedItem.ToString();
            string monthName = cbReportMonth.SelectedItem.ToString();
            int monthNumber = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(monthName) + 1;


            // Attempt to get count of appointment type by month
            // Reload appointment display
            try
            {

                MySqlConnection c = DBConnection.conn;

                string query = "SELECT COUNT(appointmentId) FROM appointment WHERE type='" + appointmentType + "' AND MONTH(start)=" + monthNumber;
                MySqlCommand cmd = new MySqlCommand(query, c);
                object result = cmd.ExecuteScalar();

                MessageBox.Show(result.ToString() + " " + appointmentType + " appointment(s) in " + monthName);

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }

        }

        private void cbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReportType.SelectedIndex > 0 && cbReportMonth.SelectedIndex > 0)
            {
                buttonReportTypeByMonth.Enabled = true;
            }
            else
            {
                buttonReportTypeByMonth.Enabled = false;
            }

        }

        private void cbReportMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReportType.SelectedIndex > 0 && cbReportMonth.SelectedIndex > 0)
            {
                buttonReportTypeByMonth.Enabled = true;
            }
            else
            {
                buttonReportTypeByMonth.Enabled = false;
            }
        }

        private void buttonReport3_Click(object sender, EventArgs e)
        {
            string sortType = cbReportSortCustomers.SelectedItem.ToString();
            string customerDisplayString = "";


            if (sortType == "Customer Name")
            {
                // Create a new variable to hold a re-ordered list of customers based on customer name using a lambda expression
                // This lambda expression minimizes the code necessary to create a re-ordered list
                var customerSort = Customer.allCustomers.OrderBy(x => x.name);

                foreach (var sortedCustomer in customerSort)
                {
                    customerDisplayString += "\n" + sortedCustomer.name + " " + sortedCustomer.country;
                }
            }
            else if(sortType == "Country")
            {
                // Create a new variable to hold a re-ordered list of customers based on customer country using a lambda expression
                // This lambda expression minimizes the code necessary to create a re-ordered list
                var customerSort = Customer.allCustomers.OrderBy(x => x.country);

                foreach(var sortedCustomer in customerSort)
                {
                    customerDisplayString += "\n" + sortedCustomer.name + "          " + sortedCustomer.country;
                }
            }

            // Show customer list with sort applied
            MessageBox.Show(customerDisplayString);

        }

        private void cbReportSortCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbReportSortCustomers.SelectedIndex > 0)
            {
                buttonReport3.Enabled = true;
            }
            else
            {
                buttonReport3.Enabled = false;
            }
        }
    }
}
