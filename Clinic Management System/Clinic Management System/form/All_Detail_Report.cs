using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_Management_System.form
{
    public partial class All_Detail_Report : Form
    {
        public All_Detail_Report()
        {
            InitializeComponent();
        }

        private void All_Detail_Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (CMSEntities db = new CMSEntities())
                {
                    Patient_RegBindingSource.DataSource = db.Patient_Reg.ToList();
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
