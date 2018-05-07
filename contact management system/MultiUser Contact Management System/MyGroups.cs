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
    public partial class MyGroups : Form
    {
        public MyGroups()
        {
            InitializeComponent();
        }

        private void MyGroups_Load(object sender, EventArgs e)


        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool sgrp = false;
            bool rgrp = false;
            int tc = 0;
            Contacts.Service1 ser = new Contacts.Service1();
            ser.UpdateGroup(txtid.Text,txtGrp.Text, out sgrp, out rgrp);
            BindingSource bs = new BindingSource();
            bs.DataSource = ser.GetData();
            gvGrp.DataSource = bs;

            lblmsg.Text = "Successfully Updated ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {  
            bool addResult;
            bool addGrp;
            string _CurUserId = myUtill.loginUser.Userid;
            Contacts.Service1 ser = new Contacts.Service1();
            ser.AddGroup(txtGrp.Text,ref _CurUserId, out addResult, out addGrp);
            if (addResult == true) lblmsg.Text = "Group Added";
            else lblmsg.Text = "Adding Failed !";

           

            BindingSource bs = new BindingSource();
            bs.DataSource = ser.GetData();
            gvGrp.DataSource = bs;


        }

     
        private string GroupCreaterName(string grp_id)
        {
            string uname = "";
            foreach (myUser u in DataClass.usersArrayList)
            {
                if (u.Userid == grp_id)
                {
                    uname = u.Username;

                }
            }
            return uname;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bool delGrp;
            bool delGrpRes;
            Contacts.Service1 ser = new Contacts.Service1();
           
            ser.DeleteGroup(txtid.Text,out delGrp,out delGrpRes);

            BindingSource bs = new BindingSource();
            bs.DataSource = ser.GetData();
            gvGrp.DataSource = bs;

        }

        private void gvGrp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvGrp_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = gvGrp.CurrentCell.RowIndex;
            lblg.Text = currentRow.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
