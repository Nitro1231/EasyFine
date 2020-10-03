namespace EasyFine.Ctl {
    partial class Tab {
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
            this.textLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLable
            // 
            this.textLable.BackColor = System.Drawing.Color.Transparent;
            this.textLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLable.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textLable.Location = new System.Drawing.Point(0, 0);
            this.textLable.Name = "textLable";
            this.textLable.Size = new System.Drawing.Size(80, 40);
            this.textLable.TabIndex = 0;
            this.textLable.Text = "textLable";
            this.textLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textLable.Click += new System.EventHandler(this.textLable_Click);
            this.textLable.DoubleClick += new System.EventHandler(this.textLable_Click);
            // 
            // Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textLable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Name = "Tab";
            this.Size = new System.Drawing.Size(80, 40);
            this.Load += new System.EventHandler(this.Tab_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Link_Paint);
            this.Resize += new System.EventHandler(this.Tab_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textLable;
    }
}
