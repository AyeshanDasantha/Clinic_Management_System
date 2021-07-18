using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;
using Excel = Microsoft.Office.Interop.Excel;
using DGVColumnSelector;

namespace Clinic_Management_System.form
{
    public partial class Filter_date : Form
    {
        public Filter_date()
        {
            InitializeComponent();
        }

        private void Filter_date_Load(object sender, EventArgs e)
        {
            DataGridViewColumnSelector cs = new DataGridViewColumnSelector(dataGridView1);
            cs.MaxHeight = 200;
            cs.Width = 110;
        }
        SqlConnection con = new SqlConnection("Data Source=Scorpian;Initial Catalog=CMS;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select *  from Patient_Reg where Regdatetime between '" + dateTimePicker1.Value.ToString() + "'and'" + dateTimePicker2.Value.ToString() + "' ", con);
            DataTable sd = new DataTable();
            sda.Fill(sd);
            dataGridView1.DataSource = sd;
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

     
    }
}
