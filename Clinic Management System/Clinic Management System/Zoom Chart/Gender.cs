using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_Management_System.Zoom_Chart
{
    public partial class Gender : Form
    {
        public Gender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowSettings settings = new WindowSettings();
            this.Close();
            settings.Close();
        }

        private void Gender_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gender_Chart_DataSet.Report_Chart' table. You can move, or remove it, as needed.
            this.report_ChartTableAdapter.Fill(this.gender_Chart_DataSet.Report_Chart);
            chart1.Series["Series1"].XValueMember = "Gender";
            chart1.Series["Series1"].YValueMembers = "Total";
        }
    }
}
