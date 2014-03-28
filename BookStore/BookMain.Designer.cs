
using System.Windows.Forms;
namespace BookStore
{
    partial class BookMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer4 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblShowName = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblBillTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.GroupBox();
            this.dgBill = new System.Windows.Forms.DataGridView();
            this.bclmSn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bclmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bclmRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bclmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkBuy = new System.Windows.Forms.CheckBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblPublication = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.txtShell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAID = new System.Windows.Forms.TextBox();
            this.txtAPRice = new System.Windows.Forms.TextBox();
            this.txtAAuthor2 = new System.Windows.Forms.TextBox();
            this.txtAAuthor1 = new System.Windows.Forms.TextBox();
            this.txtAEdition = new System.Windows.Forms.TextBox();
            this.txtAPublication = new System.Windows.Forms.TextBox();
            this.txtABookName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.txtSPrice = new System.Windows.Forms.TextBox();
            this.txtSAuthor2 = new System.Windows.Forms.TextBox();
            this.txtSAuthor1 = new System.Windows.Forms.TextBox();
            this.txtSEdition = new System.Windows.Forms.TextBox();
            this.txtSPublication = new System.Windows.Forms.TextBox();
            this.txtSBookName = new System.Windows.Forms.TextBox();
            this.dgBookInfo = new System.Windows.Forms.DataGridView();
            this.clmSn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookPubl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAuthor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAuthor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOldUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMyAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOtherAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nepaliUnicodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allBookInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDataSet = new BookStore.BookDataSet();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolStripContainer2.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            this.toolStripContainer4.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer4.ContentPanel.SuspendLayout();
            this.toolStripContainer4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Bill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookInfo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.AutoScroll = true;
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(864, 648);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(864, 673);
            this.toolStripContainer2.TabIndex = 1;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer3
            // 
            this.toolStripContainer3.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.AutoScroll = true;
            this.toolStripContainer3.ContentPanel.Controls.Add(this.toolStripContainer4);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.toolStripContainer2);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(864, 673);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.LeftToolStripPanelVisible = false;
            this.toolStripContainer3.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.RightToolStripPanelVisible = false;
            this.toolStripContainer3.Size = new System.Drawing.Size(864, 673);
            this.toolStripContainer3.TabIndex = 2;
            this.toolStripContainer3.Text = "toolStripContainer3";
            this.toolStripContainer3.TopToolStripPanelVisible = false;
            // 
            // toolStripContainer4
            // 
            // 
            // toolStripContainer4.BottomToolStripPanel
            // 
            this.toolStripContainer4.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer4.ContentPanel
            // 
            this.toolStripContainer4.ContentPanel.Controls.Add(this.groupBox4);
            this.toolStripContainer4.ContentPanel.Controls.Add(this.btnDelete);
            this.toolStripContainer4.ContentPanel.Controls.Add(this.Bill);
            this.toolStripContainer4.ContentPanel.Controls.Add(this.groupBox3);
            this.toolStripContainer4.ContentPanel.Controls.Add(this.groupBox2);
            this.toolStripContainer4.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer4.ContentPanel.Controls.Add(this.dgBookInfo);
            this.toolStripContainer4.ContentPanel.Controls.Add(this.pnlMenu);
            this.toolStripContainer4.ContentPanel.Size = new System.Drawing.Size(864, 651);
            this.toolStripContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer4.LeftToolStripPanelVisible = false;
            this.toolStripContainer4.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer4.Name = "toolStripContainer4";
            this.toolStripContainer4.RightToolStripPanelVisible = false;
            this.toolStripContainer4.Size = new System.Drawing.Size(864, 673);
            this.toolStripContainer4.TabIndex = 3;
            this.toolStripContainer4.Text = "toolStripContainer4";
            this.toolStripContainer4.TopToolStripPanelVisible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblShowName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblShowName
            // 
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(65, 17);
            this.lblShowName.Text = "User Name";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.btnSubmit);
            this.groupBox4.Controls.Add(this.lblBillTotal);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(12, 531);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 114);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bill Report";
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatAppearance.BorderSize = 3;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Green;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.Location = new System.Drawing.Point(131, 67);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 41);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblBillTotal.Location = new System.Drawing.Point(95, 16);
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Size = new System.Drawing.Size(244, 48);
            this.lblBillTotal.TabIndex = 14;
            this.lblBillTotal.Text = "0";
            this.lblBillTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.BlueViolet;
            this.label10.Location = new System.Drawing.Point(2, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total :- ";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(806, 301);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Bill
            // 
            this.Bill.Controls.Add(this.dgBill);
            this.Bill.Location = new System.Drawing.Point(374, 337);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(480, 277);
            this.Bill.TabIndex = 7;
            this.Bill.TabStop = false;
            this.Bill.Text = "Bill View";
            // 
            // dgBill
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bclmSn,
            this.bclmItem,
            this.bclmRate,
            this.clmQuentity,
            this.bclmTotal,
            this.clmDiscount,
            this.clmGTotal,
            this.clmRemark});
            this.dgBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBill.Location = new System.Drawing.Point(3, 16);
            this.dgBill.Name = "dgBill";
            this.dgBill.Size = new System.Drawing.Size(474, 258);
            this.dgBill.TabIndex = 1;
            // 
            // bclmSn
            // 
            this.bclmSn.HeaderText = "S.N.";
            this.bclmSn.Name = "bclmSn";
            this.bclmSn.ReadOnly = true;
            this.bclmSn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bclmSn.Width = 30;
            // 
            // bclmItem
            // 
            this.bclmItem.HeaderText = "Item";
            this.bclmItem.Name = "bclmItem";
            this.bclmItem.ReadOnly = true;
            this.bclmItem.Width = 120;
            // 
            // bclmRate
            // 
            this.bclmRate.HeaderText = "Rate";
            this.bclmRate.Name = "bclmRate";
            this.bclmRate.ReadOnly = true;
            this.bclmRate.Width = 40;
            // 
            // clmQuentity
            // 
            this.clmQuentity.HeaderText = "Quentity";
            this.clmQuentity.Name = "clmQuentity";
            this.clmQuentity.ReadOnly = true;
            this.clmQuentity.Width = 50;
            // 
            // bclmTotal
            // 
            this.bclmTotal.HeaderText = "Total";
            this.bclmTotal.Name = "bclmTotal";
            this.bclmTotal.ReadOnly = true;
            this.bclmTotal.Width = 50;
            // 
            // clmDiscount
            // 
            this.clmDiscount.HeaderText = "Discount";
            this.clmDiscount.Name = "clmDiscount";
            this.clmDiscount.Width = 50;
            // 
            // clmGTotal
            // 
            this.clmGTotal.HeaderText = "Grand Total";
            this.clmGTotal.Name = "clmGTotal";
            this.clmGTotal.ReadOnly = true;
            this.clmGTotal.Width = 50;
            // 
            // clmRemark
            // 
            this.clmRemark.HeaderText = "Remark";
            this.clmRemark.Name = "clmRemark";
            this.clmRemark.ReadOnly = true;
            this.clmRemark.Width = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.splitContainer1);
            this.groupBox3.Location = new System.Drawing.Point(12, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 195);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transition";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkBuy);
            this.splitContainer1.Panel1.Controls.Add(this.lblId);
            this.splitContainer1.Panel1.Controls.Add(this.lblPrice);
            this.splitContainer1.Panel1.Controls.Add(this.lblAuthors);
            this.splitContainer1.Panel1.Controls.Add(this.lblEdition);
            this.splitContainer1.Panel1.Controls.Add(this.lblPublication);
            this.splitContainer1.Panel1.Controls.Add(this.lblBookName);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblGrandTotal);
            this.splitContainer1.Panel2.Controls.Add(this.txtDiscount);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddBill);
            this.splitContainer1.Panel2.Controls.Add(this.txtShell);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(347, 176);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkBuy
            // 
            this.chkBuy.AutoSize = true;
            this.chkBuy.Location = new System.Drawing.Point(209, 90);
            this.chkBuy.Name = "chkBuy";
            this.chkBuy.Size = new System.Drawing.Size(44, 17);
            this.chkBuy.TabIndex = 11;
            this.chkBuy.Text = "Buy";
            this.chkBuy.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 118);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(92, 122);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(167, 45);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAuthors
            // 
            this.lblAuthors.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAuthors.Location = new System.Drawing.Point(101, 70);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(158, 13);
            this.lblAuthors.TabIndex = 8;
            this.lblAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEdition
            // 
            this.lblEdition.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEdition.Location = new System.Drawing.Point(101, 50);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(158, 13);
            this.lblEdition.TabIndex = 7;
            this.lblEdition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPublication
            // 
            this.lblPublication.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPublication.Location = new System.Drawing.Point(101, 32);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(158, 13);
            this.lblPublication.TabIndex = 6;
            this.lblPublication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookName
            // 
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblBookName.Location = new System.Drawing.Point(101, 13);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(158, 16);
            this.lblBookName.TabIndex = 5;
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Authors:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edition:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Publication:-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:-";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(7, 122);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(65, 20);
            this.lblGrandTotal.TabIndex = 13;
            this.lblGrandTotal.Text = "0";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiscount
            // 
            this.txtDiscount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDiscount.Location = new System.Drawing.Point(8, 88);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(60, 20);
            this.txtDiscount.TabIndex = 12;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(7, 52);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(8, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Grand Total";
            // 
            // btnAddBill
            // 
            this.btnAddBill.Location = new System.Drawing.Point(9, 145);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(69, 23);
            this.btnAddBill.TabIndex = 6;
            this.btnAddBill.Text = "Add to Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // txtShell
            // 
            this.txtShell.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtShell.Location = new System.Drawing.Point(7, 18);
            this.txtShell.Name = "txtShell";
            this.txtShell.Size = new System.Drawing.Size(63, 20);
            this.txtShell.TabIndex = 4;
            this.txtShell.Text = "0";
            this.txtShell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtShell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShell_KeyPress);
            this.txtShell.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtShell_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "No. of Piece";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtAID);
            this.groupBox2.Controls.Add(this.txtAPRice);
            this.groupBox2.Controls.Add(this.txtAAuthor2);
            this.groupBox2.Controls.Add(this.txtAAuthor1);
            this.groupBox2.Controls.Add(this.txtAEdition);
            this.groupBox2.Controls.Add(this.txtAPublication);
            this.groupBox2.Controls.Add(this.txtABookName);
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 44);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add / Update";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(6, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAID
            // 
            this.txtAID.Location = new System.Drawing.Point(82, 18);
            this.txtAID.Name = "txtAID";
            this.txtAID.ReadOnly = true;
            this.txtAID.Size = new System.Drawing.Size(58, 20);
            this.txtAID.TabIndex = 6;
            this.txtAID.TextChanged += new System.EventHandler(this.txtAID_TextChanged);
            this.txtAID.DoubleClick += new System.EventHandler(this.txtAID_DoubleClick);
            // 
            // txtAPRice
            // 
            this.txtAPRice.Location = new System.Drawing.Point(718, 17);
            this.txtAPRice.Name = "txtAPRice";
            this.txtAPRice.Size = new System.Drawing.Size(65, 20);
            this.txtAPRice.TabIndex = 5;
            this.txtAPRice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPRice_KeyPress);
            // 
            // txtAAuthor2
            // 
            this.txtAAuthor2.Location = new System.Drawing.Point(622, 17);
            this.txtAAuthor2.Name = "txtAAuthor2";
            this.txtAAuthor2.Size = new System.Drawing.Size(90, 20);
            this.txtAAuthor2.TabIndex = 4;
            // 
            // txtAAuthor1
            // 
            this.txtAAuthor1.Location = new System.Drawing.Point(517, 17);
            this.txtAAuthor1.Name = "txtAAuthor1";
            this.txtAAuthor1.Size = new System.Drawing.Size(99, 20);
            this.txtAAuthor1.TabIndex = 3;
            // 
            // txtAEdition
            // 
            this.txtAEdition.Location = new System.Drawing.Point(445, 17);
            this.txtAEdition.Name = "txtAEdition";
            this.txtAEdition.Size = new System.Drawing.Size(66, 20);
            this.txtAEdition.TabIndex = 2;
            // 
            // txtAPublication
            // 
            this.txtAPublication.Location = new System.Drawing.Point(311, 17);
            this.txtAPublication.Name = "txtAPublication";
            this.txtAPublication.Size = new System.Drawing.Size(128, 20);
            this.txtAPublication.TabIndex = 1;
            // 
            // txtABookName
            // 
            this.txtABookName.Location = new System.Drawing.Point(145, 18);
            this.txtABookName.Name = "txtABookName";
            this.txtABookName.Size = new System.Drawing.Size(160, 20);
            this.txtABookName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSID);
            this.groupBox1.Controls.Add(this.txtSPrice);
            this.groupBox1.Controls.Add(this.txtSAuthor2);
            this.groupBox1.Controls.Add(this.txtSAuthor1);
            this.groupBox1.Controls.Add(this.txtSEdition);
            this.groupBox1.Controls.Add(this.txtSPublication);
            this.groupBox1.Controls.Add(this.txtSBookName);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(82, 18);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(58, 20);
            this.txtSID.TabIndex = 6;
            this.txtSID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSID_KeyUp);
            // 
            // txtSPrice
            // 
            this.txtSPrice.Location = new System.Drawing.Point(718, 17);
            this.txtSPrice.Name = "txtSPrice";
            this.txtSPrice.Size = new System.Drawing.Size(65, 20);
            this.txtSPrice.TabIndex = 5;
            this.txtSPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSPrice_KeyUp);
            // 
            // txtSAuthor2
            // 
            this.txtSAuthor2.Location = new System.Drawing.Point(622, 17);
            this.txtSAuthor2.Name = "txtSAuthor2";
            this.txtSAuthor2.Size = new System.Drawing.Size(90, 20);
            this.txtSAuthor2.TabIndex = 4;
            this.txtSAuthor2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSAuthor2_KeyUp);
            // 
            // txtSAuthor1
            // 
            this.txtSAuthor1.Location = new System.Drawing.Point(517, 17);
            this.txtSAuthor1.Name = "txtSAuthor1";
            this.txtSAuthor1.Size = new System.Drawing.Size(99, 20);
            this.txtSAuthor1.TabIndex = 3;
            this.txtSAuthor1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSAuthor1_KeyUp);
            // 
            // txtSEdition
            // 
            this.txtSEdition.Location = new System.Drawing.Point(445, 17);
            this.txtSEdition.Name = "txtSEdition";
            this.txtSEdition.Size = new System.Drawing.Size(66, 20);
            this.txtSEdition.TabIndex = 2;
            this.txtSEdition.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSEdition_KeyUp);
            // 
            // txtSPublication
            // 
            this.txtSPublication.Location = new System.Drawing.Point(311, 17);
            this.txtSPublication.Name = "txtSPublication";
            this.txtSPublication.Size = new System.Drawing.Size(128, 20);
            this.txtSPublication.TabIndex = 1;
            this.txtSPublication.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSPublication_KeyUp);
            // 
            // txtSBookName
            // 
            this.txtSBookName.Location = new System.Drawing.Point(145, 18);
            this.txtSBookName.Name = "txtSBookName";
            this.txtSBookName.Size = new System.Drawing.Size(160, 20);
            this.txtSBookName.TabIndex = 0;
            this.txtSBookName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSBookName_KeyUp);
            // 
            // dgBookInfo
            // 
            this.dgBookInfo.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgBookInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgBookInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgBookInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSn,
            this.clmID,
            this.clmBName,
            this.clmBookPubl,
            this.clmEdition,
            this.clmAuthor1,
            this.clmAuthor2,
            this.clmPrice,
            this.clmStock});
            this.dgBookInfo.GridColor = System.Drawing.Color.Khaki;
            this.dgBookInfo.Location = new System.Drawing.Point(15, 81);
            this.dgBookInfo.Name = "dgBookInfo";
            this.dgBookInfo.Size = new System.Drawing.Size(842, 200);
            this.dgBookInfo.TabIndex = 2;
            this.dgBookInfo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBookInfo_RowHeaderMouseClick);
            this.dgBookInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBookInfo_RowHeaderMouseDoubleClick);
            // 
            // clmSn
            // 
            this.clmSn.FillWeight = 40F;
            this.clmSn.HeaderText = "S.No.";
            this.clmSn.Name = "clmSn";
            this.clmSn.ReadOnly = true;
            this.clmSn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmSn.Width = 40;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmID.Width = 60;
            // 
            // clmBName
            // 
            this.clmBName.FillWeight = 200F;
            this.clmBName.HeaderText = "Book Name";
            this.clmBName.Name = "clmBName";
            this.clmBName.ReadOnly = true;
            this.clmBName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmBName.Width = 170;
            // 
            // clmBookPubl
            // 
            this.clmBookPubl.FillWeight = 175F;
            this.clmBookPubl.HeaderText = "Publication";
            this.clmBookPubl.Name = "clmBookPubl";
            this.clmBookPubl.ReadOnly = true;
            this.clmBookPubl.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmBookPubl.Width = 130;
            // 
            // clmEdition
            // 
            this.clmEdition.HeaderText = "Edition";
            this.clmEdition.Name = "clmEdition";
            this.clmEdition.ReadOnly = true;
            this.clmEdition.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmEdition.Width = 75;
            // 
            // clmAuthor1
            // 
            this.clmAuthor1.FillWeight = 130F;
            this.clmAuthor1.HeaderText = "Author1";
            this.clmAuthor1.Name = "clmAuthor1";
            this.clmAuthor1.ReadOnly = true;
            this.clmAuthor1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmAuthor2
            // 
            this.clmAuthor2.FillWeight = 130F;
            this.clmAuthor2.HeaderText = "Author2";
            this.clmAuthor2.Name = "clmAuthor2";
            this.clmAuthor2.ReadOnly = true;
            this.clmAuthor2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPrice.Width = 70;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStock.Width = 50;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.menuStrip1);
            this.pnlMenu.Location = new System.Drawing.Point(3, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(843, 22);
            this.pnlMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuAccount,
            this.settingToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuLogout});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(122, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Image = ((System.Drawing.Image)(resources.GetObject("mnuLogout.Image")));
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(122, 22);
            this.mnuLogout.Text = "&Logout";
            this.mnuLogout.Visible = false;
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // menuAccount
            // 
            this.menuAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOldUser});
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(75, 20);
            this.menuAccount.Text = "&Account";
            // 
            // mnuOldUser
            // 
            this.mnuOldUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMyAccount,
            this.mnuOtherAccount});
            this.mnuOldUser.Image = ((System.Drawing.Image)(resources.GetObject("mnuOldUser.Image")));
            this.mnuOldUser.Name = "mnuOldUser";
            this.mnuOldUser.Size = new System.Drawing.Size(129, 22);
            this.mnuOldUser.Text = "&OldUser";
            // 
            // mnuMyAccount
            // 
            this.mnuMyAccount.Image = ((System.Drawing.Image)(resources.GetObject("mnuMyAccount.Image")));
            this.mnuMyAccount.Name = "mnuMyAccount";
            this.mnuMyAccount.Size = new System.Drawing.Size(307, 22);
            this.mnuMyAccount.Text = "&Customise My Account";
            this.mnuMyAccount.Visible = false;
            this.mnuMyAccount.Click += new System.EventHandler(this.mnuMyAccount_Click);
            // 
            // mnuOtherAccount
            // 
            this.mnuOtherAccount.Image = ((System.Drawing.Image)(resources.GetObject("mnuOtherAccount.Image")));
            this.mnuOtherAccount.Name = "mnuOtherAccount";
            this.mnuOtherAccount.Size = new System.Drawing.Size(307, 22);
            this.mnuOtherAccount.Text = "&Customisse Other Accoun (Admin)";
            this.mnuOtherAccount.Click += new System.EventHandler(this.mnuOtherAccount_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Visible = false;
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.nepaliUnicodeToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // nepaliUnicodeToolStripMenuItem
            // 
            this.nepaliUnicodeToolStripMenuItem.Name = "nepaliUnicodeToolStripMenuItem";
            this.nepaliUnicodeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.nepaliUnicodeToolStripMenuItem.Text = "Nepali (Unicode)";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allBookInfoToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Visible = false;
            // 
            // allBookInfoToolStripMenuItem
            // 
            this.allBookInfoToolStripMenuItem.Name = "allBookInfoToolStripMenuItem";
            this.allBookInfoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.allBookInfoToolStripMenuItem.Text = "All Book Info";
            this.allBookInfoToolStripMenuItem.Click += new System.EventHandler(this.allBookInfoToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDatabaseToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // backupDatabaseToolStripMenuItem
            // 
            this.backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            this.backupDatabaseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.backupDatabaseToolStripMenuItem.Text = "Backup database";
            this.backupDatabaseToolStripMenuItem.Visible = false;
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.videoTutorialToolStripMenuItem,
            this.mailUsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("websiteToolStripMenuItem.Image")));
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.websiteToolStripMenuItem.Text = "&Online Help";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // videoTutorialToolStripMenuItem
            // 
            this.videoTutorialToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("videoTutorialToolStripMenuItem.Image")));
            this.videoTutorialToolStripMenuItem.Name = "videoTutorialToolStripMenuItem";
            this.videoTutorialToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.videoTutorialToolStripMenuItem.Text = "&Video Tutorial";
            this.videoTutorialToolStripMenuItem.Click += new System.EventHandler(this.videoTutorialToolStripMenuItem_Click);
            // 
            // mailUsToolStripMenuItem
            // 
            this.mailUsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mailUsToolStripMenuItem.Image")));
            this.mailUsToolStripMenuItem.Name = "mailUsToolStripMenuItem";
            this.mailUsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mailUsToolStripMenuItem.Text = "Mail Us";
            this.mailUsToolStripMenuItem.Click += new System.EventHandler(this.mailUsToolStripMenuItem_Click);
            // 
            // bookDataSet
            // 
            this.bookDataSet.DataSetName = "BookDataSet";
            this.bookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // BookMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 673);
            this.Controls.Add(this.toolStripContainer3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Store";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Move += new System.EventHandler(this.BookMain_Move);
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            this.toolStripContainer4.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer4.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer4.ContentPanel.ResumeLayout(false);
            this.toolStripContainer4.ResumeLayout(false);
            this.toolStripContainer4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Bill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookInfo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        void BookMain_Move(object sender, System.EventArgs e)
        {
            //this.Top = 10;
           // this.Left =250;

        }

        void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtShell.Text == "")
            {
                lblTotal.Text = (float.Parse(lblPrice.Text) * 0).ToString();
            }
            else
            {
                lblTotal.Text = (float.Parse(lblPrice.Text) * int.Parse(txtShell.Text)).ToString();
                if (txtDiscount.Text == "")
                {
                    lblGrandTotal.Text = lblTotal.Text;
                }
                else
                {
                    lblGrandTotal.Text = (float.Parse(lblTotal.Text) - float.Parse(txtDiscount.Text)).ToString();
                }
            }
        }

        void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                lblShowName.Text = "Press only float numbers";
                System.Console.Beep();
            }
        }

        void txtAPRice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)&& e.KeyChar != '.')
            {
                e.Handled = true;
                lblShowName.Text = "Press only float numbers";
                System.Console.Beep();
            }

        }

        void txtShell_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
           {
               try
               {
                   if (int.Parse(txtShell.Text) <= 100000)
                   {
                       e.Handled = true;
                       lblShowName.Text = "Press only numeric values";
                       System.Console.Beep();
                   }
                   else
                   {
                       e.Handled = false;
                   }
               }
               catch
               {
               }
            }
            /*
            // only allow one decimal point
            if (e.KeyChar == '.'&& (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }*/

        }

        void txtShell_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            
            if (txtShell.Text == "")
            {
                lblTotal.Text = (float.Parse(lblPrice.Text) * 0).ToString();
            }
            else
            {
                lblTotal.Text = (float.Parse(lblPrice.Text) * int.Parse(txtShell.Text)).ToString();
                if (txtDiscount.Text == "")
                {
                    lblGrandTotal.Text = lblTotal.Text;
                }
                else
                {
                    lblGrandTotal.Text =(float.Parse(lblTotal.Text) - float.Parse(txtDiscount.Text)).ToString();
                }
            }
        }

        void txtSBookName_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            SearchAndFill();
        }

        void txtSPublication_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            SearchAndFill();
        }

        void txtSEdition_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            SearchAndFill();
        }

        void txtSAuthor1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            SearchAndFill();
        }

        void txtSAuthor2_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            SearchAndFill();
        }

        void txtSPrice_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            SearchAndFill();
        }

        void txtSID_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            SearchAndFill();
        }

        void txtAID_DoubleClick(object sender, System.EventArgs e)
        {
            this.btnAdd.Text = "Add";
            this.txtAID.Text = null;
            this.txtABookName.Text = null;
            this.txtAEdition.Text = null;
            this.txtAPublication.Text =null;
            this.txtAAuthor1.Text = null;
            this.txtAAuthor2.Text =null;
            this.txtAPRice.Text = null;
        }

        void dgBookInfo_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.lblId.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[1].Value.ToString();
                this.lblBookName.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[2].Value.ToString();
                this.lblPublication.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[3].Value.ToString();
                this.lblEdition.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[4].Value.ToString();
                this.lblAuthors.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[5].Value.ToString() + " and " + this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[6].Value.ToString();
                //this.txtAAuthor2.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[6].Value.ToString();
                this.lblPrice.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[7].Value.ToString();
            }
            catch
            {
            }
        }

        void dgBookInfo_RowHeaderMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.btnAdd.Text = "Update";
                this.txtAID.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[1].Value.ToString();
                this.txtABookName.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[2].Value.ToString();
                this.txtAPublication.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[3].Value.ToString();
                this.txtAEdition.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[4].Value.ToString();
                this.txtAAuthor1.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[5].Value.ToString();
                this.txtAAuthor2.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[6].Value.ToString();
                this.txtAPRice.Text = this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[7].Value.ToString();
            }
            catch
            {
            }
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblShowName;
        private System.Windows.Forms.ToolStripContainer toolStripContainer4;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnuExit;
        public System.Windows.Forms.ToolStripMenuItem menuAccount;
        public System.Windows.Forms.ToolStripMenuItem mnuOldUser;
        public System.Windows.Forms.ToolStripMenuItem mnuMyAccount;
        public System.Windows.Forms.ToolStripMenuItem mnuOtherAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSPrice;
        private System.Windows.Forms.TextBox txtSAuthor2;
        private System.Windows.Forms.TextBox txtSAuthor1;
        private System.Windows.Forms.TextBox txtSEdition;
        private System.Windows.Forms.TextBox txtSPublication;
        private System.Windows.Forms.TextBox txtSBookName;
        private System.Windows.Forms.DataGridView dgBookInfo;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAID;
        private System.Windows.Forms.TextBox txtAPRice;
        private System.Windows.Forms.TextBox txtAAuthor2;
        private System.Windows.Forms.TextBox txtAAuthor1;
        private System.Windows.Forms.TextBox txtAEdition;
        private System.Windows.Forms.TextBox txtAPublication;
        private System.Windows.Forms.TextBox txtABookName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookPubl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAuthor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAuthor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblPublication;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtShell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox Bill;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private BookDataSet bookDataSet;
        private System.Windows.Forms.Label lblId;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem nepaliUnicodeToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private DataGridView dgBill;
        private CheckBox chkBuy;
        private TextBox txtDiscount;
        private Label label9;
        private Label label8;
        private Label lblGrandTotal;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem websiteToolStripMenuItem;
        private ToolStripMenuItem videoTutorialToolStripMenuItem;
        private ToolStripMenuItem mailUsToolStripMenuItem;
        private ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private GroupBox groupBox4;
        private Label label10;
        private Label lblBillTotal;
        private Button btnSubmit;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn bclmSn;
        private DataGridViewTextBoxColumn bclmItem;
        private DataGridViewTextBoxColumn bclmRate;
        private DataGridViewTextBoxColumn clmQuentity;
        private DataGridViewTextBoxColumn bclmTotal;
        private DataGridViewTextBoxColumn clmDiscount;
        private DataGridViewTextBoxColumn clmGTotal;
        private DataGridViewTextBoxColumn clmRemark;
        private PictureBox pictureBox1;
        private ToolStripMenuItem calculatorToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem allBookInfoToolStripMenuItem;
    }
}

