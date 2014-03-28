namespace BookStore
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btmExit = new System.Windows.Forms.Button();
            this.btmLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btmExit);
            this.groupBox1.Controls.Add(this.btmLogin);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // btmExit
            // 
            this.btmExit.Image = ((System.Drawing.Image)(resources.GetObject("btmExit.Image")));
            this.btmExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmExit.Location = new System.Drawing.Point(118, 107);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(75, 33);
            this.btmExit.TabIndex = 5;
            this.btmExit.Text = "&Exit";
            this.btmExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // btmLogin
            // 
            this.btmLogin.Image = ((System.Drawing.Image)(resources.GetObject("btmLogin.Image")));
            this.btmLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmLogin.Location = new System.Drawing.Point(9, 107);
            this.btmLogin.Name = "btmLogin";
            this.btmLogin.Size = new System.Drawing.Size(79, 33);
            this.btmLogin.TabIndex = 4;
            this.btmLogin.Text = "&Login";
            this.btmLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmLogin.UseVisualStyleBackColor = true;
            this.btmLogin.Click += new System.EventHandler(this.btmLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(77, 63);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(116, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(77, 19);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(116, 20);
            this.txtUname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 169);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmLogin;
        private System.Windows.Forms.Button btmExit;
    }
}