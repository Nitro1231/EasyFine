namespace Update {
    partial class ProgressBar {
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
            this.pLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pLabel
            // 
            this.pLabel.BackColor = System.Drawing.Color.Transparent;
            this.pLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pLabel.Location = new System.Drawing.Point(0, 0);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(300, 25);
            this.pLabel.TabIndex = 0;
            this.pLabel.Text = "text";
            this.pLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProgressBar";
            this.Size = new System.Drawing.Size(300, 25);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgressBar_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pLabel;
    }
}
