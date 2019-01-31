using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtGoto.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnGoNext_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtGoto.Text = webBrowser.Url.ToString();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            webBrowser.Document.GetElementById("search-icon-legacy").InvokeMember("yt-action");
            //webBrowser.Document.GetElementById("button").InvokeMember("Click");
        }
    }
}
