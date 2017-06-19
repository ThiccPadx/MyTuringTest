using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Reader01
{
    public partial class FormR : Form
    {
        public FormR()
        {
            InitializeComponent();
        }

        private void buttonTemp_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(Properties.Resources.StringURL);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ProgressLoadPage();
        }

        private void ProgressLoadPage()
        {
            timerLoadPage.Start();
        }

        private void timerLoadPage_Tick(object sender, EventArgs e)
        {
            VProgressBarLoadPage.Value += 1;
            if (VProgressBarLoadPage.Value >= 100)
            {
                timerLoadPage.Stop();
            }
        }
    }
}
