namespace Update {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.cVerLabel = new System.Windows.Forms.Label();
            this.nVerLabel = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.updateProgressBar = new Update.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auto Update";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // cVerLabel
            // 
            this.cVerLabel.AutoSize = true;
            this.cVerLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cVerLabel.Location = new System.Drawing.Point(13, 46);
            this.cVerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.cVerLabel.Name = "cVerLabel";
            this.cVerLabel.Size = new System.Drawing.Size(105, 17);
            this.cVerLabel.TabIndex = 2;
            this.cVerLabel.Text = "Current Version: ";
            this.cVerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // nVerLabel
            // 
            this.nVerLabel.AutoSize = true;
            this.nVerLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nVerLabel.Location = new System.Drawing.Point(13, 67);
            this.nVerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nVerLabel.Name = "nVerLabel";
            this.nVerLabel.Size = new System.Drawing.Size(88, 17);
            this.nVerLabel.TabIndex = 3;
            this.nVerLabel.Text = "New Version: ";
            this.nVerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // updateLabel
            // 
            this.updateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.Location = new System.Drawing.Point(16, 89);
            this.updateLabel.Margin = new System.Windows.Forms.Padding(3);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(391, 20);
            this.updateLabel.TabIndex = 4;
            this.updateLabel.Text = "Updating...";
            this.updateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // exitPanel
            // 
            this.exitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.exitPanel.Location = new System.Drawing.Point(394, 8);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(18, 18);
            this.exitPanel.TabIndex = 5;
            this.exitPanel.Click += new System.EventHandler(this.exitPanel_Click);
            this.exitPanel.DoubleClick += new System.EventHandler(this.exitPanel_Click);
            // 
            // minPanel
            // 
            this.minPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.minPanel.Location = new System.Drawing.Point(370, 8);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(18, 18);
            this.minPanel.TabIndex = 6;
            this.minPanel.Click += new System.EventHandler(this.minPanel_Click);
            this.minPanel.DoubleClick += new System.EventHandler(this.minPanel_Click);
            // 
            // updateProgressBar
            // 
            this.updateProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.updateProgressBar.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(242)))), ((int)(((byte)(156)))));
            this.updateProgressBar.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(184)))), ((int)(((byte)(224)))));
            this.updateProgressBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProgressBar.Label = "";
            this.updateProgressBar.Location = new System.Drawing.Point(10, 115);
            this.updateProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.updateProgressBar.Max = 100;
            this.updateProgressBar.Min = 0;
            this.updateProgressBar.Name = "updateProgressBar";
            this.updateProgressBar.Size = new System.Drawing.Size(400, 25);
            this.updateProgressBar.TabIndex = 0;
            this.updateProgressBar.Value = 0;
            this.updateProgressBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(420, 150);
            this.Controls.Add(this.minPanel);
            this.Controls.Add(this.exitPanel);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.nVerLabel);
            this.Controls.Add(this.cVerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateProgressBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar updateProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cVerLabel;
        private System.Windows.Forms.Label nVerLabel;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.Panel minPanel;
    }
}

