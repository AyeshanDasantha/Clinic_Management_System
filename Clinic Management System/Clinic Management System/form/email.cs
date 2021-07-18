using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Clinic_Management_System.form
{
    public partial class email : Form
    {
        public email()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 465);
                MailMessage message = new MailMessage();
                message.From = new MailAddress(textBox1.Text);
                message.To.Add(textBox3.Text);
                message.Body = textBox6.Text;
                message.Subject = textBox5.Text;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;

                if (textBox4.Text != "")
                {
                    message.Attachments.Add(new Attachment(textBox4.Text));
                }
                client.Credentials = new System.Net.NetworkCredential(textBox1.Text, textBox2.Text);
                client.Send(message);
                message = null;

                MessageBox.Show("Successfully Send Email !!");
            }
            catch (Exception s)
            {
                MessageBox.Show("Failed To Send E-Mail !!");
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void email_Load(object sender, EventArgs e)
        {

        }
    
    }
}
