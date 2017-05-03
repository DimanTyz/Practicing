using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deleteme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void materialSingleLineTextField1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                webBrowser1.Navigate(materialSingleLineTextField1.Text);
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(materialSingleLineTextField1.Text))
            {
                webBrowser1.Navigate(materialSingleLineTextField1.Text);
            }
        }
    }
}
