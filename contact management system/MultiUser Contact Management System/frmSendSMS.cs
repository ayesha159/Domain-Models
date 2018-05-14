using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;

namespace MultiUser_Contact_Management_System
{
    public partial class frmSendSMS : Form
    {
        public frmSendSMS()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Contacts.Service1 sr2 = new Contacts.Service1();
            BindingSource b = new BindingSource();
            b.DataSource = sr2.SSTC(myUtill.loginUser.Userid, comboBox1.SelectedValue.ToString());
           
            foreach (DataGridViewRow gv in gvSMS.Rows)
            {
                string s = gv.Cells[3].Value.ToString();

                MessageBox.Show(s);
                {
                    RecPwdbySMS sm = new RecPwdbySMS();
                    sm.SetComPort("com4");
                    sm.Opens();
                    sm.RecoverPwdbySMS(s,textBox1.Text.Trim());
                    sm.Closes();
                }
                System.Threading.Thread.Sleep(10000);

            }

        }

        private void frmSendSMS_Load(object sender, EventArgs e)
        {
            Contacts.Service1 ser = new Contacts.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = ser.GetData();
            comboBox1.ValueMember = "grpId";
            comboBox1.DisplayMember = "grpName";
            comboBox1.DataSource = bs;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            
            Contacts.Service1 ser = new Contacts.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = ser.ShowContactsSMS(myUtill.loginUser.Userid, comboBox1.SelectedValue.ToString());
            gvSMS.DataSource = bs;

        }

        private void optContacts_CheckedChanged(object sender, EventArgs e)
        {
            if(optContacts.Enabled == true)
            {
                Contacts.Service1 ser = new Contacts.Service1();
                BindingSource bs = new BindingSource();
                bs.DataSource = ser.ShowAllContacts
                    (myUtill.loginUser.Userid, comboBox1.SelectedValue.ToString());
                gvSMS.DataSource = bs;

            }
        }
    }
}
