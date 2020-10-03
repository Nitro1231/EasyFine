namespace EasyFine.Tabs {
    partial class EasyFineTab {
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
            this.itemBox = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // itemBox
            // 
            this.itemBox.AutoScroll = true;
            this.itemBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.itemBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemBox.Location = new System.Drawing.Point(0, 0);
            this.itemBox.Margin = new System.Windows.Forms.Padding(5);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(350, 370);
            this.itemBox.TabIndex = 0;
            this.itemBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.itemBox_MouseMove);
            // 
            // EasyFineTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.itemBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "EasyFineTab";
            this.Size = new System.Drawing.Size(350, 370);
            this.VisibleChanged += new System.EventHandler(this.EasyFineTab_VisibleChanged);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel itemBox;
    }
}
