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
    public partial class Disease : Form
    {
        public Disease()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Code to trigger when the "Yes"-button is pressed.
            WindowSettings settings = new WindowSettings();
            this.Close();
            settings.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Disease_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zoom_Disease.Disease_ChartReport' table. You can move, or remove it, as needed.
            this.disease_ChartReportTableAdapter.Fill(this.zoom_Disease.Disease_ChartReport);
            chart1.Series["Series1"].XValueMember = "Disease";
            chart1.Series["Series1"].YValueMembers = "Total";
        }
    }
}
