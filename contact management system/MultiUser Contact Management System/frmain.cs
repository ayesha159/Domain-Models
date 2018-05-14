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
    public partial class frmain : Form
    {
        public frmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin log = new frmlogin();

            log.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmregister reg = new frmregister();
            
            reg.ShowDialog(); 

        }

        private void frmain_Load(object sender, EventArgs e)
        {
            gvUsers.AutoGenerateColumns = false;
            Contacts.Service1 s = new Contacts.Service1();
            BindingSource b = new BindingSource();
            b.DataSource = s.GetUser();
            gvUsers.DataSource = b;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // here you can have column reference by using e.ColumnIndex
            

            

            // ... do something .
        }

        private void gvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show("You Have Selected " + (e.RowIndex + 1).ToString() + " Row Button");
                string s = (gvUsers.Rows[e.RowIndex].DataBoundItem).ToString();
                MessageBox.Show(s);


            }
        }
    }
}
