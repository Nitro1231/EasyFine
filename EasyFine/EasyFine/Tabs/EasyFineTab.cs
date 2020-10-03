using System.Windows.Forms;

namespace EasyFine.Tabs {
    public partial class EasyFineTab : UserControl {
        WebBrowser webBrowser = new WebBrowser();
        public EasyFineTab() {
            InitializeComponent();
        }

        private void EasyFineTab_Load(object sender, System.EventArgs e) {
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(getOptiFine);
            webBrowser.Navigate("https://www.optifine.net/downloads");
        }

        private void getOptiFine(object sender, WebBrowserDocumentCompletedEventArgs e) {
            HtmlDocument doc = webBrowser.Document;
            HtmlElementCollection tr = doc.GetElementsByTagName("tr");

            foreach (HtmlElement td in tr) {
                if (td.GetAttribute("className").Contains("downloadLine")) {
                    string name = null, url = null;
                    foreach (HtmlElement el in td.GetElementsByTagName("td")) {
                        if (el.GetAttribute("className") == "colMirror") {
                            foreach (HtmlElement a in el.GetElementsByTagName("a")) {
                                string link = a.GetAttribute("href");
                                if (!Settings.showPreview) {
                                    if (link.Contains("preview"))
                                        break;
                                }
                                name = link.Substring(link.IndexOf("?f=") + "?f=".Length).Replace("preview_", "").Replace("_", " ").Replace(".jar", "");
                                url = a.GetAttribute("href");
                            }
                        }
                    }

                    if (name != null && url != null) {
                        Item item = new Item(name, url);
                        itemBox.Controls.Add(item);
                    }
                }
            }
        }

        private void itemBox_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Settings.mainHandle);
        }
    }
}
