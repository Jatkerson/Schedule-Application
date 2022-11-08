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

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


            // Get connection string
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            // Declare connection
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(constr);
                conn.Open();

                MessageBox.Show("connected");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


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
                    MessageBox.Show("translate to english");
                    break;
               
                case "es":
                    MessageBox.Show("translate to spanish");
                    break;
            }
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm newForm = new MainForm();
            newForm.Show();
        }
    }

}

