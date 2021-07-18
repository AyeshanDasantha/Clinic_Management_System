using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinic_Management_System.Zoom_Chart;

namespace Clinic_Management_System.form
{
    public partial class Report_Chart : Form
    {
        public Report_Chart()
        {
            InitializeComponent();
        }

        private void Report_Chart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boold_DataSet.Blood_Group_ChartReport' table. You can move, or remove it, as needed.
            this.blood_Group_ChartReportTableAdapter.Fill(this.boold_DataSet.Blood_Group_ChartReport);
            // TODO: This line of code loads data into the 'diseaseC_DataSet.Disease_ChartReport' table. You can move, or remove it, as needed.
            this.disease_ChartReportTableAdapter.Fill(this.diseaseC_DataSet.Disease_ChartReport);

            // TODO: This line of code loads data into the 'ageBetween_DataSet.Report_ColumChart_SpaceAge' table. You can move, or remove it, as needed.
            this.report_ColumChart_SpaceAgeTableAdapter.Fill(this.ageBetween_DataSet.Report_ColumChart_SpaceAge);
            // TODO: This line of code loads data into the 'married_Status_DataSet.Report_MarriedStatus' table. You can move, or remove it, as needed.
            this.report_MarriedStatusTableAdapter.Fill(this.married_Status_DataSet.Report_MarriedStatus);
            // TODO: This line of code loads data into the 'gender_Chart_DataSet.Report_Chart' table. You can move, or remove it, as needed.
            this.report_ChartTableAdapter.Fill(this.gender_Chart_DataSet.Report_Chart);
            ;
            // TODO: This line of code loads data into the 'gender_Chart_DataSet.Report_Chart' table. You can move, or remove it, as needed.
            this.report_ChartTableAdapter.Fill(this.gender_Chart_DataSet.Report_Chart);


            chart1.Series["Series1"].XValueMember = "Gender";
            chart1.Series["Series1"].YValueMembers = "Total";

            chart2.Series["Series1"].XValueMember = "MarriedStatus";
            chart2.Series["Series1"].YValueMembers = "Total";

            chart4.Series["Series1"].XValueMember = "Disease";
            chart4.Series["Series1"].YValueMembers = "Total";

            chart5.Series["Series1"].XValueMember = "Disease";
            chart5.Series["Series1"].YValueMembers = "Total";

        }

        private void chart4_Click(object sender, EventArgs e)
        {
            Disease p = new Disease();
            p.Show();
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Gender p = new Gender();
            p.Show();
            
        }

        private void chart5_Click(object sender, EventArgs e)
        {
            BloodGroup p = new BloodGroup();
            p.Show();
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            Married_Status p = new Married_Status();
            p.Show();
        }

        private void chart3_Click(object sender, EventArgs e)
        {
            Age p = new Age();
            p.Show();
        }
    }

       
}
