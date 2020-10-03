using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace EasyFine.Tabs {
    public partial class SettingTab : UserControl {
        public SettingTab() {
            InitializeComponent();

            flowLayoutPanel1.Left = (Width - flowLayoutPanel1.Width) / 2;
            openFolder.URL = Settings.path;
            openFolder.image = IconChar.FolderOpen.ToBitmap(40, Color.White);
            mailLink.image = IconChar.At.ToBitmap(40, Color.White);
            blogLink.image = IconChar.PaperPlane.ToBitmap(40, Color.White);
            gitLink.image = IconChar.Github.ToBitmap(40, Color.White);
            ytLink.image = IconChar.Youtube.ToBitmap(40, Color.White);
            tLink.image = IconChar.Twitter.ToBitmap(40, Color.White);
            dcLink.image = IconChar.Discord.ToBitmap(40, Color.White);
        }

        private void SettingTab_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Settings.mainHandle);
        }
    }
}
