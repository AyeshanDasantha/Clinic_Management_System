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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
            timer1.Start();
            
        }
        //Enter Button Code
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan Tspan = to - from;
            double days = Tspan.TotalDays;
            textBox5.Text = (days / 365).ToString("0 Years Old");
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox5_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton4_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton5_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton6_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox6_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        //end Enter
        config o = new config();
        string Gender;
        string MarriedStatus;
        SqlConnection con;
        string str;
        private void registration_Load(object sender, EventArgs e)
        {
            //roll no
            str = @"Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True";
            con = new SqlConnection(str);
            con.Open();
            string s = "select max(PatientID)+1 from P_BlindSource";
            SqlCommand csm = new SqlCommand(s, con);
            csm.ExecuteNonQuery();
            SqlDataReader dd = csm.ExecuteReader();
            while (dd.Read())
            {
                int n = dd.GetInt32(0);
                label17.Text = n.ToString();
            }

            con.Close();
            //end
           

            

            // TODO: This line of code loads data into the 'disease_DataSet.Patient_Reg' table. You can move, or remove it, as needed.
            this.patient_RegTableAdapter.Fill(this.disease_DataSet.Patient_Reg);
            // TODO: This line of code loads data into the 'diseaseDataSet.Patient_Reg' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'disease_DataSet.Patient_Reg' table. You can move, or remove it, as needed.
            this.patient_RegTableAdapter.Fill(this.disease_DataSet.Patient_Reg);

            //str = @"Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True";
            //con = new SqlConnection(str);
            //con.Open();
            //label17.Text = getroll();
        }
        /*String getroll()
        {

            string qry = ("SELECT COUNT(*)FROM P_BlindSource");
            SqlCommand cmd = new SqlCommand(qry, con);
            int a = 100001 + (Int32)cmd.ExecuteScalar();
            string reg = "" + a.ToString();
            return (reg);
        }*/

        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            label14.Text = "-";
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            clearall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.SelectedIndex != -1 )
            {
                try
                {
                    string qry = "INSERT INTO Patient_Reg(PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime,Weight,Height,BMI,Blood_Group,Disease,Discription) VALUES('" + label17.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + this.dateTimePicker1.Text + "','" + textBox5.Text + "','" + Gender + "','" + MarriedStatus + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + label15.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox12.Text + "')";
                    string qry2 = "INSERT INTO P_BlindSource(PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime,Weight,Height,BMI,Blood_Group,Disease,Discription) VALUES('" + label17.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + this.dateTimePicker1.Text + "','" + textBox5.Text + "','" + Gender + "','" + MarriedStatus + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + label15.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox12.Text + "')";
                    SqlCommand cmd = new SqlCommand(qry, o.con);
                    SqlCommand cmd2 = new SqlCommand(qry2, o.con);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    //label14.ForeColor = Color.Green;
                    //label14.Text = "Data Stored";
                    MessageBox.Show("Saved Successfully !!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    label14.Text = "-";
                    //label17.Text = "";
                    //label17.Text = getroll();
                    textBox9.Clear();
                    textBox10.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";

                    //roll no
                    str = @"Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True";
                    con = new SqlConnection(str);
                    con.Open();
                    string s = "select max(PatientID)+1 from P_BlindSource";
                    SqlCommand csm = new SqlCommand(s, con);
                    csm.ExecuteNonQuery();
                    SqlDataReader dd = csm.ExecuteReader();
                    while (dd.Read())
                    {
                        int n = dd.GetInt32(0);
                        label17.Text = n.ToString();
                    }

                    con.Close();
                    //end
                  

                }
                catch (Exception x)
                {
                    label14.ForeColor = Color.Red;
                    label14.Text = x.Message;
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Datas !!");
            }

        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "MALE";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "FEMALE";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MarriedStatus = "Single";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MarriedStatus = "Married";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            MarriedStatus = "Divorced";
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            MarriedStatus = "Window";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label15.Text = datetime.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "")
                try
                {
                    
                    double weight = Convert.ToDouble(textBox9.Text);
                    double height = Convert.ToDouble(textBox10.Text);
                    double bmi = (weight / (height * height)) * 10000;
                    textBox11.Text = bmi.ToString("0.0");
                    label19.Text = "";
                }
                catch (Exception x)
                {
                    label19.ForeColor = Color.Red;
                    label19.Text = x.Message;
                }
            else
            {
                label19.Text = "-";
                MessageBox.Show("Please Enter Wight And Hight !!");
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        

        
    }
}
