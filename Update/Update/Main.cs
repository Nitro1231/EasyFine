using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Update {
    public partial class Main : Form {
        string path = "";
        bool updated = false;

        public Main(string[] args) {
            InitializeComponent();
            Utils.smoothBorder(this, 20);
            Utils.smoothBorder(updateProgressBar, 10);
            Utils.smoothBorder(minPanel, minPanel.Width);
            Utils.smoothBorder(exitPanel, exitPanel.Width);

            if (args.Length < 5) {
                MessageBox.Show("Auto Update Failed. Please manually update the program.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                updateLabel.Text = "Update Failed.";
                updated = true;
            } else {
                string name = args[0];
                int pid = Convert.ToInt32(args[1]);
                string currentVer = args[2];
                string newVer = args[3];
                string downloadURL = args[4];
                path = args[5];

                cVerLabel.Text += $"{name} {currentVer}";
                nVerLabel.Text += $"{name} {newVer}";

                Process process = Process.GetProcessById(pid);
                updateLabel.Text = "Waiting for the process to exit.";
                while (!process.WaitForExit(100));

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
                updateLabel.Text = "Update Finished";
                Process.Start(path);
                updated = true;
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
