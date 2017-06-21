using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
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
            ProgressLoadFrames();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Alarm04.wav");
            simpleSound.Play();
        }

        private void ProgressLoadFrames()
        {
            VProgressBarLoadPage.Value = 0;
            timerLoadPage.Start();
        }

        private void TestTuring()
        {
            IHTMLDocument2 doc = (IHTMLDocument2)webBrowser.Document.DomDocument;
            HtmlElementCollection imgCollection = webBrowser.Document.GetElementsByTagName("img");
            IHTMLControlRange imgRange = (IHTMLControlRange)((HTMLBody)doc.body).createControlRange();
            int i = 0;
            foreach (HtmlElement img in imgCollection)
            {
                IHTMLControlElement cimg = img.DomElement as IHTMLControlElement;
                if (cimg != null)
                {
                    imgRange.add(cimg);
                    imgRange.execCommand("Copy", false, null);
                    using (Bitmap bmp = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap))
                    {
                        var imgName = "img" + i + ".gif";
                        bmp.Save(imgName);
                        i++;
                    }
                }
            }
        }

        private void timerLoadPage_Tick(object sender, EventArgs e)
        {
            VProgressBarLoadPage.Value += 1;
            if (VProgressBarLoadPage.Value >= 100)
            {
                timerLoadPage.Stop();
                TestTuring();
            }
        }
        private string[] GetImageUrls()
        {
            if (webBrowser.Document != null)
            {
                webBrowser.Refresh(WebBrowserRefreshOption.Normal);
                ProgressLoadFrames();
                HtmlDocument doc = webBrowser.Document;
                string[] urls = (string[])Array.CreateInstance(Type.GetType("System.String"), doc.Images.Count);

                foreach (HtmlElement imgElement in doc.Images)
                {
                    urls[urls.Length] = imgElement.GetAttribute("src");
                }
                return (urls);
            }
            else
            {
                return (new string[0]);
            }
        }
    }
}
