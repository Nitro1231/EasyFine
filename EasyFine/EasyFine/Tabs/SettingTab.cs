using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace EasyFine.Tabs {
    public partial class SettingTab : UserControl {
        public SettingTab() {
            InitializeComponent();
            linkPanel.Left = (Width - linkPanel.Width) / 2;
            openFolder.URL = Settings.path + "\\OptiFine";
            openFolder.image = IconChar.FolderOpen.ToBitmap(40, Color.White);
            mailLink.image = IconChar.At.ToBitmap(40, Color.White);
            blogLink.image = IconChar.PaperPlane.ToBitmap(40, Color.White);
            gitLink.image = IconChar.Github.ToBitmap(40, Color.White);
            ytLink.image = IconChar.Youtube.ToBitmap(40, Color.White);
            tLink.image = IconChar.Twitter.ToBitmap(40, Color.White);
            dcLink.image = IconChar.Discord.ToBitmap(40, Color.White);

            previewToggle.Toggled = Settings.showPreview;
            autoInstallToggle.Toggled = Settings.useEasyFineAuto;
            previewToggle.updateToggle();
            autoInstallToggle.updateToggle();

            if (Settings.newVersion == null) {
                updateImg.Image = IconChar.TimesCircle.ToBitmap(updateImg.Height, Color.OrangeRed);
                updateLabel.Text = "Cannot check update.";
            } else if (Settings.version.Equals(Settings.newVersion)) {
                updateImg.Image = IconChar.CheckCircle.ToBitmap(updateImg.Height, Color.LimeGreen);
                updateLabel.Text = "EasyFine is up to date!";
            } else {
                updateImg.Image = IconChar.ExclamationTriangle.ToBitmap(updateImg.Height, Color.Orange);
                updateLabel.Text = "New update is available.";
            }

            verLabel.Text += Settings.version;
            newVerLabel.Text += Settings.newVersion;
        }

        private void previewToggle_UpdateSetting(object sender, EventArgs e) {
            Settings.showPreview = previewToggle.Toggled;
            Settings.reloadList = true;
            Settings.writeSetting();
        }

        private void autoInstallToggle_UpdateSetting(object sender, EventArgs e) {
            Settings.useEasyFineAuto = autoInstallToggle.Toggled;
            Settings.writeSetting();
        }

        private void updateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/Nitro1231/EasyFine/releases");
        }

        private void SettingTab_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Settings.mainHandle);
        }
    }
}
