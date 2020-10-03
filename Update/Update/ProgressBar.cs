using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Update {
    public partial class ProgressBar : UserControl {

        [Category("User")]
        public int Value { get; set; } = 50;

        [Category("User")]
        public int Min { get; set; } = 0;

        [Category("User")]
        public int Max { get; set; } = 100;

        [Category("User")]
        public Color ColorA { get; set; } = Color.FromArgb(40, 242, 156);

        [Category("User")]
        public Color ColorB { get; set; } = Color.FromArgb(12, 184, 224);

        [Category("User")]
        public string Label {
            get { return pLabel.Text; }
            set { pLabel.Text = value; }
        }

        public ProgressBar() {
            InitializeComponent();
        }

        private void ProgressBar_Paint(object sender, PaintEventArgs e) {
            int v = (int)Math.Round((double)Width / (Max - Min) * Value);
            if (v != 0) {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, v, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, ColorA, ColorB, 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
        }
    }
}
