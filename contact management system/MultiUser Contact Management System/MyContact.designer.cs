namespace MultiUser_Contact_Management_System
{
    partial class MyContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCon = new System.Windows.Forms.ComboBox();
            this.gvCon = new System.Windows.Forms.DataGridView();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_Mob = new System.Windows.Forms.Label();
            this.lblAdr = new System.Windows.Forms.Label();
            this.lbll_email = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lbl_lst = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtMOB = new System.Windows.Forms.TextBox();
            this.txtADR = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chksearch = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSMob = new System.Windows.Forms.Button();
            this.btnSDOB = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvCon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCon
            // 
            this.cmbCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCon.FormattingEnabled = true;
            this.cmbCon.Location = new System.Drawing.Point(173, 27);
            this.cmbCon.Name = "cmbCon";
            this.cmbCon.Size = new System.Drawing.Size(268, 28);
            this.cmbCon.TabIndex = 0;
            this.cmbCon.SelectedIndexChanged += new System.EventHandler(this.cmbCon_SelectedIndexChanged);
            // 
            // gvCon
            // 
            this.gvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCon.Location = new System.Drawing.Point(12, 286);
            this.gvCon.Name = "gvCon";
            this.gvCon.Size = new System.Drawing.Size(689, 128);
            this.gvCon.TabIndex = 1;
            this.gvCon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCon_CellContentClick);
            this.gvCon.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCon_CellEnter);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(100, 65);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(56, 18);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name :";
            // 
            // lbl_Mob
            // 
            this.lbl_Mob.AutoSize = true;
            this.lbl_Mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob.Location = new System.Drawing.Point(84, 129);
            this.lbl_Mob.Name = "lbl_Mob";
            this.lbl_Mob.Size = new System.Drawing.Size(72, 18);
            this.lbl_Mob.TabIndex = 3;
            this.lbl_Mob.Text = "Mobile # :";
            // 
            // lblAdr
            // 
            this.lblAdr.AutoSize = true;
            this.lblAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdr.Location = new System.Drawing.Point(86, 163);
            this.lblAdr.Name = "lblAdr";
            this.lblAdr.Size = new System.Drawing.Size(70, 18);
            this.lblAdr.TabIndex = 4;
            this.lblAdr.Text = "Address :";
            // 
            // lbll_email
            // 
            this.lbll_email.AutoSize = true;
            this.lbll_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbll_email.Location = new System.Drawing.Point(98, 198);
            this.lbll_email.Name = "lbll_email";
            this.lbll_email.Size = new System.Drawing.Size(58, 18);
            this.lbll_email.TabIndex = 5;
            this.lbll_email.Text = "E-Mail :";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(99, 97);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(57, 18);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "D.O.B :";
            this.lblDOB.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_lst
            // 
            this.lbl_lst.AutoSize = true;
            this.lbl_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lst.Location = new System.Drawing.Point(12, 267);
            this.lbl_lst.Name = "lbl_lst";
            this.lbl_lst.Size = new System.Drawing.Size(96, 16);
            this.lbl_lst.TabIndex = 7;
            this.lbl_lst.Text = "Contacts List";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(173, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 26);
            this.txtName.TabIndex = 8;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(173, 93);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(268, 26);
            this.txtDOB.TabIndex = 9;
            // 
            // txtMOB
            // 
            this.txtMOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOB.Location = new System.Drawing.Point(173, 125);
            this.txtMOB.Name = "txtMOB";
            this.txtMOB.Size = new System.Drawing.Size(268, 26);
            this.txtMOB.TabIndex = 10;
            this.txtMOB.Text = "                                                                    ";
            // 
            // txtADR
            // 
            this.txtADR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADR.Location = new System.Drawing.Point(173, 159);
            this.txtADR.Name = "txtADR";
            this.txtADR.Size = new System.Drawing.Size(268, 26);
            this.txtADR.TabIndex = 11;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMAIL.Location = new System.Drawing.Point(173, 194);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(268, 26);
            this.txtEMAIL.TabIndex = 12;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(360, 226);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(81, 30);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(602, 462);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(81, 30);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(515, 462);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(81, 30);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(10, 462);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(54, 16);
            this.lblmsg.TabIndex = 20;
            this.lblmsg.Text = "lblmsg";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 25);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chksearch
            // 
            this.chksearch.AutoSize = true;
            this.chksearch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chksearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chksearch.Location = new System.Drawing.Point(460, 31);
            this.chksearch.Name = "chksearch";
            this.chksearch.Size = new System.Drawing.Size(60, 17);
            this.chksearch.TabIndex = 22;
            this.chksearch.Text = "Search";
            this.chksearch.UseVisualStyleBackColor = true;
            this.chksearch.CheckedChanged += new System.EventHandler(this.chksearch_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSMob);
            this.panel1.Controls.Add(this.btnSDOB);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(460, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 166);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 25);
            this.button2.TabIndex = 25;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSMob
            // 
            this.btnSMob.Location = new System.Drawing.Point(3, 75);
            this.btnSMob.Name = "btnSMob";
            this.btnSMob.Size = new System.Drawing.Size(57, 25);
            this.btnSMob.TabIndex = 23;
            this.btnSMob.Text = "Search";
            this.btnSMob.UseVisualStyleBackColor = true;
            this.btnSMob.Click += new System.EventHandler(this.btnSMob_Click);
            // 
            // btnSDOB
            // 
            this.btnSDOB.Location = new System.Drawing.Point(3, 39);
            this.btnSDOB.Name = "btnSDOB";
            this.btnSDOB.Size = new System.Drawing.Size(57, 25);
            this.btnSDOB.TabIndex = 22;
            this.btnSDOB.Text = "Search";
            this.btnSDOB.UseVisualStyleBackColor = true;
            this.btnSDOB.Click += new System.EventHandler(this.btnSDOB_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(173, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 30);
            this.button3.TabIndex = 24;
            this.button3.Text = "Import From Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Group :";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(428, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 30);
            this.button4.TabIndex = 26;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(460, 226);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(71, 30);
            this.btnClr.TabIndex = 26;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ForUpdateAndDeleteEnterContactId";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(280, 432);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 28;
            // 
            // MyContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chksearch);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtADR);
            this.Controls.Add(this.txtMOB);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl_lst);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lbll_email);
            this.Controls.Add(this.lblAdr);
            this.Controls.Add(this.lbl_Mob);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.gvCon);
            this.Controls.Add(this.cmbCon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTACTS PROFILES";
            this.Load += new System.EventHandler(this.MyContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCon;
        private System.Windows.Forms.DataGridView gvCon;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_Mob;
        private System.Windows.Forms.Label lblAdr;
        private System.Windows.Forms.Label lbll_email;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lbl_lst;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtMOB;
        private System.Windows.Forms.TextBox txtADR;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chksearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSMob;
        private System.Windows.Forms.Button btnSDOB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
    }
}