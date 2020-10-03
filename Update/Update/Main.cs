using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Update {
    public partial class Main : Form {
        string name, pid, currentVer, newVer, downloadURL, path;
        bool updated = false;

        public Main(string[] args) {
            InitializeComponent();
            Utils.smoothBorder(this, 20);
            Utils.smoothBorder(updateProgressBar, 10);
            Utils.smoothBorder(minPanel, minPanel.Width);
            Utils.smoothBorder(exitPanel, exitPanel.Width);
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            if (args.Length < 7) {
                MessageBox.Show("Auto Update Failed. Please manually update the program.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                updateLabel.Text = "Update Failed.";
                updated = true;
            } else {
                name = args[1];
                pid = args[2];
                currentVer = args[3];
                newVer = args[4];
                downloadURL = args[5];
                path = args[6];
            }
        }

        private void Main_Load(object sender, EventArgs e) {
            Visible = true;
            Update();
            Refresh();
            if (!updated) {
                cVerLabel.Text += $"{name} {currentVer}";
                nVerLabel.Text += $"{name} {newVer}";

                try {
                    Process process = Process.GetProcessById(Convert.ToInt32(pid));
                    updateLabel.Text = "Waiting for the process to exit.";
                    while (!process.WaitForExit(100));
                    Thread.Sleep(500);
                } catch {

                }

                if (File.Exists(path)) {
                    File.Delete(path);
                }
                download(downloadURL, path);
            }
        }

        private void download(string URL, string path) {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(onDownload);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(onDownloadCompleted);
                client.DownloadFileAsync(new Uri(URL), path);
            });
            thread.Start();
        }

        void onDownload(object sender, DownloadProgressChangedEventArgs e) {
            BeginInvoke((MethodInvoker)delegate {
                double mbIn = double.Parse(e.BytesReceived.ToString()) / 1024 / 1024;
                double totalMB = double.Parse(e.TotalBytesToReceive.ToString()) / 1024 / 1024;
                int percentage = (int)Math.Round(mbIn / totalMB * 100);
                updateLabel.Text = $"Downloaded {Math.Round(mbIn, 2)}MB of {Math.Round(totalMB, 2)}MB ({percentage}%)";
                updateProgressBar.Value = percentage;
                updateProgressBar.Label = $"{percentage}%";
                Update();
            });
        }

        void onDownloadCompleted(object sender, AsyncCompletedEventArgs e) {
            BeginInvoke((MethodInvoker)delegate {
                updated = true;
                updateLabel.Text = "Update Finished";
                Thread.Sleep(1000);
                Process.Start(path);
                Close();
            });
        }

        private void minPanel_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void exitPanel_Click(object sender, EventArgs e) {
            if (updated) {
                Close();
            }
        }

        private void Main_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Handle);
        }
    }
}
