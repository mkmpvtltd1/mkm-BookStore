using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookStore
{
    public partial class onlineHelp : UserControl
    {
        public string url = "http://www.mkmpvtltd.eu.pn";
        public onlineHelp()
        {
            InitializeComponent();
            webBrowser1.Navigate(url);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            url = textBox1.Text;
            webBrowser1.Navigate(url);
        }


       

    }
}
