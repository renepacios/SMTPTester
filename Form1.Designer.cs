namespace SMTPTester
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.chkAnonymous = new System.Windows.Forms.CheckBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(70, 10);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(251, 20);
            this.txtServer.TabIndex = 0;
            // 
            // btnProbar
            // 
            this.btnProbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProbar.Location = new System.Drawing.Point(246, 212);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(75, 23);
            this.btnProbar.TabIndex = 8;
            this.btnProbar.Text = "Probar";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(70, 36);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(39, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // txtForm
            // 
            this.txtForm.Location = new System.Drawing.Point(70, 62);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(251, 20);
            this.txtForm.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "From";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(70, 89);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(251, 20);
            this.txtTo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(70, 190);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(160, 20);
            this.txtPass.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pass";
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(70, 163);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(160, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Login";
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(19, 115);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(68, 17);
            this.chkSSL.TabIndex = 4;
            this.chkSSL.Text = "Use SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // chkAnonymous
            // 
            this.chkAnonymous.AutoSize = true;
            this.chkAnonymous.Checked = true;
            this.chkAnonymous.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnonymous.Location = new System.Drawing.Point(19, 139);
            this.chkAnonymous.Name = "chkAnonymous";
            this.chkAnonymous.Size = new System.Drawing.Size(102, 17);
            this.chkAnonymous.TabIndex = 5;
            this.chkAnonymous.Text = "Use anonymous";
            this.chkAnonymous.UseVisualStyleBackColor = true;
            this.chkAnonymous.CheckedChanged += new System.EventHandler(this.chkAnonymous_CheckedChanged);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(9, 246);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(312, 132);
            this.txtLog.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 390);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.chkAnonymous);
            this.Controls.Add(this.chkSSL);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SMTP Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.CheckBox chkAnonymous;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label7;
    }
}

