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
    public partial class TestForm : Form
    {
        private Button button1;

        public TestForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Name = "TestForm";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"d:\AJ-Contacts.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
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
                    //Contacts.Service1 ser = new Contacts.Service1();
                    //ser.ImportContacts(_name, _dob, _mob, _email, _email,);
                    //Add
                }
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

        }
    }
}
