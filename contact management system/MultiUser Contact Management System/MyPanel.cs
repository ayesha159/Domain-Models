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
    public partial class MyPanel : Form
    {
        public MyPanel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmChangePwd fr = new frmChangePwd();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyGroups grp = new MyGroups();

            grp.ShowDialog();
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            MyContact con = new MyContact();
    
            con.ShowDialog(); 
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyPanel_Load(object sender, EventArgs e)
        {
   
        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {
            frmSendSMS fr = new frmSendSMS();
            fr.ShowDialog();
        }
    }
}
