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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            bool isvalidUser = false;
            bool isvalidPwd = false;
            Contacts.Service1 ser = new Contacts.Service1();

            ser.IsValidUser(txt_user.Text, txt_pwd.Text, out isvalidUser, out isvalidPwd);

            if (isvalidUser)
            {
                MessageBox.Show("valid user");
            }
            else
            {
                MessageBox.Show( "invalid user");
                
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecoverPWD fr = new frmRecoverPWD();
            fr.ShowDialog();
        }
    }
} 