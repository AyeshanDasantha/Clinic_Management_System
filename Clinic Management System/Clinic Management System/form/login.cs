using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinic_Management_System.Class;
using System.Data.SqlClient;

namespace Clinic_Management_System.form
{
    public partial class login : Form
    {
        public login()
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
        private void login_Load(object sender, EventArgs e)
        {
            //enter ky press login 
            this.AcceptButton = button1;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are You Sure Exit ?", "Log Out System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        
    }
}
