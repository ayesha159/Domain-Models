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
using Excel = Microsoft.Office.Interop.Excel;


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

        }

        private void gvCon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
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

            Contacts.Service1 ser = new Contacts.Service1();
            //ser.SearchContacts(myUtill.loginUser.Userid,cmbCon.SelectedValue.ToString(), txtName.Text);

            BindingSource b = new BindingSource();
            b.DataSource = ser.SearchCbyName(myUtill.loginUser.Userid, cmbCon.SelectedValue.ToString(), txtName.Text);
            gvCon.DataSource = b;



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

            Contacts.Service1 ser = new Contacts.Service1();
            BindingSource b = new BindingSource();
            b.DataSource = ser.SearchCbyDob(myUtill.loginUser.Userid, cmbCon.SelectedValue.ToString(), txtDOB.Text);
            gvCon.DataSource = b;


        }

        private void btnSMob_Click(object sender, EventArgs e)
        {
            Contacts.Service1 ser = new Contacts.Service1();
            BindingSource b = new BindingSource();
            b.DataSource = ser.SearchCbyMob(myUtill.loginUser.Userid, cmbCon.SelectedValue.ToString(), txtMOB.Text);
            gvCon.DataSource = b;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Contacts.Service1 ser = new Contacts.Service1();
            BindingSource b = new BindingSource();
            b.DataSource = ser.SearchCbyEmail(myUtill.loginUser.Userid, cmbCon.SelectedValue.ToString(), txtEMAIL.Text);
            gvCon.DataSource = b;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {


            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt;

            int rw = 0;
            int cl = 0;
            string filename = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
            }
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;
            string _name = "";
            string _mob = "";
            string _address = "";
            string _email = "";
            string _dob = "";


            for (rCnt = 1; rCnt <= rw; rCnt++)
            {
                //for (cCnt = 1; cCnt <= cl; )
                {

                    _name = Convert.ToString((range.Cells[rCnt, 1] as Excel.Range).Value2);
                    _mob = Convert.ToString((range.Cells[rCnt, 2] as Excel.Range).Value2);
                    _dob = Convert.ToString((range.Cells[rCnt, 3] as Excel.Range).Value2);
                    _email = Convert.ToString((range.Cells[rCnt, 4] as Excel.Range).Value2);
                    _address = Convert.ToString((range.Cells[rCnt, 5] as Excel.Range).Value2);
                    str = _name + ", " + _mob + ", " + _dob;
                    Contacts.Service1 ser = new Contacts.Service1();
                    string sv = ser.ImportContacts(_name, _dob, _mob, _email, _address, myUtill.loginUser.Userid, cmbCon.SelectedValue.ToString());

                    BindingSource b = new BindingSource();
                    b.DataSource = ser.GetCon();
                    gvCon.DataSource = b;

                }
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);



        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            Contacts.Service1 ser = new Contacts.Service1();

            BindingSource b = new BindingSource();
            b.DataSource = ser.GetCon();
            gvCon.DataSource = b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
