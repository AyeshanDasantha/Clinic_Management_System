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
    public partial class find_patient : Form
    {
        public find_patient()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void find_patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pID_search_box_dataset.Patient_Reg' table. You can move, or remove it, as needed.
            this.patient_RegTableAdapter.Fill(this.pID_search_box_dataset.Patient_Reg);
            
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
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
                    textBox2.Text = (dr["Saluation"].ToString());
                    textBox3.Text = (dr["FirstName"].ToString());
                    textBox4.Text = (dr["MiddleName"].ToString());
                    textBox5.Text = (dr["LastName"].ToString());
                    textBox6.Text = (dr["NIC"].ToString());
                    textBox7.Text = (dr["DOB"].ToString());
                    textBox8.Text = (dr["Age"].ToString());
                    textBox9.Text = (dr["Gender"].ToString());
                    textBox10.Text = (dr["MarriedStatus"].ToString());
                    textBox11.Text = (dr["Address"].ToString());
                    textBox12.Text = (dr["CHome"].ToString());
                    textBox13.Text = (dr["CMobile"].ToString());
                    textBox14.Text = (dr["Regdatetime"].ToString());

                    textBox15.Text = (dr["Weight"].ToString());
                    textBox16.Text = (dr["Height"].ToString());
                    textBox17.Text = (dr["BMI"].ToString());
                    textBox18.Text = (dr["Discription"].ToString());
                    textBox19.Text = (dr["Blood_Group"].ToString());
                    textBox20.Text = (dr["Disease"].ToString());


                }
                else
                {
                    textBox01.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox13.Text = "";

                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox16.Text = "";
                    textBox17.Text = "";
                    textBox18.Text = "";
                    textBox19.Text = "";
                    textBox20.Text = "";

                    MessageBox.Show("No Record Found Please Enter Correct Patient ID");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Patinet ID !!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bmp = Properties.Resources.Printer_Header;
            //Image newImage = bmp;
            //e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);

            //Header
            e.Graphics.DrawString("ABC Clinic  ", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(350, 10));
            //
            e.Graphics.DrawString("Address : No:123 ,abc Road,Abc,abc. ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(100, 50));
            e.Graphics.DrawString("Phone : 0639 999 999", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(100, 80));
            e.Graphics.DrawString("E-Mail :abc@abc.com", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(490, 50));
            e.Graphics.DrawString("Fax : 0639 999 999", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(490, 80));

            //Print DB
            
            e.Graphics.DrawString("Patient Personal Information  ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 120));

            e.Graphics.DrawString("PatientID  : "+textBox01.Text ,new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("Name  : " + textBox2.Text + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("NIC  : " + textBox6.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 260));
            e.Graphics.DrawString("Birthday  : " + textBox7.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString("Age  : " + textBox8.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 340));
            e.Graphics.DrawString("Gender  : " + textBox9.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 380));
            e.Graphics.DrawString("Married Status  : " + textBox10.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 420));
            e.Graphics.DrawString("Address  : " + textBox11.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 460));
            e.Graphics.DrawString("Contact No Home : " + textBox12.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 500));
            e.Graphics.DrawString("Contact No Mobile : " + textBox13.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 500));
            
            e.Graphics.DrawString("Decese Details  ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 550));

            e.Graphics.DrawString("Weight : " + textBox15.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 610));
            e.Graphics.DrawString("Height : " + textBox16.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 650));
            e.Graphics.DrawString("BMI : " + textBox17.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 690));
            e.Graphics.DrawString("Blood Group : " + textBox19.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 730));
            e.Graphics.DrawString("Diseases : " +  textBox20.Text  , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 770));
            e.Graphics.DrawString("Discription : " + textBox18.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 810));


            //footer
            e.Graphics.DrawString("This is Computer Genarate Report No Signature Required.   " + label16.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(170, 1080));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label16.Text = datetime.ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }


    }
}
