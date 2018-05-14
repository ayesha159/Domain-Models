using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MultiUser_Contact_Management_System
{
    public partial class MyContact : Form
    {
        public MyContact()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool addConR;
            bool AddCons;
            Contacts.Service1 s = new Contacts.Service1();
            s.AddContact(myUtill.loginUser.Userid, cmbCon.SelectedValue.ToString(), txtName.Text, txtDOB.Text, txtMOB.Text, txtEMAIL.Text, txtADR.Text, out addConR, out AddCons);

            BindingSource b = new BindingSource();
            b.DataSource = s.GetCon();
            gvCon.DataSource = b;
            lblmsg.Text = "Successfully Added";
 
        }

        private void MyContact_Load(object sender, EventArgs e)
        {
            Contacts.Service1 ser = new Contacts.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = ser.GetData();
            cmbCon.ValueMember = "grpId";
            cmbCon.DisplayMember = "grpName";
            cmbCon.DataSource = bs;
        }
      

        private void gvCon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //myContacts cn = new myContacts();
            //txtName.Text = gvCon.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show("ldkfjdlk");
        }

        private void gvCon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           //int currentRow = gvCon.CurrentCell.RowIndex;
           // lbli.Text = currentRow.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bool updateCon;
            bool updateConR;
            
            Contacts.Service1 s = new Contacts.Service1();
            s.UpdateContacts(txtId.Text,txtName.Text,txtDOB.Text,
            txtMOB.Text,txtEMAIL.Text,txtADR.Text,out updateCon,out updateConR);

            BindingSource bs = new BindingSource();
            bs.DataSource = s.GetCon();
            gvCon.DataSource = bs;

            lblmsg.Text = "Successfully Updated ";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            bool DelCon;
            bool DelConR;
            Contacts.Service1 s = new Contacts.Service1();
            s.DeleteContact(txtId.Text, out DelCon, out DelConR);

            BindingSource bs = new BindingSource();
            bs.DataSource = s.GetCon();
            gvCon.DataSource = bs;

            lblmsg.Text = "Successfully Deleted";
        }

        private void cmbCon_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         


        }

        private void gvFormat()
        {
        }
        private void chksearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chksearch.Checked == true)
                panel1.Enabled = true;
            else
                panel1.Enabled  = false;
        }

        private void btnSDOB_Click(object sender, EventArgs e)
        {
          


        }

        private void btnSMob_Click(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
