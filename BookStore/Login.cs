using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Authentication;
using Signup;
using Database;
using EncryptMD5;

namespace BookStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btmLogin;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

        }

        private void btmExit_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btmLogin_Click(object sender, EventArgs e)
        {
            String txtName = this.txtUname.Text;
            String pass = this.txtPass.Text;
            Authentication.Login lg = new Authentication.Login(txtName, EncryptMD5.Md5Password.GetMd5Pass(pass));
            DataSet ds;
            if (lg.ErrorMessage == null)
            {
                ds = lg.GetResult;
                if (ds.Tables["tbl"].Rows.Count >= 1)
                {
                    MessageBox.Show("Sucessfully Login.");
                    CheckLogin.isLogin = true;
                    CheckLogin.userInfo = ds;
                    this.Close();
                    BookMain b = (BookMain)CheckLogin.obj;
                    b.lblShowName.Text = "USER : " + ds.Tables["tbl"].Rows[0][1].ToString() + " Loging as : " + ds.Tables["tbl"].Rows[0][4].ToString();
                    if (ds.Tables[0].Rows[0][4].ToString() == "Admin")
                    {
                        //b.mnuNewUser.Enabled = true;                                               
                        b.mnuOtherAccount.Enabled = true;

                    }
                    else
                    {
                        // b.mnuNewUser.Enabled = false;
                        b.mnuOtherAccount.Enabled = false;
                    }
                    b.Show();
                }
                else
                {
                    CheckLogin.isLogin = false;
                    MessageBox.Show("Username And Password Doesnot Match");

                }
            }
            else
            {

            }


        }
    }
}
