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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(string type)
        {
            InitializeComponent();

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
    }
}
