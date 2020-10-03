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
        string name, downloadPath, donwloadURL;
        bool isReady = false, isDownloaded = false;
        volatile WebBrowser webBrowser = new WebBrowser();
        Color colorA = Settings.downloadA, colorB = Settings.downloadB;

        public Item(string name, string url) {
            InitializeComponent();
            Utils.smoothBorder(this, 10);
            this.name = name;
            downloadPath = Settings.path + $"\\OptiFine\\{name}.jar";
            textLabel.Text = name;
            webBrowser.ScriptErrorsSuppressed = true;

            Thread thread = new Thread(() => {
                webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompleted);
                webBrowser.Navigate(url);
            });
            thread.Start();
        }

        private void textLabel_Click(object sender, EventArgs e) {
            if (isReady) {
                if (!isDownloaded) {
                    download(donwloadURL);
                } else {
                    if (File.Exists(downloadPath)) {
                        Process process = new Process();
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.StartInfo.FileName = "java";

                        if (Settings.useEasyFineAuto) {
                            Settings.installTool();
                            string mineDir = Settings.getMinecraftDir();
                            if (mineDir != null) {
                                process.StartInfo.Arguments = $"-jar \"{Settings.toolPath}\" \"{downloadPath}\" \"{mineDir}\"";
                                process.Start();
                                while (!process.WaitForExit(100)) ;

                                if (process.ExitCode == 0) {
                                    colorA = Settings.installedA;
                                    colorB = Settings.installedB;
                                    textLabel.Text = $"{name}\nInstalled";
                                } else {
                                    MessageBox.Show($"An error occurred while installing {name}. Try after disable the auto install mode in the setting tab.\nExitCode: {process.ExitCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        } else {
                            process.StartInfo.Arguments = $"-jar \"{downloadPath}\"";
                            process.Start();
                        }

                    } else {
                        isDownloaded = false;
                        progress = 0;
                        textLabel.Text = name;
                        Update();
                        MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            HtmlDocument doc = webBrowser.Document;
            HtmlElement downloadEl = doc.GetElementById("Download");
            foreach (HtmlElement el in downloadEl.GetElementsByTagName("a")) {
                donwloadURL = el.GetAttribute("href");
                break;
            }

            isReady = true;
            textLabel.ForeColor = Color.FromArgb(240, 240, 240);

            if (File.Exists(downloadPath)) {
                isDownloaded = true;
                progress = 100;
                textLabel.Text = $"{name}\nDownloaded";
            }
        }

        private void download(string dURL) {
            Directory.CreateDirectory(Settings.path);
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(onDownload);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(onDownloadCompleted);
                client.DownloadFileAsync(new Uri(dURL), downloadPath);
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
                Brush b = new LinearGradientBrush(gradient_rectangle, colorA, colorB, 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
        }
    }
}
