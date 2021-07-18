using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clinic_Management_System.Class
{
    class config
    {
        public SqlConnection con;
        public string str;

        public config()
        {
            try
            {
                str = @"Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                //MessageBox.Show("Database connected");
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);

            }
           }
        }
    }

       
