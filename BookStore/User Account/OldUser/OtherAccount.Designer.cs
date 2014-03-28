namespace BookStore.User_Account.OldUser
{
    partial class OtherAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgUserDetails = new System.Windows.Forms.DataGridView();
            this.clmSn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgUserDetails
            // 
            this.dgUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSn,
            this.clmID,
            this.clmName,
            this.clmUName,
            this.clmAccType,
            this.clmStatus});
            this.dgUserDetails.Location = new System.Drawing.Point(3, 3);
            this.dgUserDetails.Name = "dgUserDetails";
            this.dgUserDetails.Size = new System.Drawing.Size(493, 168);
            this.dgUserDetails.TabIndex = 0;
            this.dgUserDetails.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgUserDetails_RowHeaderMouseDoubleClick);
            // 
            // clmSn
            // 
            this.clmSn.HeaderText = "S.No.";
            this.clmSn.Name = "clmSn";
            this.clmSn.ReadOnly = true;
            this.clmSn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmSn.Width = 42;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmID.Width = 40;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmName.Width = 150;
            // 
            // clmUName
            // 
            this.clmUName.HeaderText = "User Name";
            this.clmUName.Name = "clmUName";
            this.clmUName.ReadOnly = true;
            this.clmUName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmAccType
            // 
            this.clmAccType.HeaderText = "Account Type";
            this.clmAccType.Name = "clmAccType";
            this.clmAccType.ReadOnly = true;
            this.clmAccType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmAccType.Width = 50;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmStatus.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cmbAccType);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 109);
            this.panel1.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(63, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 20);
            this.txtID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID :";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Suspended"});
            this.cmbStatus.Location = new System.Drawing.Point(343, 51);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbAccType
            // 
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbAccType.Location = new System.Drawing.Point(343, 27);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(121, 21);
            this.cmbAccType.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(63, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(142, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(343, 5);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(121, 20);
            this.txtUName.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(291, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // OtherAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgUserDetails);
            this.Name = "OtherAccount";
            this.Size = new System.Drawing.Size(515, 290);
            this.Load += new System.EventHandler(this.OtherAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.DataGridView dgUserDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
    }
}
