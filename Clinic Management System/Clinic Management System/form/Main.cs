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
    public partial class Main : Form
    {
        private string p;

        public Main()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        public Main(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        //private void Main_FormClosing(object sender, FormClosingEventArgs e)
        //{
            //DialogResult dialog = MessageBox.Show("Do u Really Want To Log Out The System ?", "LOG OUT", MessageBoxButtons.YesNo);
            //if (dialog == DialogResult.Yes)
            //{
             //   Application.Exit();
            //}
            //else
            //{
              //  e.Cancel = true;
            //}
        //}

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label1.Text = datetime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration p = new registration();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            find_patient p = new find_patient();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_delete p = new update_delete();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            all_function p = new all_function();
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            email p = new email();
            p.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Report_Chart p = new Report_Chart();
            p.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DBBackup p = new DBBackup();
            p.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do u Really Want To exit the Programme ?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void newPatientRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registration p = new registration();
            p.Show();
        }

        private void cheakOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            find_patient p = new find_patient();
            p.Show();
        }

        private void updatePatinetRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_delete p = new update_delete();
            p.Show();
        }

        private void advanceCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            all_function p = new all_function();
            p.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void patientPersonalRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Multi_s p = new Multi_s();
            p.Show();
        }

        private void filterByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter_date p = new Filter_date();
            p.Show();
        }

        private void filterByDatePersonalDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_Detail_Report p = new All_Detail_Report();
            p.Show();
        }

        private void sendEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            email p = new email();
            p.Show();
        }

        private void backUpAndRestoreDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBBackup p = new DBBackup();
            p.Show();
        }

        private void summaryReportChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Chart p = new Report_Chart();
            p.Show();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
                menuStrip1.Visible = !menuStrip1.Visible;
        }
      
    } 
}
