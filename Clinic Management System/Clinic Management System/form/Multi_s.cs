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
using DGVPrinterHelper;
using DGVColumnSelector;

namespace Clinic_Management_System.form
{
    public partial class Multi_s : Form
    {
        public Multi_s()
        {
            InitializeComponent();
        }

        private void Multi_s_Load(object sender, EventArgs e)
        {
            DataGridViewColumnSelector cs = new DataGridViewColumnSelector(dataGridView1);
            cs.MaxHeight = 200;
            cs.Width = 110;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Patient ID")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where PatientID like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "First Name")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where FirstName like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Middle Name")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where MiddleName like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Last Name ")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where LastName like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "NIC")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where NIC like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
           
            else if (comboBox1.Text == "Date Of Birth")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where DOB like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Age")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where Age like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Gender")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where Gender like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Address")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where Address like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Married Status")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where MarriedStatus like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Contact No (Home)")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where CHome like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
             else if (comboBox1.Text == "Contact No (Mobile)")
            {
                SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select PatientID,FirstName,MiddleName,LastName,NIC,DOB, Age, Gender, MarriedStatus, Address, CHome, CMobile from Patient_Reg where CMobile like '" + textBox1.Text + "%'", con);
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

        private void button1_Click(object sender, EventArgs e)
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
                xlWorkSheet.Cells[1, 1] = "Patient ID";
                xlWorkSheet.Cells[1, 2] = "First Name";
                xlWorkSheet.Cells[1, 3] = "Middle Name";
                xlWorkSheet.Cells[1, 4] = "Last Name";
                xlWorkSheet.Cells[1, 5] = "NIC";
                xlWorkSheet.Cells[1, 6] = "Date Of Birth";
                xlWorkSheet.Cells[1, 7] = "Age";
                xlWorkSheet.Cells[1, 8] = "Gender";
                xlWorkSheet.Cells[1, 9] = "Married Status";
                xlWorkSheet.Cells[1, 10] = "Address";
                xlWorkSheet.Cells[1, 11] = "Contact No(Home)";
                xlWorkSheet.Cells[1, 12] = "Contact No(Mobile)";

            }
            else
            {
                MessageBox.Show("Please Load Data !!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter Printer = new DGVPrinter();
            Printer.Title = "Patient Report";
            Printer.SubTitle = " ";
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = string.Format("Date : {0} ", DateTime.Now.Date);
            Printer.FooterSpacing = 15;
            Printer.PrintDataGridView(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewColumnSelector cs = new DataGridViewColumnSelector(dataGridView1);
            cs.MaxHeight = 200;
            cs.Width = 110;
        }

       
        
    }
}
