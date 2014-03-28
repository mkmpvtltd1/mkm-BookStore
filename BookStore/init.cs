using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookStore
{
    public partial class init : Form
    {
        public string title = null;
        public UserControl cont = null;
        public init(UserControl cont)
        {
            this.cont = cont;
            InitializeComponent();
        }

        private void init_Load(object sender, EventArgs e)
        {
            BookMain b = (BookMain)CheckLogin.obj;
            this.Text = this.title;
            this.holder.Controls.Add(this.cont);
        }
    }
}
