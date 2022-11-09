using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Configuration;
using MySql.Data.MySqlClient;
using Project.Database;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            detectLanguage();
        }


        public void detectLanguage()
        {
            string languageCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            translateToLanguage(languageCode);
        }

        public void translateToLanguage(string languageCode)
        {
            switch (languageCode)
            {
                case "en":
                    //MessageBox.Show("translate to english");
                    break;
               
                case "es":
                    //MessageBox.Show("translate to spanish");
                    break;
            }
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection c = DBConnection.conn;

            string userName = tbLoginUsername.Text;
            string password = tbLoginPassword.Text;

            try
            {

                string query = "SELECT COUNT(userID) FROM user WHERE userName='" + userName + "' AND password='" + password + "'";
                MySqlCommand cmd = new MySqlCommand(query, c);
                object result = cmd.ExecuteScalar();

                if(result.ToString() == "0")
                {
                    MessageBox.Show("Incorrect username and password combination");
                }
                else if(result.ToString() == "1")
                {
                    this.Visible = false;
                    MainForm newForm = new MainForm();
                    newForm.Show();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }

        }
    }

}

