﻿using System;
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
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
        }

   
        private void btnChange_Click(object sender, EventArgs e)
        {

            bool pwd = false;
            bool RePwd = false;
            Contacts.Service1 ser = new Contacts.Service1();
            ser.ChangePwd(myUtill.loginUser.Userid,txtOldPwd.Text,txtNewPwd.Text,txtRePwd.Text,out pwd, out RePwd);
            //string i = MyUtill.loginUser.Userid;
            //string i2 = MyUtill.loginUser.Userid.ToString();
            bool ret =  ChangePwd(myUtill.loginUser.Userid,txtOldPwd,txtNewPwd,txtRePwd);
            //MessageBox.Show(ret.ToString());
        }

        public bool ChangePwd(string _id,TextBox _pOld,TextBox pNew,TextBox pNewRe)
        {
            if (txtOldPwd.Text.Trim().Length == 0)
            { return false;}
            if (txtNewPwd.Text.Trim() != txtRePwd.Text.Trim())
            {
                return false;
            }


            return true;
        }
    }
}
