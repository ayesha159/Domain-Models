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
            string curUsris = "";

            ser.IsValidUser(txt_user.Text, txt_pwd.Text, ref curUsris, out isvalidUser, out isvalidPwd);

            if (isvalidUser)
            {
                lblMsg.Text = "valid user";

                myUser u = new myUser();
                u.Userid = curUsris;
                DataClass.usersCurrent.Add(u);
                foreach (myUser ux in DataClass.usersCurrent)
                {
                    myUtill.loginUser = ux;
                }

                MyPanel pnl = new MyPanel();
                pnl.ShowDialog();
            }
            else
            {
                MessageBox.Show( "invalid user");
                
            }


            //Boolean isFound = false;
            //foreach (myUser u in DataClass.usersArrayList)
            //{
            //    if (u.Username == txt_user.Text && u.Userpwd == txt_pwd.Text)
            //    {
            //        isFound = true;
            //        MyUtill.loginUser = u;

            //    }
            //}

            //if (isFound)
            //{

            //    lblMsg.Text = "valid user";


            //FrmContacts log = new FrmContacts();
            //this.Hide();
            //log.Show();



            //}
            //else
            //{
            //    lblMsg.Text = "invalid user";
            //}

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRcvrPwd fr = new frmRcvrPwd();
            fr.ShowDialog();
        }
    }
} 