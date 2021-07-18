using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMSGender.Patient_Reg' table. You can move, or remove it, as needed.
            this.patient_RegTableAdapter.Fill(this.cMSGender.Patient_Reg);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }

       
}
