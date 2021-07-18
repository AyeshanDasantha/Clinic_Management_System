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
    public partial class BloodGroup : Form
    {
        public BloodGroup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowSettings settings = new WindowSettings();
            this.Close();
            settings.Close();
        }

        private void BloodGroup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zoom_BloodGroup.Blood_Group_ChartReport' table. You can move, or remove it, as needed.
            this.blood_Group_ChartReportTableAdapter.Fill(this.zoom_BloodGroup.Blood_Group_ChartReport);
            chart1.Series["Series1"].XValueMember = "Disease";
            chart1.Series["Series1"].YValueMembers = "Total";
        }

    }
}
