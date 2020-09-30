// By Nitro
// Ver: v1.0

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace EasyFine {
    public partial class Main : Form {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\NitroStudio\EasyFine";
        WebBrowser webBrowser = new WebBrowser();

        public Main() {
            InitializeComponent();
            Utils.smoothBorder(minPanel, minPanel.Width);
            Utils.smoothBorder(exitPanel, exitPanel.Width);
            Directory.CreateDirectory(path);

            flowLayoutPanel1.Left = (mainPanel.Width - flowLayoutPanel1.Width) / 2;
            openFolder.URL = path;
            openFolder.image = IconChar.FolderOpen.ToBitmap(40, Color.White);
            mailLink.image = IconChar.At.ToBitmap(40, Color.White);
            blogLink.image = IconChar.PaperPlane.ToBitmap(40, Color.White);
            gitLink.image = IconChar.Github.ToBitmap(40, Color.White);
            ytLink.image = IconChar.Youtube.ToBitmap(40, Color.White);
            tLink.image = IconChar.Twitter.ToBitmap(40, Color.White);
            dcLink.image = IconChar.Discord.ToBitmap(40, Color.White);

            SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(getOptiFine);
            webBrowser.Navigate("https://www.optifine.net/downloads");
        }

        private void getOptiFine(object sender, WebBrowserDocumentCompletedEventArgs e) {
            HtmlDocument doc = webBrowser.Document;
            HtmlElementCollection tr = doc.GetElementsByTagName("tr");

            foreach (HtmlElement td in tr) {
                if (td.GetAttribute("className") == "downloadLineFirst") {
                    string name = null, url = null;
                    foreach (HtmlElement el in td.GetElementsByTagName("td")) {
                        if (el.GetAttribute("className") == "downloadLineFileFirst")
                            name = el.InnerText;

                        if (el.GetAttribute("className") == "downloadLineMirror")
                            foreach (HtmlElement a in el.GetElementsByTagName("a"))
                                url = a.GetAttribute("href");
                    }

                    if (name != null && url != null) {
                        Item item = new Item(name, url);
                        itemBox.Controls.Add(item);
                    }
                }
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

        private void mainPanel_Paint(object sender, PaintEventArgs e) {
            Rectangle rectangle = new Rectangle(0, 0, mainPanel.Width, 20);
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(rectangle, Color.FromArgb(255, Color.FromArgb(5, 5, 5)), Color.FromArgb(1, Color.FromArgb(25, 25, 25)), 90))
                e.Graphics.FillRectangle(gradientBrush, rectangle);
        }
    }
}
