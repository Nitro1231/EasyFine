using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Drawing.Drawing2D;
using System.IO;
using System.Diagnostics;

namespace EasyFine {
    public partial class Item : UserControl {
        int progress = 0;
        string name, path;
        bool isReady = false, isDownloaded = false;
        WebBrowser webBrowser = new WebBrowser();

        public Item(string name, string url) {
            InitializeComponent();
            Utils.smoothBorder(this, 10);
            this.name = name;
            path = Directory.GetCurrentDirectory() + $"\\{name}.jar";
            textLabel.Text = name;
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompleted);
            webBrowser.Navigate(url);
        }

        private void textLabel_Click(object sender, EventArgs e) {
            if (isReady) {
                if (!isDownloaded) {
                    HtmlDocument doc = webBrowser.Document;
                    HtmlElement downloadURL = doc.GetElementById("Download");
                    foreach (HtmlElement el in downloadURL.GetElementsByTagName("a")) {
                        download(el.GetAttribute("href"));
                        break;
                    }
                } else {
                    if (File.Exists(path)) {
                        ProcessStartInfo ps = new ProcessStartInfo("CMD.exe", $"/c java -jar \"{path}\"");
                        ps.CreateNoWindow = true;
                        Process.Start(ps);
                    }else {
                        isDownloaded = false;
                        progress = 0;
                        textLabel.Text = name;
                        Update();
                        MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            isReady = true;
            textLabel.ForeColor = Color.FromArgb(240, 240, 240);

            if (File.Exists(path)) {
                isDownloaded = true;
                progress = 100;
                textLabel.Text = $"{name}\nDownloaded";
            }
        }

        private void download(string dURL) {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(onDownload);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(onDownloadCompleted);
                client.DownloadFileAsync(new Uri(dURL), path);
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
                Update();
            });
        }

        void onDownloadCompleted(object sender, AsyncCompletedEventArgs e) {
            BeginInvoke((MethodInvoker)delegate {
                isDownloaded = true;
                textLabel.Text = $"{name}\nDownloaded";
            });
        }

        private void Item_Paint(object sender, PaintEventArgs e) {
            int count = (int)Math.Round((double)Width / 100 * progress);
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, count, Height);
            if (count > 0) {
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
        }
    }
}
