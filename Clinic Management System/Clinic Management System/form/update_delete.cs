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
    public partial class update_delete : Form
    {
        public update_delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                try
                {
                    string Source = @"Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True";
                    SqlConnection con = new SqlConnection(Source);
                    con.Open();
                    //MessageBox.Show("ok");

                    string sqlselectquert = "select * from Patient_Reg where PatientID =" + int.Parse(textBox1.Text);
                    SqlCommand cmd = new SqlCommand(sqlselectquert, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox01.Text = (dr["PatientID"].ToString());
                        comboBox3.Text = (dr["Saluation"].ToString());
                        textBox3.Text = (dr["FirstName"].ToString());
                        textBox4.Text = (dr["MiddleName"].ToString());
                        textBox5.Text = (dr["LastName"].ToString());
                        textBox6.Text = (dr["NIC"].ToString());
                        dateTimePicker1.Text = (dr["DOB"].ToString());
                        textBox8.Text = (dr["Age"].ToString());
                        comboBox1.Text = (dr["Gender"].ToString());
                        comboBox2.Text = (dr["MarriedStatus"].ToString());
                        textBox11.Text = (dr["Address"].ToString());
                        textBox12.Text = (dr["CHome"].ToString());
                        textBox13.Text = (dr["CMobile"].ToString());
                        textBox14.Text = (dr["Regdatetime"].ToString());

                        textBox20.Text = (dr["Weight"].ToString());
                        textBox21.Text = (dr["Height"].ToString());
                        textBox22.Text = (dr["BMI"].ToString());
                        textBox23.Text = (dr["Discription"].ToString());
                        comboBox4.Text = (dr["Blood_Group"].ToString());
                        comboBox5.Text = (dr["Disease"].ToString());


                    }
                    else
                    {
                        textBox01.Text = "";
                        comboBox3.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        dateTimePicker1.Text = "";
                        textBox8.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";
                        label16.Text = "-";

                        textBox20.Text = "";
                        textBox21.Text = "";
                        textBox22.Text = "";
                        textBox23.Text = "";
                        comboBox4.Text = "";
                        comboBox5.Text = "";

                        MessageBox.Show("No Record Found Please Enter Correct Patient ID");
                    }
                }
                catch (Exception x)
                {
                    label16.ForeColor = Color.Red;
                    label16.Text = x.Message;
                }
            else
            {
                MessageBox.Show("Please Enter Patient ID");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan Tspan = to - from;
            double days = Tspan.TotalDays;
            textBox8.Text = (days / 365).ToString("0 Years Old");
        }
        config o = new config();

        private void update_delete_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            // TODO: This line of code loads data into the 'pID_search_box_dataset.Patient_Reg' table. You can move, or remove it, as needed.
            this.patient_RegTableAdapter1.Fill(this.pID_search_box_dataset.Patient_Reg);
            // TODO: This line of code loads data into the 'pID_search_box_dataset.Patient_Reg' table. You can move, or remove it, as needed.

            string Source = @"Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(Source);
            con.Open();
            //MessageBox.Show("ok");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.SelectedIndex != -1)
            {
                try
                {
                    
                    //string updateqry = "update Patient_Reg set PatientID='" + textBox01.Text + "',Saluation='" + comboBox3.Text + "',FirstName ='" + textBox3.Text + "',MiddleName ='" + textBox4.Text + "',LastName='" + textBox5.Text + "',NIC='" + textBox6.Text + "',DOB='" + this.dateTimePicker1.Text + "',Age='" + textBox8.Text + "',Gender='" + comboBox1 + "',MarriedStatus='" + comboBox2 + "',Address='" + textBox11.Text + "',CHome='" + textBox12.Text + "',CMobile='" + textBox13.Text + "',Regdatetime='" + textBox14.Text + "' where PatientID='" + e + "'";
                    var result = MessageBox.Show("Are You Sure Update This Patinet Registry ?", "Update Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string updateqry = "update Patient_Reg set PatientID='" + textBox01.Text + "',Saluation='" + comboBox3.Text + "',FirstName ='" + textBox3.Text + "',MiddleName ='" + textBox4.Text + "',LastName='" + textBox5.Text + "',NIC='" + textBox6.Text + "',DOB='" + this.dateTimePicker1.Text + "',Age='" + textBox8.Text + "',Gender='" + comboBox1.Text + "',MarriedStatus='" + comboBox2.Text + "',Address='" + textBox11.Text + "',CHome='" + textBox12.Text + "',CMobile='" + textBox13.Text + "',Regdatetime='" + textBox14.Text + "',Weight='" + textBox20.Text + "',Height='" + textBox21.Text + "',BMI='" + textBox22.Text + "',Blood_Group='" + comboBox4.Text + "',Disease='" + comboBox5.Text + "',Discription='" + textBox23.Text + "' where PatientID='" + textBox01.Text + "'";
                        SqlCommand cmd = new SqlCommand(updateqry, o.con);
                        cmd.ExecuteNonQuery();
                        label16.ForeColor = Color.Green;
                        label16.Text = "Data Stored";
                    }


                    //MessageBox.Show("Saved Successfully !!");

                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox14.Clear();
                    comboBox3.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    textBox8.Clear();
                    textBox01.Clear();

                    textBox20.Text = "";
                    textBox21.Text = "";
                    textBox22.Text = "";
                    textBox23.Text = "";
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }
                catch (Exception x)
                {
                    label16.ForeColor = Color.Red;
                    label16.Text = x.Message;
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Datas !!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    var result = MessageBox.Show("Are You Sure Delete This Patinet ?", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string deleteqry = "DELETE FROM Patient_Reg where PatientID ='" + textBox01.Text + "'";
                        SqlCommand cmd = new SqlCommand(deleteqry, o.con);
                        cmd.ExecuteNonQuery();
                        label16.ForeColor = Color.Green;
                        label16.Text = "Data Deleted";
                    }

                   // string deleteqry = "DELETE FROM Patient_Reg where PatientID ='" + e + "'";
                   
                    //MessageBox.Show("Delete Successfully !!");
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox14.Clear();
                    comboBox3.Text = "-";
                    comboBox1.Text = "-";
                    comboBox2.Text = "-";
                    textBox8.Clear();
                    textBox01.Clear();

                    textBox20.Text = "";
                    textBox21.Text = "";
                    textBox22.Text = "";
                    textBox23.Text = "";
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                    
                }
                catch (Exception x)
                {
                    label16.ForeColor = Color.Red;
                    label16.Text = x.Message;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Patient ID !!");
            }
        }

        private void executeQuery(string deleteqry)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox20.Text != "" && textBox21.Text != "")
                try
                {
                    double weight = Convert.ToDouble(textBox20.Text);
                    double height = Convert.ToDouble(textBox21.Text);
                    double bmi = (weight / (height * height)) * 10000;
                    textBox22.Text = bmi.ToString("0.0");
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

        
        
    }
}
