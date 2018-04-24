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
            ser.IsUserRegister(txtUsr.Text, txtPwd.Text);
         
            if (txtUsr.Text.Length == 0)
            {
               txtUsr.Focus();
                return;
            }
           // int _lastUserid = 1;
            //   ser.RegisterUser(textBox1.Text, textBox2.Text);
            //{
            //    MessageBox.Show("user register");
            //}
            //   myUser u = new myUser();
            //foreach (myUser usr in DataClass.usersArrayList)
            //{
            //    _lastUserid = Convert.ToInt16(usr.Userid);
            //    //if (u.Username == txtusername.Text && u.Userpwd == txtpwd.Text)
            //    //{
            //    //    isFound = true;
            //    //    MyUtill.loginUser = u;
            //    //}
            //}
            //_lastUserid++;

            //u.Userid = _lastUserid.ToString();
            //u.Username = txtUsr.Text;
            //u.Userpwd = txtPwd.Text;

            ////foreach (string obj in DataClass.userName)
            ////{
            ////    MessageBox.Show(obj.ToString());
            ////} 
            //DataClass.usersArrayList.Add(u);

            txtUsr.Text = "";
            txtPwd .Text = "";
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
    }
}
