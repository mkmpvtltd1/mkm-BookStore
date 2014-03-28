using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Database;
using System.Data.SqlClient;
using AddBook;
using UserAccount;
using AddBill;
using AddToBook;
using AddToMoney;
using allBillPrint;
using System.Diagnostics;
//using Microsoft.SqlServer.Management.Smo;


namespace BookStore
{
    public partial class BookMain : Form
    {
        public BookMain()
        {
            InitializeComponent();
            FillDataGrid();
            FillBillGrid();
        }

        public void FillBillGrid()
        {
            AddBill.GetBillRecords th = new AddBill.GetBillRecords();
            DataSet ds = th.getAllBillRecord();
            this.dgBill.Rows.Clear();
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    this.dgBill.Rows.Add(ds.Tables[0].Rows.Count);
                    float total = 0;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        this.dgBill.Rows[i].Cells[0].Value = (i + 1).ToString();
                        this.dgBill.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][3].ToString();
                        this.dgBill.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][4].ToString();
                        this.dgBill.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][5].ToString();
                        this.dgBill.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][6].ToString();
                        this.dgBill.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][7].ToString();
                        this.dgBill.Rows[i].Cells[6].Value = ds.Tables[0].Rows[i][8].ToString();
                        if (int.Parse(ds.Tables[0].Rows[i][5].ToString()) <= 0)
                        {
                            total = total - float.Parse(ds.Tables[0].Rows[i][8].ToString());
                        }
                        else
                        {
                            total = total + float.Parse(ds.Tables[0].Rows[i][8].ToString());
                        }

                        lblBillTotal.Text = total.ToString();
                        // this.dgBookInfo.Rows[i].Cells[7].Value = ds.Tables[0].Rows[i][12].ToString();
                        //this.dgBookInfo.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i][13].ToString();
                    }

                }

            }
        }

        public void FillDataGrid()
        {
            AddBook.GetRecords tk = new AddBook.GetRecords();
            DataSet ds = tk.getAllRecord();
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    this.dgBookInfo.Rows.Add(ds.Tables[0].Rows.Count);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        this.dgBookInfo.Rows[i].Cells[0].Value = (i + 1).ToString();
                        this.dgBookInfo.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][0].ToString();
                        this.dgBookInfo.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][1].ToString();
                        this.dgBookInfo.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][2].ToString();
                        this.dgBookInfo.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][7].ToString();
                        this.dgBookInfo.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][3].ToString();
                        this.dgBookInfo.Rows[i].Cells[6].Value = ds.Tables[0].Rows[i][8].ToString();
                        this.dgBookInfo.Rows[i].Cells[7].Value = ds.Tables[0].Rows[i][12].ToString();
                        this.dgBookInfo.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i][13].ToString();
                    }
                }
            }
        }

        public void SearchAndFill()
        {
            this.dgBookInfo.Rows.Clear();
            //MessageBox.Show("test");
            AddBook.AllBookTask tk = new AddBook.AllBookTask();
            DataSet ds = tk.searchRecord(this.txtSID.Text, this.txtSBookName.Text, this.txtSPublication.Text, this.txtSEdition.Text, this.txtSAuthor1.Text, this.txtSAuthor2.Text, this.txtSPrice.Text);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    this.dgBookInfo.Rows.Add(ds.Tables[0].Rows.Count);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        this.dgBookInfo.Rows[i].Cells[0].Value = (i + 1).ToString();
                        this.dgBookInfo.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][0].ToString();
                        this.dgBookInfo.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][1].ToString();
                        this.dgBookInfo.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][2].ToString();
                        this.dgBookInfo.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][7].ToString();
                        this.dgBookInfo.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][3].ToString();
                        this.dgBookInfo.Rows[i].Cells[6].Value = ds.Tables[0].Rows[i][8].ToString();
                        this.dgBookInfo.Rows[i].Cells[7].Value = ds.Tables[0].Rows[i][12].ToString();
                        this.dgBookInfo.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i][13].ToString();
                    }
                }
            }
        }

        public void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookDataSet.tblTransition' table. You can move, or remove it, as needed.
            //this.tblTransitionTableAdapter.Fill(this.bookDataSet.tblTransition);
            if (CheckLogin.isLogin == false)
            {
                this.Hide();
                BookStore.CheckLogin.obj = this;
                Login login = new Login();
                login.FormBorderStyle = FormBorderStyle.FixedDialog;
                login.ShowDialog();
            }
        }

        private void menuNewUser_Click(object sender, EventArgs e)
        {
            User_Account.NewUser uc = new User_Account.NewUser();
            init it = new init(uc);
            it.FormBorderStyle = FormBorderStyle.FixedDialog;
            it.MaximizeBox = false;
            it.MinimizeBox = false;
            it.Width = 275;
            it.Height = 260;
            it.title = "Create New User Account";
            it.cont = uc;
            it.ShowDialog();
        }

        private void mnuMyAccount_Click(object sender, EventArgs e)
        {
            User_Account.OldUser.MyAccount uc = new User_Account.OldUser.MyAccount();
            init it = new init(uc);
            it.FormBorderStyle = FormBorderStyle.FixedDialog;
            it.MaximizeBox = false;
            it.MinimizeBox = false;
            it.RightToLeftLayout = false;
            it.Height = 260;
            it.Width = 275;
            it.title = "Modify My Account";
            it.cont = uc;
            it.ShowDialog();
        }

        private void mnuOtherAccount_Click(object sender, EventArgs e)
        {
            User_Account.OldUser.OtherAccount uc = new User_Account.OldUser.OtherAccount();
            init it = new init(uc);
            it.FormBorderStyle = FormBorderStyle.FixedDialog;
            it.MaximizeBox = false;
            it.MinimizeBox = false;
            it.Height = 375;
            it.Width = 520;
            it.title = "Modyfy Other Accounts";
            it.cont = uc;
            it.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (this.txtAID.Text == "")
            {
                addBook ds = new addBook(this.txtABookName.Text, this.txtAPublication.Text, this.txtAEdition.Text, this.txtAAuthor1.Text, this.txtAAuthor2.Text, this.txtAPRice.Text);
                if (ds.ErrorMessage == null)
                {
                    this.dgBookInfo.Rows.Clear();
                    FillDataGrid();
                    MessageBox.Show("New Book Entry Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtAID.Text = null;
                    this.txtABookName.Text = null;
                    this.txtAEdition.Text = null;
                    this.txtAPublication.Text = null;
                    this.txtAAuthor1.Text = null;
                    this.txtAAuthor2.Text = null;
                    this.txtAPRice.Text = null;
                }
                else
                {
                    MessageBox.Show("New Book Entry Cannot Sucess.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    /*  this.txtAID.Text = null;
                      this.txtABookName.Text = null;
                      this.txtAEdition.Text = null;
                      this.txtAPublication.Text = null;
                      this.txtAAuthor1.Text = null;
                      this.txtAAuthor2.Text = null;
                      this.txtAPRice.Text = null;*/
                }
            }
            else
            {
                AddBook.AllBookTask tk = new AllBookTask();
                String res = tk.updateBooks(this.txtAID.Text, this.txtABookName.Text, this.txtAPublication.Text, this.txtAEdition.Text, this.txtAAuthor1.Text, this.txtAAuthor2.Text, this.txtAPRice.Text, 0);
                if (res != null)
                {
                    // if (int.Parse(res) >= 1)
                    {
                        this.dgBookInfo.Rows.Clear();
                        FillDataGrid();
                        MessageBox.Show("Book Update Sucess.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtAID.Text = null;
                        this.txtABookName.Text = null;
                        this.txtAEdition.Text = null;
                        this.txtAPublication.Text = null;
                        this.txtAAuthor1.Text = null;
                        this.txtAAuthor2.Text = null;
                        this.txtAPRice.Text = null;
                        this.btnAdd.Text = "Add";
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
            if (txtAID.Text != "")
            {
                DialogResult r = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == r)
                {
                    AddBook.AllBookTask tk = new AllBookTask();
                    String res = tk.deleteRecord(this.txtAID.Text);
                    if (res != null)
                    {
                        // if (Int64.Parse(res) >= 1)
                        {
                            this.dgBookInfo.Rows.Clear();
                            FillDataGrid();
                            this.txtAID.Text = null;
                            this.txtABookName.Text = null;
                            this.txtAEdition.Text = null;
                            this.txtAPublication.Text = null;
                            this.txtAAuthor1.Text = null;
                            this.txtAAuthor2.Text = null;
                            this.txtAPRice.Text = null;
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
                MessageBox.Show("No any item Selected, for delete item Select item by Double Click on wanted row", "Select 1 item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtAID_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            if (CheckLogin.isLogin == false)
            {
                this.Hide();
                BookStore.CheckLogin.obj = this;
                Login login = new Login();
                login.ShowDialog();
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            if (lblPrice.Text.ToString() != "0")
            {
                if (txtShell.Text.ToString() != "0")
                {
                    AddBook.GetRecords tk = new AddBook.GetRecords();
                    DataSet ds = tk.getAllRecord();
                    AddBill.GetBillRecords th = new AddBill.GetBillRecords();
                    DataSet dh = th.getAllBillRecord();
                    AddBook.AllBookTask tk2 = new AllBookTask();

                    if (chkBuy.Checked == true)
                    {
                        AddBill.AddBill ab = new AddBill.AddBill(dh.Tables[0].Rows.Count + 1, int.Parse(lblId.Text), lblBookName.Text, float.Parse(lblPrice.Text), -int.Parse(txtShell.Text), float.Parse(lblTotal.Text), float.Parse(txtDiscount.Text), float.Parse(lblGrandTotal.Text));
                        String res = tk2.updateBooks(this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[1].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[2].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[3].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[4].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[5].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[6].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[7].Value.ToString(), int.Parse(this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[8].Value.ToString()) + int.Parse(this.txtShell.Text));
                        MessageBox.Show("Book Buying");
                    }
                    else if (chkBuy.Checked == false)
                    {
                        if (int.Parse(this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[8].Value.ToString()) >= int.Parse(txtShell.Text.ToString()))
                        {
                            AddBill.AddBill ab = new AddBill.AddBill(dh.Tables[0].Rows.Count + 1, int.Parse(lblId.Text), lblBookName.Text, float.Parse(lblPrice.Text), +int.Parse(txtShell.Text), float.Parse(lblTotal.Text), float.Parse(txtDiscount.Text), float.Parse(lblGrandTotal.Text));

                            String res = tk2.updateBooks(this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[1].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[2].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[3].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[4].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[5].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[6].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[7].Value.ToString(), int.Parse(this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[8].Value.ToString()) - int.Parse(this.txtShell.Text));
                            MessageBox.Show("book shelling");
                        }
                        else
                        {
                            MessageBox.Show("there is less amount of stoke then you want,  ");
                        }



                    }
                    this.dgBookInfo.Rows.Clear();
                    FillDataGrid();
                    FillBillGrid();
                }
                else
                {
                    MessageBox.Show("Enter Piece for Selected Item.");
                }
            }
            else
            {
                MessageBox.Show("No any item Selected");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onlineHelp uc = new onlineHelp();
            //User_Account.OldUser.OtherAccount uc = new User_Account.OldUser.OtherAccount();
            init it = new init(uc);
            it.FormBorderStyle = FormBorderStyle.FixedDialog;

            it.MaximizeBox = false;
            it.MinimizeBox = false;
            it.Height = 450;
            it.Width = 785;
            it.title = "Online Tutiorial";
            it.cont = uc;
            it.ShowDialog();
        }

        private void videoTutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //string target = "C:\\Users\\mega\\Desktop\\Store\\Store\\BookStore\\bin\\Debug\\Video\\Help.AVI";
                System.Diagnostics.Process.Start(".\\Video\\Help.AVI");
            }
            catch { }
        }

        private void mailUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:mkmpvtltd@gmail.com");
            }
            catch { System.Console.Beep(); MessageBox.Show("No Mailing Program is instaled in your Computer."); }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            AddBill.GetBillRecords th = new AddBill.GetBillRecords();
            DataSet ds = th.getAllBillRecord();
            AddBook.AllBookTask tk = new AllBookTask();
            Db d = new Db();
            string connecrionstring = d.getConnection.ConnectionString;
            
            // DataSet ds1 = tk.getAllRecord();
         //   string connecrionstring = "Data Source=MANOJ\\SQLEXPRESS;Initial Catalog=Book;Integrated Security=True";
            SqlConnection con = new SqlConnection(connecrionstring);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tblBill", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                //String res1 = tk.updateBooks(ds2.Tables[0].Rows[i][2].ToString(), this.dgBill.Rows[this.dgBill.CurrentCellAddress.Y].Cells[1].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[3].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[4].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[5].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[6].Value.ToString(), this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[7].Value.ToString(), int.Parse(this.dgBookInfo.Rows[this.dgBookInfo.CurrentCellAddress.Y].Cells[8].Value.ToString()) + int.Parse(this.txtShell.Text));
                AddToBook.addToBook ab = new addToBook(int.Parse(ds.Tables[0].Rows[i][2].ToString()), int.Parse(ds.Tables[0].Rows[i][5].ToString()), DateTime.Now.ToShortDateString().ToString(), DateTime.Now.ToShortTimeString().ToString());
            }
            AddToMoney.addToMoney am = new addToMoney(float.Parse(lblBillTotal.Text), DateTime.Now.ToShortDateString().ToString(), DateTime.Now.ToShortTimeString().ToString());

            // DialogResult rs = this.printDialog1.ShowDialog();
            this.printDocument1.Print();
            DataSet res = th.DeleteBillRecords();
            FillBillGrid();
            this.lblBillTotal.Text = "";
            MessageBox.Show("Transition commited");

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string strName = "Book Store";
            allBillPrint.BillPRint mk = new BillPRint();
            DataSet dse = mk.getAllRecord();
            float page = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font f = new Font("Arial", 10);
            Font t = new Font("Arial", 15);
            Db d = new Db();
            string connecrionstring = d.getConnection.ConnectionString;
            SqlConnection con = new SqlConnection(connecrionstring);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tblBill", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            int ypos = 65;
            page = e.MarginBounds.Height / f.GetHeight();
            Pen p = new Pen(Brushes.Black);
            e.Graphics.DrawString(strName, t, Brushes.Red, 100, 10);
            e.Graphics.DrawString("Bill No.:- " + dse.Tables[0].Rows[dse.Tables[0].Rows.Count - 1][0].ToString(), f, Brushes.Red, 10, 30);
            e.Graphics.DrawString("Date :-" + DateTime.Now.ToShortDateString().ToString(), f, Brushes.Red, 380, 30);
            e.Graphics.DrawString("S.No. Book Name                              Rate   Quentity  Dicount  Total   Remark", f, Brushes.Black, 2, 45);
            e.Graphics.DrawLine(p, new Point(2, 65), new Point(480, 65));

            for (int i = 0; i < dgBill.Rows.Count - 1; i++)
            {

                string bn = ds2.Tables[0].Rows[i][3].ToString();
                string rt1 = ds2.Tables[0].Rows[i][4].ToString();
                float rt = float.Parse(rt1);
                string qt = ds2.Tables[0].Rows[i][5].ToString();
                string tl1 = ds2.Tables[0].Rows[i][8].ToString();
                int qt1 = int.Parse(qt);
                float tl = float.Parse(tl1);
                if (qt1 < 0)
                {
                    tl = -tl;
                }

                string dis1 = ds2.Tables[0].Rows[i][7].ToString();
                float dis = float.Parse(dis1);
                //string ttl = ds2.Tables[0].Rows[i][9].ToString();
                ypos = ypos + 12;
                e.Graphics.DrawString((i + 1).ToString(), f, Brushes.Black, 2, 67 + 12 * i);      //sn
                e.Graphics.DrawString(bn, f, Brushes.Black, 40, 67 + 12 * i);               //item
                e.Graphics.DrawString(String.Format("{0:0.##}", rt), f, Brushes.Black, 230, 67 + 12 * i);       //rate
                e.Graphics.DrawString(qt, f, Brushes.Black, 275, 67 + 12 * i);                  //quentity
                e.Graphics.DrawString(String.Format("{0:0.##}", dis), f, Brushes.Black, 330, 67 + 12 * i);  //discount
                // e.Graphics.DrawString(ttl, f, Brushes.Black, 380, 67 + 12 * i);
                e.Graphics.DrawString(String.Format("{0:0.##}", tl), f, Brushes.Black, 380, 67 + 12 * i);//total
            }
            e.Graphics.DrawString("Total.:- " + lblBillTotal.Text, f, Brushes.Red, 330, ypos + 15);
            e.Graphics.DrawLine(p, new Point(2, ypos + 10), new Point(480, ypos + 10));
            if (line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { Process.Start("calc.exe"); }
            catch (Exception ex)
            {
                System.Console.Beep();
                System.Console.WriteLine(ex.Message);
            }
        }

        private void allBookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.All_Bill_info uc = new Reports.All_Bill_info();
            // User_Account.OldUser.MyAccount uc = new User_Account.OldUser.MyAccount();
            init it = new init(uc);
            it.FormBorderStyle = FormBorderStyle.FixedDialog;
            it.MaximizeBox = false;
            it.MinimizeBox = false;
            it.RightToLeftLayout = false;
            it.Height = 430;
            it.Width = 865;
            it.title = "All Book Information";
            it.cont = uc;
            it.ShowDialog();

        }




    }
}
