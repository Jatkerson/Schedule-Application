﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            displayCustomers();

        }

        private void displayCustomers()
        {

            labelDisplayHeading.Text = "Customers";

            panelCustomers.Visible = true;
            panelAppointments.Visible = false;
            panelCalendar.Visible = false;

            buttonCustomers.BackColor = SystemColors.ActiveCaption;
            buttonAppointments.BackColor = SystemColors.Control;
            buttonCalendar.BackColor = SystemColors.Control;

            buttonCustomerAdd.Enabled = true;
            buttonCustomerDelete.Enabled = false;
            buttonCustomerUpdate.Enabled = false;
        }

        private void displayAppointments()
        {

            labelDisplayHeading.Text = "Appointments";

            panelAppointments.Visible = true;
            panelCustomers.Visible = false;
            panelCalendar.Visible = false;

            buttonAppointments.BackColor = SystemColors.ActiveCaption;
            buttonCustomers.BackColor = SystemColors.Control;
            buttonCalendar.BackColor = SystemColors.Control;

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

            buttonCalendar.BackColor = SystemColors.ActiveCaption;
            buttonAppointments.BackColor = SystemColors.Control;
            buttonCustomers.BackColor = SystemColors.Control;

            buttonCalendarAll.BackColor = SystemColors.ActiveCaption;
            buttonCalendarWeek.BackColor = SystemColors.Control;
            buttonCalendarMonth.BackColor = SystemColors.Control;
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login newForm = new Login();
            newForm.Show();
        }
    }
}
