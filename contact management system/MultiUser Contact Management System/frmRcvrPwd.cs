using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiUser_Contact_Management_System
{
    public partial class frmRcvrPwd : Form
    {
        public frmRcvrPwd()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OPTEMAIL_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            txtSMS.Enabled = false;
            txtSMS.Text = "";
            txtEmail.Focus();
        }

        private void OPTSMS_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
            txtEmail.Text = "";
            txtSMS.Enabled = true;
            txtSMS.Focus();

        }

        private void frmRcvrPwd_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Enabled == true)
            {
                Contacts.Service1 sr = new Contacts.Service1();
                lblShow.Text = sr.RecoverPwdE(txtEmail.Text);

                if (lblShow.Text != "invalid user or User no Registered with this email")
                {
                    SendEmailAdmin(txtEmail.Text, lblShow.Text);
                    MessageBox.Show("Password has been sent by Email.");
                }
            }
            else
            {
                Contacts.Service1 sr2 = new Contacts.Service1();
                lblShow.Text = sr2.RecoverPwdS(txtSMS.Text);

                if (txtSMS.Text.Trim().Length == 13)
                {
                    RecPwdbySMS sm = new RecPwdbySMS();
                    sm.SetComPort("com4");
                    sm.Opens();
                    sm.RecoverPwdbySMS(txtSMS.Text, lblShow.Text);
                    sm.Closes();
                    MessageBox.Show("Password has been sent by SMS.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Contacts.Service1 sr = new Contacts.Service1();
            lblShow.Text = sr.RecoverPwdE(txtEmail.Text);
            if (lblShow.Text != "invalid user or User no Registered with this email")
            {
                SendEmailAdmin(txtEmail.Text, lblShow.Text);
            }

          //  SendEmailAdmin(txtEmail.Text, "lblShow.Text");
        }
        public void SendEmailAdmin(string to, string recoveredPWD)

        {
            try
            {
                MailAddress From = new MailAddress("ayeshajabbar36@gmail.com", "Ayesha Jabbar PWD Recovery");
                MailAddress Tos = new MailAddress(to, "");
                MailMessage Message = new System.Net.Mail.MailMessage(From, Tos);
                Message.Subject = ("Password Recovery [Contact Manangement System]");
                Message.IsBodyHtml = false;
                string msg = string.Empty;
                Message.Body ="Your forgotton password is :-" +  recoveredPWD;
                object local_status = Message;
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Host = "smtp.gmail.com";
                                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("ayeshajabbar36@gmail.com", "mymomismylife123");
                client.Send(Message);

                MessageBox.Show("Sent Successfully");
            }
            catch (Exception ex)
            {
                string s = ex.Message.ToString();
                MessageBox.Show(s);
            }
        }

    }
}
