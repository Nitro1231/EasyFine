using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace EasyFine.Ctl {
    public partial class Toggle : UserControl {

        [Category("User")]
        public bool Toggled { get; set; } = false;

        [Category("User")]
        public Color ToggledOnColorA { get; set; } = Color.FromArgb(40, 242, 156);

        [Category("User")]
        public Color ToggledOnColorB { get; set; } = Color.FromArgb(12, 184, 224);

        [Category("User")]
        public Color ToggledOffColorA { get; set; } = Color.FromArgb(248, 88, 162);

        [Category("User")]
        public Color ToggledOffColorB { get; set; } = Color.FromArgb(254, 88, 92);

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks toggle.")]
        public event EventHandler UpdateSetting;

        public Toggle() {
            InitializeComponent();
            Utils.smoothBorder(this, Height);
            Utils.smoothBorder(togglePanel, togglePanel.Height);
        }

        private void togglePanel_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, togglePanel.Width, togglePanel.Height);

            Color colorA, colorB;
            if (Toggled) {
                colorA = ToggledOnColorA;
                colorB = ToggledOnColorB;
            } else {
                colorA = ToggledOffColorA;
                colorB = ToggledOffColorB;
            }

            Brush b = new LinearGradientBrush(gradient_rectangle, colorA, colorB, 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void Toggle_Click(object sender, EventArgs e) {
            Toggled = !Toggled;
            updateToggle();
        }

        public void updateToggle() {
            if (Toggled) {
                togglePanel.Left = Width - togglePanel.Width - 4;
            } else {
                togglePanel.Left = 4;
            }
            togglePanel.Refresh();
            UpdateSetting?.Invoke(this, null);
        }
    }
}
