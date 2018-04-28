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
    public partial class frmregister : Form
    {
        public frmregister()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Contacts.Service1 ser = new Contacts.Service1();
            ser.IsUserRegister(txtUsr.Text, txtPwd.Text, txtEm.Text,txtCell.Text);
         
            if (txtUsr.Text.Length == 0)
            {
               txtUsr.Focus();
                return;
            }


            txtUsr.Text = "";
            txtPwd .Text = "";
            txtEm.Text = "";
            txtCell.Text = "";
            MessageBox.Show("User has been register");

            txtUsr.Focus();
            
        }

        private void txtEm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCell_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmregister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
