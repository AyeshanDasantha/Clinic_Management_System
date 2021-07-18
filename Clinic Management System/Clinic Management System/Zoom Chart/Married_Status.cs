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
    public partial class Married_Status : Form
    {
        public Married_Status()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowSettings settings = new WindowSettings();
            this.Close();
            settings.Close();
        }

        private void Married_Status_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'married_Status_DataSet.Report_MarriedStatus' table. You can move, or remove it, as needed.
            this.report_MarriedStatusTableAdapter.Fill(this.married_Status_DataSet.Report_MarriedStatus);
            chart1.Series["Series1"].XValueMember = "MarriedStatus";
            chart1.Series["Series1"].YValueMembers = "Total";
        }
    }
}
