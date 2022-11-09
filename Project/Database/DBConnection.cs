using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project.Database
{
    public class DBConnection
    {
        public static MySqlConnection conn { get; set; }

        public static void startConnection()
        {
            try
            {
                // Get connection string
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

                conn = new MySqlConnection(constr);
                conn.Open();

                //MessageBox.Show("connected");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }
}
