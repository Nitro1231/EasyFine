// By Nitro
// Ver: v1.0

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using EasyFine.Ctl;
using EasyFine.Tabs;

namespace EasyFine {
    public partial class Main : Form {

        EasyFineTab easyFineTab;
        SettingTab settingTab;

        public Main() {
            InitializeComponent();
            Settings.mainHandle = Handle;
            Settings.checkUpdate();
            Settings.readSetting();

            Utils.smoothBorder(minPanel, minPanel.Width);
            Utils.smoothBorder(exitPanel, exitPanel.Width);
            Utils.smoothBorder(this, 30);
            Utils.smoothBorder(mainPanel, 30);
            Directory.CreateDirectory(Settings.path);

            SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            easyFineTab = new EasyFineTab();
            settingTab = new SettingTab();
            settingTab.Visible = false;
            mainTabPanel.Controls.Add(easyFineTab);
            mainTabPanel.Controls.Add(settingTab);
        }

        private void tab_TabClick(object sender, EventArgs e) {
            foreach (Tab t in tabPanel.Controls)
                if (t.Index != Settings.tabIndex)
                    t.disable();

            easyFineTab.Visible = false;
            settingTab.Visible = false;

            switch (Settings.tabIndex) {
                case 0:
                    easyFineTab.Visible = true;
                    break;
                case 1:
                    settingTab.Visible = true;
                    break;
            }    
        }

        private void Main_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Handle);
        }

        private void minPanel_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void exitPanel_Click(object sender, EventArgs e) {
            Close();
        }

        private void Main_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, label1.Height + 20);
            Brush b = new LinearGradientBrush(gradient_rectangle, Settings.themeA, Settings.themeB, 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
