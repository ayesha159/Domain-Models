namespace MultiUser_Contact_Management_System
{
    partial class frmRcvrPwd
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
            this.RcvrPwd = new System.Windows.Forms.GroupBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.OPTSMS = new System.Windows.Forms.RadioButton();
            this.OPTEMAIL = new System.Windows.Forms.RadioButton();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RcvrPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // RcvrPwd
            // 
            this.RcvrPwd.Controls.Add(this.label1);
            this.RcvrPwd.Controls.Add(this.lblShow);
            this.RcvrPwd.Controls.Add(this.OPTSMS);
            this.RcvrPwd.Controls.Add(this.OPTEMAIL);
            this.RcvrPwd.Controls.Add(this.txtSMS);
            this.RcvrPwd.Controls.Add(this.txtEmail);
            this.RcvrPwd.Controls.Add(this.button1);
            this.RcvrPwd.Location = new System.Drawing.Point(42, 38);
            this.RcvrPwd.Name = "RcvrPwd";
            this.RcvrPwd.Size = new System.Drawing.Size(341, 173);
            this.RcvrPwd.TabIndex = 0;
            this.RcvrPwd.TabStop = false;
            this.RcvrPwd.Text = "Recover Password by";
            this.RcvrPwd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(53, 125);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(16, 13);
            this.lblShow.TabIndex = 6;
            this.lblShow.Text = "...";
            this.lblShow.Visible = false;
            // 
            // OPTSMS
            // 
            this.OPTSMS.AutoSize = true;
            this.OPTSMS.Location = new System.Drawing.Point(53, 62);
            this.OPTSMS.Name = "OPTSMS";
            this.OPTSMS.Size = new System.Drawing.Size(48, 17);
            this.OPTSMS.TabIndex = 3;
            this.OPTSMS.TabStop = true;
            this.OPTSMS.Text = "&SMS";
            this.OPTSMS.UseVisualStyleBackColor = true;
            this.OPTSMS.CheckedChanged += new System.EventHandler(this.OPTSMS_CheckedChanged);
            // 
            // OPTEMAIL
            // 
            this.OPTEMAIL.AutoSize = true;
            this.OPTEMAIL.Checked = true;
            this.OPTEMAIL.Location = new System.Drawing.Point(53, 33);
            this.OPTEMAIL.Name = "OPTEMAIL";
            this.OPTEMAIL.Size = new System.Drawing.Size(57, 17);
            this.OPTEMAIL.TabIndex = 1;
            this.OPTEMAIL.TabStop = true;
            this.OPTEMAIL.Text = "&EMAIL";
            this.OPTEMAIL.UseVisualStyleBackColor = true;
            this.OPTEMAIL.CheckedChanged += new System.EventHandler(this.OPTEMAIL_CheckedChanged);
            // 
            // txtSMS
            // 
            this.txtSMS.Enabled = false;
            this.txtSMS.Location = new System.Drawing.Point(144, 59);
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(177, 20);
            this.txtSMS.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Recover ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ex: +923001238833";
            // 
            // frmRcvrPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 253);
            this.Controls.Add(this.RcvrPwd);
            this.Name = "frmRcvrPwd";
            this.Text = "RecoverPwd";
            this.Load += new System.EventHandler(this.frmRcvrPwd_Load);
            this.RcvrPwd.ResumeLayout(false);
            this.RcvrPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RcvrPwd;
        private System.Windows.Forms.RadioButton OPTSMS;
        private System.Windows.Forms.RadioButton OPTEMAIL;
        private System.Windows.Forms.TextBox txtSMS;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label label1;
    }
}