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
    public partial class Age : Form
    {
        public Age()
        {
            InitializeComponent();
        }

        private void Age_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ageBetween_DataSet.Report_ColumChart_SpaceAge' table. You can move, or remove it, as needed.
            this.report_ColumChart_SpaceAgeTableAdapter.Fill(this.ageBetween_DataSet.Report_ColumChart_SpaceAge);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowSettings settings = new WindowSettings();
            this.Close();
            settings.Close();
        }
    }
}
