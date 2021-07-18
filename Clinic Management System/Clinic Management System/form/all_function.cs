using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using DGVColumnSelector;

namespace Clinic_Management_System.form
{
    public partial class all_function : Form
    {
        public all_function()
        {
            InitializeComponent();
        }
        string str = @"Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommandBuilder builder;
        private void all_function_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            da = new SqlDataAdapter("SELECT * FROM Patient_Reg", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataGridViewColumnSelector cs = new DataGridViewColumnSelector(dataGridView1);
            cs.MaxHeight = 200;
            cs.Width = 110;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure Update Patinet Registry ?", "Update Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    builder = new SqlCommandBuilder(da);
                    da.Update(dt);
                    MessageBox.Show("Successfuly Updated ");
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Error : " + x.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Patient ID")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where PatientID like '" + textBox1.Text + "%'", con);
                      
 
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "First Name")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where FirstName like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Middle Name")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where MiddleName like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Last Name ")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where LastName like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "NIC")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where NIC like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Address")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Address like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Register Date & Time")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Regdatetime like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Saluation")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Saluation like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Age")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Age like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Gender")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Gender like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Gender")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Gender like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Married Status")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where MarriedStatus like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Contact No(Home)")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where CHome like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Contact No(Mobile)")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where CMobile like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Weight")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Weight like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Height")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Height like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "BMI")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where BMI like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Blood Group")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Blood_Group like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
              else if (comboBox1.Text == "Disease ")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Disease  like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
              else if (comboBox1.Text == "Discription")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,Saluation,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile,Regdatetime, Weight, Height, BMI, Blood_Group, Disease,Discription from Patient_Reg where Discription like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
           





           
        }

        private void copyAlltoClipboard()
        {
            //to remove the first blank column from datagridview
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 && dataGridView1.Rows != null)
            {
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[2, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                xlWorkSheet.Cells[1, 1] = "PatientID";
                xlWorkSheet.Cells[1, 2] = "Saluation";
                xlWorkSheet.Cells[1, 3] = "First Name";
                xlWorkSheet.Cells[1, 4] = "Middle Name";
                xlWorkSheet.Cells[1, 5] = "Last Name";
                xlWorkSheet.Cells[1, 6] = "NIC";
                xlWorkSheet.Cells[1, 7] = "Date Of Birth";
                xlWorkSheet.Cells[1, 8] = "Age";
                xlWorkSheet.Cells[1, 9] = "Gender";
                xlWorkSheet.Cells[1, 10] = "Married Status";
                xlWorkSheet.Cells[1, 11] = "Address";
                xlWorkSheet.Cells[1, 12] = "Contact No Home";
                xlWorkSheet.Cells[1, 13] = "Contact No Mobile";
                xlWorkSheet.Cells[1, 14] = "Registration Time";
                xlWorkSheet.Cells[1, 15] = "Weight";
                xlWorkSheet.Cells[1, 16] = "Height";
                xlWorkSheet.Cells[1, 17] = "BMI";
                xlWorkSheet.Cells[1, 18] = "Blood Group";
                xlWorkSheet.Cells[1, 19] = "Disease";
                xlWorkSheet.Cells[1, 20] = "Discription";
            }
            else
            {
                MessageBox.Show("Please Load Data !!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
       
        
    }
}
