using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clinic_Management_System.Class;

namespace Clinic_Management_System.form
{
    public partial class Logins : Form
    {
        public Logins()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string qry = "SELECT Username,password FROM Login Where Username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
                cmd = new SqlCommand(qry, o.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Dispose(false);
                    Main a = new Main();
                    a.Show();
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Invalid User Name OR Password";
                    dr.Close();
                }
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Please Fill All Datas";
            }
            
        }
        config o = new config();
        private void Logins_Load(object sender, EventArgs e)
        {

        }

        public SqlCommand cmd { get; set; }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
