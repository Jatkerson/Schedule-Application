using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        public AppointmentForm(string type)
        {
            InitializeComponent();

            if (type == "add")
            {
                cbAppointmentType.SelectedIndex = 0;
                cbAppointmentCustomer.SelectedIndex = 0;
                cbAppointmentStart.SelectedIndex = 0;
                cbAppointmentEnd.SelectedIndex = 0;
                tbAppointmentUserID.Text = "0";
                buttonAppointmentChange.Text = "Add";
                buttonAppointmentChange.Enabled = false;
            }
            else if (type == "update")
            {
                cbAppointmentType.SelectedIndex = 0;
                cbAppointmentCustomer.SelectedIndex = 0;
                cbAppointmentStart.SelectedIndex = 0;
                cbAppointmentEnd.SelectedIndex = 0;
                tbAppointmentUserID.Text = "0";
                buttonAppointmentChange.Text = "Change";
                buttonAppointmentChange.Enabled = false;
            }
        }

        private void buttonAppointmentCancel_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.Show();
            this.Visible = false;
        }
    }
}
