using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserAccount;
using Signup;
using EncryptMD5;

namespace BookStore.User_Account.OldUser
{
    public partial class OtherAccount : UserControl
    {
        public OtherAccount()
        {
            InitializeComponent();
        }
        void dgUserDetails_RowHeaderMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            this.txtID.Text = this.dgUserDetails.Rows[this.dgUserDetails.CurrentCellAddress.Y].Cells[1].Value.ToString();
            this.txtName.Text = this.dgUserDetails.Rows[this.dgUserDetails.CurrentCellAddress.Y].Cells[2].Value.ToString();
            this.txtUName.Text = this.dgUserDetails.Rows[this.dgUserDetails.CurrentCellAddress.Y].Cells[3].Value.ToString();
            this.cmbAccType.Text = this.dgUserDetails.Rows[this.dgUserDetails.CurrentCellAddress.Y].Cells[4].Value.ToString();
            this.cmbStatus.Text = this.dgUserDetails.Rows[this.dgUserDetails.CurrentCellAddress.Y].Cells[5].Value.ToString();

            //this.txtName.Text = this.dgUserDetails.Rows[this.dgUserDetails.CurrentCellAddress.Y].Cells[1].Value.ToString();
        }
        private void FillDataGride()
        {
            AllUserTask tk = new AllUserTask();
            DataSet ds = tk.GetAllRecord();
            this.cmbAccType.Text = "User";
            this.cmbStatus.Text = "Suspended";
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    this.dgUserDetails.Rows.Add(ds.Tables[0].Rows.Count);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        this.dgUserDetails.Rows[i].Cells[0].Value = (i+1).ToString();
                        this.dgUserDetails.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][0].ToString();
                        this.dgUserDetails.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][1].ToString();
                        this.dgUserDetails.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][2].ToString();
                        this.dgUserDetails.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][4].ToString();                        
                        this.dgUserDetails.Rows[i].Cells[5].Value = (ds.Tables[0].Rows[i][5].ToString()=="a")?"Active":"Suspended";
                       // this.dgUserDetails.Rows.Add();
                        //this.dgUserDetails.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                    }
                }
            }
        }

        private void OtherAccount_Load(object sender, EventArgs e)
        {
            FillDataGride();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {                
            if (this.txtID.Text == "")
            {
                DoSignup ds = new DoSignup(this.txtName.Text, this.txtUName.Text, EncryptMD5.Md5Password.GetMd5Pass(this.txtPassword.Text), "", this.cmbAccType.Text, ((this.cmbStatus.Text.ToString() == "Active") ? "a" : "s").ToString());
                if (ds.ErrorMessage == null)
                {
                    this.dgUserDetails.Rows.Clear();
                    FillDataGride();
                    MessageBox.Show("New User Created Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtID.Text = "";
                    this.txtName.Text = "";
                    this.txtPassword.Text = "";
                    this.txtUName.Text = "";
                    this.cmbAccType.Text = "User";
                    this.cmbStatus.Text = "Suspended";
                }
                else
                {
                    MessageBox.Show("New User Cannot created, There might be same as previous username provided by you.Try another username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtID.Text = "";
                    this.txtName.Text = "";
                    this.txtPassword.Text = "";
                    this.txtUName.Text = "";
                    this.cmbAccType.Text = "User";
                    this.cmbStatus.Text = "Suspended";
                }
            }
            else
            {
                AllUserTask tk = new AllUserTask();
                String res= tk.updateRecords(this.txtID.Text,this.txtName.Text,EncryptMD5.Md5Password.GetMd5Pass(this.txtPassword.Text),this.cmbAccType.Text,(this.cmbStatus.Text=="Active")?"a":"s");
                if (res != null)
                {
                    // if (int.Parse(res) >= 1)
                    {
                        this.dgUserDetails.Rows.Clear();
                        FillDataGride();
                        MessageBox.Show("Update Records Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtID.Text = "";
                        this.txtName.Text = "";
                        this.txtPassword.Text = "";
                        this.txtUName.Text = "";
                        this.cmbAccType.Text = "User";
                        this.cmbStatus.Text = "Suspended";
                    }
                    //  else
                    {
                    //     MessageBox.Show("Could not update Records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("An UnExpected error While Updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtID.Text != "")
            {
                DialogResult r = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == r)
                {
                    AllUserTask tk = new AllUserTask();
                    String res = tk.deleteRecord(this.txtID.Text);
                    if (res != null)
                    {
                        // if (Int64.Parse(res) >= 1)
                        {
                            this.dgUserDetails.Rows.Clear();
                            FillDataGride();
                            this.txtID.Text = null;
                            this.txtName.Text = null;
                            this.txtUName.Text = null;
                            this.txtPassword.Text = null;
                          
                            MessageBox.Show("Success");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("No any User SelectedTodelete user account", "Select 1 User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
