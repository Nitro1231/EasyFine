using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Drawing.Drawing2D;
using System.IO;

namespace EasyFine {
    public partial class Item : UserControl {
        int progress = 0;
        string name;
        bool isReady = false, isDownloaded = false;
        WebBrowser webBrowser = new WebBrowser();

        public Item(string name, string url) {
            InitializeComponent();
            this.name = name;
            textLabel.Text = name;
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompleted);
            webBrowser.Navigate(url);
        }


        private void textLabel_Click(object sender, EventArgs e) {
            if (isReady) {
                HtmlDocument doc = webBrowser.Document;
                HtmlElement downloadURL = doc.GetElementById("Download");
                foreach (HtmlElement el in downloadURL.GetElementsByTagName("a")) {
                    download(el.GetAttribute("href"));
                    break;
                }
            }
        }

        private void DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            isReady = true;
            textLabel.ForeColor = Color.FromArgb(240, 240, 240);
        }

        private void download(string dURL) {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(onDownload);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(onDownloadCompleted);
                client.DownloadFileAsync(new Uri(dURL), Directory.GetCurrentDirectory() + $"\\{name}.jar");
            });
            thread.Start();
        }

        void onDownload(object sender, DownloadProgressChangedEventArgs e) {
            BeginInvoke((MethodInvoker)delegate {
                double mbIn = double.Parse(e.BytesReceived.ToString()) / 1024 / 1024;
                double totalMB = double.Parse(e.TotalBytesToReceive.ToString()) / 1024 / 1024;
                int percentage = (int)Math.Round(mbIn / totalMB * 100);
                textLabel.Text = $"{name}\nDownloaded {Math.Round(mbIn, 2)}MB of {Math.Round(totalMB, 2)}MB ({percentage}%)";
                progress = percentage;
                progressPanel.Update();
                progressPanel.Refresh();
            });
        }

        void onDownloadCompleted(object sender, AsyncCompletedEventArgs e) {
            BeginInvoke((MethodInvoker)delegate {
                textLabel.Text = $"{name}\nDownloaded";
            });
        }

        private void progressPanel_Paint(object sender, PaintEventArgs e) {
            int count = ((progressPanel.Width - 80) / 100) * progress;
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(40, 0, count + 40, Height);
            if (count > 0) {
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
        }
    }
}
