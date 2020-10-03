namespace EasyFine.Ctl {
    partial class Toggle {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.togglePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // togglePanel
            // 
            this.togglePanel.Location = new System.Drawing.Point(4, 4);
            this.togglePanel.Name = "togglePanel";
            this.togglePanel.Size = new System.Drawing.Size(18, 18);
            this.togglePanel.TabIndex = 0;
            this.togglePanel.Click += new System.EventHandler(this.Toggle_Click);
            this.togglePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.togglePanel_Paint);
            this.togglePanel.DoubleClick += new System.EventHandler(this.Toggle_Click);
            // 
            // Toggle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.togglePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Toggle";
            this.Size = new System.Drawing.Size(52, 26);
            this.Click += new System.EventHandler(this.Toggle_Click);
            this.DoubleClick += new System.EventHandler(this.Toggle_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel togglePanel;
    }
}
