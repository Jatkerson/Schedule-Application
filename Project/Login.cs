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
        public static string userName = "";
        public static int userId = 0;

        public Login()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection c = DBConnection.conn;

            userName = tbLoginUsername.Text;
            string password = tbLoginPassword.Text;

            try
            {

                string query = "SELECT userID FROM user WHERE userName='" + userName + "' AND password='" + password + "'";
                MySqlCommand cmd = new MySqlCommand(query, c);
                object result = cmd.ExecuteScalar();

                if(result == null)
                {
                    string languageCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

                    if(languageCode == "en")
                    {
                        MessageBox.Show("Incorrect username and password combination");
                    }
                    else if(languageCode == "es")
                    {
                        MessageBox.Show("Combinación incorrecta de nombre de usuario y contraseña");
                    }

                }
                else
                {
                    userId = Convert.ToInt32(result);

                    this.Visible = false;
                    MainForm newForm = new MainForm("customers");
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

