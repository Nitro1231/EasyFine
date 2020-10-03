using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace EasyFine.Ctl {
    public partial class Tab : UserControl {

        [Category("User")]
        public string ButtonText { get; set; } = "tab";

        [Category("User")]
        public bool Clicked { get; set; } = false;

        [Category("User")]
        public int Index { get; set; } = 0;

        [Category("User")]
        public Color Color1 { get; set; } = Color.FromArgb(248, 88, 162);

        [Category("User")]
        public Color Color2 { get; set; } = Color.FromArgb(254, 88, 92);

        [Category("User")]
        public Color IdleColor { get; set; } = Color.FromArgb(30, 30, 30);

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler TabClick;

        public Tab() {
            InitializeComponent();
            Utils.smoothBorder(this, Height);
        }

        private void Tab_Load(object sender, EventArgs e) {
            textLable.Text = ButtonText;
            BackColor = IdleColor;
            if (Clicked) {
                Width = textLable.Text.Length * 10 + 40;
            } else {
                Width = textLable.Text.Length * 10 + 20;
            }
        }

        private void Tab_Resize(object sender, EventArgs e) {
            Utils.smoothBorder(this, Height);
        }

        private void textLable_Click(object sender, EventArgs e) {
            Settings.tabIndex = Index;
            Width = textLable.Text.Length * 10 + 40;
            Clicked = true;
            Refresh();
            TabClick?.Invoke(this, e);
        }

        public void disable() {
            Clicked = false;
            Width = textLable.Text.Length * 10 + 20;
            Refresh();
        }

        private void Link_Paint(object sender, PaintEventArgs e) {
            if (Clicked) {
                Graphics graphics = e.Graphics;
                Rectangle rectangle = new Rectangle(0, 0, Width, Height);
                Brush brush = new LinearGradientBrush(rectangle, Color1, Color2, 65f);
                graphics.FillRectangle(brush, rectangle);
            }
        }
    }
}
