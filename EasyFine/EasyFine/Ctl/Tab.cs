using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace EasyFine.Ctl {
    public partial class Tab : UserControl {

        [Category("User")]
        public string text { get; set; } = "tab";

        [Category("User")]
        public bool clicked { get; set; } = false;

        [Category("User")]
        public Color Color1 { get; set; } = Color.FromArgb(248, 88, 162);

        [Category("User")]
        public Color Color2 { get; set; } = Color.FromArgb(254, 88, 92);

        public Tab() {
            InitializeComponent();
            Utils.smoothBorder(this, Height);
        }

        private void Tab_Resize(object sender, EventArgs e) {
            Utils.smoothBorder(this, Height);
        }

        private void Link_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            Brush brush = new LinearGradientBrush(rectangle, Color1, Color2, 65f);
            graphics.FillRectangle(brush, rectangle);
        }
    }
}
