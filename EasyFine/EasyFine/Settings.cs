using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace EasyFine {
    class Settings {
        static public string version = "1.0.0";
        static public string newVersion = null;

        static public string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\NitroStudio\EasyFine";
        static public string toolPath = path + @"\Tool\EasyFineAuto.jar";
        static public bool useEasyFineAuto = true;
        static public bool showPreview = false;
        static public bool reloadList = true;
        static public int tabIndex = 0;
        static public IntPtr mainHandle;

        static public Color themeA = ColorTranslator.FromHtml("#28F29C");
        static public Color themeB = ColorTranslator.FromHtml("#0CB8E0");
        static public Color downloadA = ColorTranslator.FromHtml("#4ADEDE");
        static public Color downloadB = ColorTranslator.FromHtml("#787FF6");
        static public Color installedA = ColorTranslator.FromHtml("#FF6CAB");
        static public Color installedB = ColorTranslator.FromHtml("#7366FF");

        static public void installTool() {
            Directory.CreateDirectory(path + @"\Tool");
            File.WriteAllBytes(toolPath, Properties.Resources.EasyFineAuto);
        }

        static public string getMinecraftDir() {
            string mineDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft";
            if (!Directory.Exists(mineDir)) {
                MessageBox.Show($"Cannot find the Minecraft directory. Please install the Minecraft first, or change the Minecraft directory from the setting tab. \nCurrent directory: {mineDir}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            } else {
                return mineDir;
            }
        }

        static public void readSetting() {
            if (File.Exists(path + @"\config.ini")) {
                var Myini = new IniFile(path + @"\config.ini");

                if (Myini.KeyExists("Preview"))
                    showPreview = Convert.ToBoolean(Myini.Read("Preview"));
                else
                    Myini.Write("Preview", showPreview.ToString());

                if (Myini.KeyExists("AutoInstall"))
                    useEasyFineAuto = Convert.ToBoolean(Myini.Read("AutoInstall"));
                else
                    Myini.Write("AutoInstall", useEasyFineAuto.ToString());

            } else {
                writeSetting();
            }
        }

        static public void writeSetting() {
            var Myini = new IniFile(path + @"\config.ini");
            Myini.Write("Preview", showPreview.ToString());
            Myini.Write("AutoInstall", useEasyFineAuto.ToString());
        }

        static public void checkUpdate() {
            try {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                using (WebClient client = new WebClient()) {
                    string ver = client.DownloadString("https://raw.githubusercontent.com/Nitro1231/EasyFine/master/ver.txt");
                    newVersion = ver;
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
