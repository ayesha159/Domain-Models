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
            populate();
            int _r = 0;
            foreach (DataGridViewRow gv in gvGrp.Rows)
            {
                _r++;
                string s = gv.Cells[2].Value.ToString();
                Contacts.Service1 se = new Contacts.Service1();
                string g = se.grpCreator(s);
                //gv.Cells[2].Value = g;
                if (_r < gvGrp.Rows.Count - 1)
                {
                    //gvGrp.Rows[_r].Cells[2].Value = g;
                }
            }

        }

        private void populate()
        {
            Contacts.Service1 ser = new Contacts.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = ser.GetData(myUtill.loginUser.Userid);
            gvGrp.DataSource = bs;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gvGrp.AutoGenerateColumns = false;
            txtId.Enabled = true;
            bool sgrp = false;
            bool rgrp = false;
            Contacts.Service1 ser = new Contacts.Service1();
            string grp = ser.grpCreator(myUtill.loginUser.Userid);
            ser.UpdateGroup(txtId.Text,txtGrp.Text,grp, out sgrp, out rgrp);

            BindingSource bs = new BindingSource();
            bs.DataSource = ser.GetData(myUtill.loginUser.Userid);
            gvGrp.DataSource = bs;
            lblmsg.Text = "Successfully Updated ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gvGrp.AutoGenerateColumns = false;
            bool addResult;
            bool addGrp;
            string _CurUserId = myUtill.loginUser.Userid;
            Contacts.Service1 ser = new Contacts.Service1();
            string grp = ser.grpCreator(myUtill.loginUser.Userid);
            ser.AddGroup(txtGrp.Text,ref _CurUserId,grp, out addResult, out addGrp);
            if (addResult == true) lblmsg.Text = "Group Added";
            else lblmsg.Text = "Adding Failed !";
            BindingSource bs = new BindingSource();
            bs.DataSource = ser.GetData(myUtill.loginUser.Userid);
            gvGrp.DataSource = bs;


            //populate();
            int _r = 0;
            foreach (DataGridViewRow gv in gvGrp.Rows)
            {
                _r++;
                string s = gv.Cells[2].Value.ToString();
                Contacts.Service1 se = new Contacts.Service1();
                string g = se.grpCreator(s);
                gv.Cells[2].Value = g;

                try { gvGrp.Rows[_r].Cells[2].Value = g; } catch (Exception ex) { }
                
                
                

            }

        }
            private void btnDel_Click(object sender, EventArgs e)
            {
            gvGrp.AutoGenerateColumns = false;
            txtId.Enabled = true;
            bool delGrp;
            bool delGrpRes;
            Contacts.Service1 ser = new Contacts.Service1();
           
            ser.DeleteGroup(txtId.Text,out delGrp,out delGrpRes);

            BindingSource bs = new BindingSource();
            bs.DataSource = ser.GetData(myUtill.loginUser.Userid);
            gvGrp.DataSource = bs;
            lblmsg.Text = "deleted successfully";
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

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
