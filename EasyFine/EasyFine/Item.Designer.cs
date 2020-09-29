namespace EasyFine {
    partial class Item {
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.sidePanel.Location = new System.Drawing.Point(5, 5);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(5, 50);
            this.sidePanel.TabIndex = 0;
            // 
            // progressPanel
            // 
            this.progressPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressPanel.Location = new System.Drawing.Point(0, 55);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(325, 5);
            this.progressPanel.TabIndex = 1;
            this.progressPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.progressPanel_Paint);
            // 
            // textLabel
            // 
            this.textLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textLabel.Location = new System.Drawing.Point(0, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(325, 60);
            this.textLabel.TabIndex = 2;
            this.textLabel.Text = "Text";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textLabel.Click += new System.EventHandler(this.textLabel_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.textLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Name = "Item";
            this.Size = new System.Drawing.Size(325, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Label textLabel;
    }
}
