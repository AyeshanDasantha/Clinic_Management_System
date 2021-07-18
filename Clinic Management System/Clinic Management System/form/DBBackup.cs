using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic_Management_System.form
{
    public partial class DBBackup : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = "";
        string connectionString = "";
        public DBBackup()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Data Source =" + textBox1.Text + "; User ID="+textBox2.Text+";Password="+textBox3.Text+"";
                conn = new SqlConnection(connectionString);
                conn.Open();
                //sql = "EXEC sp_databases";
                sql = "select * from sys.databases d where d.database_id>4";
                command = new SqlCommand(sql, conn);
                reader=command.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }
                reader.Dispose();
                conn.Close();
                conn.Dispose();



                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                comboBox1.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DBBackup_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            comboBox1.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox1.Enabled = false;
            button1.Enabled = true;
            button4.Enabled = false;
            button6.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.Text.CompareTo("") ==0)
                {
                    MessageBox.Show("Please Select a Data Base.");
                    return;
                }
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "BACKUP DATABASE " + comboBox1.Text + " TO DISK= '" + textBox4.Text + "\\" + comboBox1.Text + "-" + DateTime.Now.ToString("yyyy.MM.dd_HH.mm.ss") + ".bak'";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Successfully Database Backup Completed.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = fbd.SelectedPath;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            fbd.FilterIndex = 0;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = fbd.FileName;
            }
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please Select a Data Base.");
                    return;
                }
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "Alter Database " +comboBox1.Text+" Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database " + comboBox1.Text + " FROM Disk = '" + textBox5.Text + "'WITH REPLACE;";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Successfully Restore Database Completed.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
    }
}
