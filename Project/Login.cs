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
using System.IO;

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


                    using (StreamWriter sw = File.AppendText("log.txt"))
                    {
                        sw.WriteLine("Failed login attempt with user " + userName + " at " + DateTime.Now.ToString());
                    }


                }
                else
                {

                    using (StreamWriter sw = File.AppendText("log.txt"))
                    {
                        sw.WriteLine("User " + userName + " logged in at " + DateTime.Now.ToString());
                    }

                    userId = Convert.ToInt32(result);

                    query = "SELECT ADDDATE(start, INTERVAL " + MainForm.timezoneOffsetHour.ToString() + " HOUR) FROM appointment WHERE userId='" + userId + "'";
                    cmd = new MySqlCommand(query, c);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    DateTime start;

                    while (rdr.Read())
                    {
                        start = (DateTime)rdr[0];

                        if (start <= DateTime.Now.AddMinutes(15) && start > DateTime.Now)
                        {
                            MessageBox.Show("You have an upcoming appointment, check the calendar");
                        }
                    }

                    rdr.Close();


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

