namespace MultiUser_Contact_Management_System
{
    partial class MyPanel
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
            this.btn_grp = new System.Windows.Forms.Button();
            this.btn_con = new System.Windows.Forms.Button();
            this.btn_pwd = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSendSMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_grp
            // 
            this.btn_grp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grp.Location = new System.Drawing.Point(230, 83);
            this.btn_grp.Name = "btn_grp";
            this.btn_grp.Size = new System.Drawing.Size(243, 55);
            this.btn_grp.TabIndex = 0;
            this.btn_grp.Text = "Groups Profiles";
            this.btn_grp.UseVisualStyleBackColor = true;
            this.btn_grp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_con
            // 
            this.btn_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_con.Location = new System.Drawing.Point(230, 144);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(243, 55);
            this.btn_con.TabIndex = 1;
            this.btn_con.Text = "Contacts Profiles";
            this.btn_con.UseVisualStyleBackColor = true;
            this.btn_con.Click += new System.EventHandler(this.btn_con_Click);
            // 
            // btn_pwd
            // 
            this.btn_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pwd.Location = new System.Drawing.Point(230, 267);
            this.btn_pwd.Name = "btn_pwd";
            this.btn_pwd.Size = new System.Drawing.Size(243, 59);
            this.btn_pwd.TabIndex = 2;
            this.btn_pwd.Text = "Change Password";
            this.btn_pwd.UseVisualStyleBackColor = true;
            this.btn_pwd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(230, 332);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(243, 56);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "lblId";
            this.lblId.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 44);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(39, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "lblUser";
            this.lblUser.Visible = false;
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendSMS.Location = new System.Drawing.Point(230, 205);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(243, 56);
            this.btnSendSMS.TabIndex = 6;
            this.btnSendSMS.Text = "Send SMS / Broadcast";
            this.btnSendSMS.UseVisualStyleBackColor = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // MyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 473);
            this.Controls.Add(this.btnSendSMS);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_pwd);
            this.Controls.Add(this.btn_con);
            this.Controls.Add(this.btn_grp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MY PANEL - CONTACTS MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.MyPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_grp;
        private System.Windows.Forms.Button btn_con;
        private System.Windows.Forms.Button btn_pwd;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSendSMS;
    }
}