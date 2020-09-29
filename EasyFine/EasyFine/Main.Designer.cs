namespace EasyFine {
    partial class Main {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.topPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.itemBox = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.topPanel.Controls.Add(this.minPanel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.exitPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(380, 60);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // minPanel
            // 
            this.minPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.minPanel.Location = new System.Drawing.Point(334, 5);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(18, 18);
            this.minPanel.TabIndex = 1;
            this.minPanel.Click += new System.EventHandler(this.minPanel_Click);
            this.minPanel.DoubleClick += new System.EventHandler(this.minPanel_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "EasyFine";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // exitPanel
            // 
            this.exitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.exitPanel.Location = new System.Drawing.Point(357, 5);
            this.exitPanel.Margin = new System.Windows.Forms.Padding(2);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(18, 18);
            this.exitPanel.TabIndex = 0;
            this.exitPanel.Click += new System.EventHandler(this.exitPanel_Click);
            this.exitPanel.DoubleClick += new System.EventHandler(this.exitPanel_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mainPanel.Controls.Add(this.itemBox);
            this.mainPanel.Location = new System.Drawing.Point(10, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(360, 440);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // itemBox
            // 
            this.itemBox.AutoScroll = true;
            this.itemBox.Location = new System.Drawing.Point(5, 20);
            this.itemBox.Margin = new System.Windows.Forms.Padding(5);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(350, 415);
            this.itemBox.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(380, 500);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "EasyFine";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.topPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel minPanel;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.FlowLayoutPanel itemBox;
    }
}

