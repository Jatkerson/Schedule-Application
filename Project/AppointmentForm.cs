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
    public partial class AppointmentForm : Form
    {
        public static AppointmentForm form;
        private string changeType;
        private int appointmentIndex = -1;
        private bool formStarted = false;

        public AppointmentForm()
        {
            if (form == null)
            {
                form = this;
            }

            formStarted = false;

            InitializeComponent();
        }

        public AppointmentForm(string type)
        {
            InitializeComponent();


            changeType = type;

            if (type == "add")
            {
                cbAppointmentType.SelectedIndex = 0;
                cbAppointmentCustomer.SelectedIndex = 0;
                tbAppointmentUserID.Text = Login.userId.ToString();
                buttonAppointmentChange.Text = "Add";
                buttonAppointmentChange.Enabled = false;

                cbAppointmentCustomer.Items.Clear();
                cbAppointmentCustomer.Items.Add("");

                for (int i = 0; i < Customer.allCustomers.Count(); i++)
                {
                    cbAppointmentCustomer.Items.Add(Customer.allCustomers[i].name);
                }

                formStarted = true;

            }
            else if (type == "update")
            {
                appointmentIndex = -1;

                for (int i = 0; i < Appointment.allAppointments.Count(); i++)
                {
                    if (Appointment.allAppointments[i].id == selectedAppointmentId)
                    {
                        appointmentIndex = i;
                        break;
                    }
                }


                if (appointmentIndex > -1)
                {

                    if(Appointment.allAppointments[appointmentIndex].type == "Presentation")
                    {
                        cbAppointmentType.SelectedIndex = 1;
                    }
                    else if(Appointment.allAppointments[appointmentIndex].type == "Scrum")
                    {
                        cbAppointmentType.SelectedIndex = 2;
                    }
                    else
                    {
                        cbAppointmentType.SelectedIndex = 0;
                    }


                    cbAppointmentCustomer.Items.Clear();
                    cbAppointmentCustomer.Items.Add("");

                    for (int i = 0; i < Customer.allCustomers.Count(); i++)
                    {
                        cbAppointmentCustomer.Items.Add(Customer.allCustomers[i].name);

                        if(Appointment.allAppointments[appointmentIndex].customerName == Customer.allCustomers[i].name)
                        {
                            cbAppointmentCustomer.SelectedIndex = i+1;
                        }
                    }


                    dtpAppointmentStart.Value = DateTime.Parse(Appointment.allAppointments[appointmentIndex].start);
                    dtpAppointmentEnd.Value = DateTime.Parse(Appointment.allAppointments[appointmentIndex].end);

                    tbAppointmentUserID.Text = Appointment.allAppointments[appointmentIndex].userId.ToString();
                }


                buttonAppointmentChange.Text = "Update";
                buttonAppointmentChange.Enabled = true;
            }

        }

        private void buttonAppointmentCancel_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm("appointments");
            newForm.Show();
            this.Visible = false;
        }

        private void cbAppointmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAppointmentType.SelectedIndex > 0 || !formStarted)
            {
                cbAppointmentType.BackColor = SystemColors.Window;
            }
            else
            {
                cbAppointmentType.BackColor = Color.IndianRed;
            }

            checkNewAppointmentInputs();
        }

        private void cbAppointmentCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAppointmentCustomer.SelectedIndex > 0 || !formStarted)
            {
                cbAppointmentCustomer.BackColor = SystemColors.Window;
            }
            else
            {
                cbAppointmentCustomer.BackColor = Color.IndianRed;
            }

            checkNewAppointmentInputs();

        }

        private void dtpAppointmentStart_ValueChanged(object sender, EventArgs e)
        {

            checkNewAppointmentInputs();
        }

        private void dtpAppointmentEnd_ValueChanged(object sender, EventArgs e)
        {

            checkNewAppointmentInputs();
        }


        private void checkNewAppointmentInputs()
        {
            bool valid = true;


            if (cbAppointmentType.SelectedIndex <= 0)
            {
                valid = false;
            }


            if (cbAppointmentCustomer.SelectedIndex <= 0)
            {
                valid = false;
            }

            if (valid)
            {
                buttonAppointmentChange.Enabled = true;
            }
            else
            {
                buttonAppointmentChange.Enabled = false;
            }


        }

        private void buttonAppointmentChange_Click(object sender, EventArgs e)
        {
            string appointmentType = cbAppointmentType.SelectedItem.ToString();
            int appointmentCustomerIndex = cbAppointmentCustomer.SelectedIndex;
            int customerId = Customer.allCustomers[appointmentCustomerIndex - 1].id;
            DateTime appointmentStartTime = dtpAppointmentStart.Value;
            DateTime appointmentEndTime = dtpAppointmentEnd.Value;



            if (appointmentStartTime.Date != appointmentEndTime.Date)
            {
                MessageBox.Show("Appointment start and end date must be the same");
                return;
            }
            else if (appointmentStartTime > appointmentEndTime)
            {
                MessageBox.Show("Appointment end time must be after start time");
                return;
            }
            else if (appointmentStartTime.Hour < 8 || appointmentStartTime.Hour > 16 || appointmentEndTime.Hour < 8 || appointmentEndTime.Hour > 17 || (appointmentEndTime.Hour == 17 && appointmentEndTime.Minute != 0))
            {
                MessageBox.Show("Appointment times must be during business hours (8AM - 5PM)");
                return;
            }
            else if (appointmentStartTime.DayOfWeek.ToString() == "Saturday" || appointmentStartTime.DayOfWeek.ToString() == "Sunday" || appointmentEndTime.DayOfWeek.ToString() == "Saturday" || appointmentEndTime.DayOfWeek.ToString() == "Sunday")
            {
                MessageBox.Show("Appointment times must be on business days (Monday - Friday)");
                return;
            }


            // Apply timezone offset for insert
            appointmentStartTime -= MainForm.timezoneOffset;
            appointmentEndTime -= MainForm.timezoneOffset;


            MySqlConnection c = DBConnection.conn;
            string query = "";
            MySqlCommand cmd = null;
            object result = null;


            // Check if new appointment time has overlap with existing customer appointment
            query = "SELECT COUNT(appointmentId) FROM appointment WHERE customerId=" + customerId + " AND ('" + appointmentStartTime.ToString("yyyy-MM-dd HH:mm:ss") + "' >= start AND '" + appointmentStartTime.ToString("yyyy-MM-dd HH:mm:ss") + "' < end) OR ('" + appointmentEndTime.ToString("yyyy-MM-dd HH:mm:ss") + "' > start AND '" + appointmentEndTime.ToString("yyyy-MM-dd HH:mm:ss") + "' <= end)";
            cmd = new MySqlCommand(query, c);
            result = cmd.ExecuteScalar();

            if(Convert.ToInt32(result) > 0)
            {
                MessageBox.Show("This appointment time overlaps with another appointment for this customer");
                return;
            }


            if (changeType == "add")
            {

                try
                {

                    query = "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + customerId + "', '" + Login.userId + "', 'not needed', 'not needed', 'not needed', 'not needed', '" + appointmentType + "', 'not needed', '" + appointmentStartTime.ToString("yyyy-MM-dd HH:mm") + "', '" + appointmentEndTime.ToString("yyyy-MM-dd HH:mm") + "', NOW(), '" + Login.userName + "', NOW(), '" + Login.userName + "')";
                    cmd = new MySqlCommand(query, c);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("New appointment added");


                    this.Visible = false;
                    MainForm newForm = new MainForm("appointments");
                    newForm.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.ToString());
                }
            }
            else if (changeType == "update")
            {


                query = "UPDATE appointment SET customerId='" + customerId + "', type='" + appointmentType + "', start='" + appointmentStartTime.ToString("yyyy-MM-dd HH:mm") + "', end='" + appointmentEndTime.ToString("yyyy-MM-dd HH:mm") + "', lastUpdate=NOW(), lastUpdateBy='" + Login.userName + "' WHERE appointmentId='" + selectedAppointmentId + "'";
                cmd = new MySqlCommand(query, c);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Appointment updated");


                this.Visible = false;
                MainForm newForm = new MainForm("appointments");
                newForm.Show();

            }



        }





    }

}
