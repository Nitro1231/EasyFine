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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.topPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.itemBox = new System.Windows.Forms.FlowLayoutPanel();
            this.openFolder = new EasyFine.Link();
            this.mailLink = new EasyFine.Link();
            this.blogLink = new EasyFine.Link();
            this.gitLink = new EasyFine.Link();
            this.ytLink = new EasyFine.Link();
            this.tLink = new EasyFine.Link();
            this.dcLink = new EasyFine.Link();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.topPanel.Controls.Add(this.minPanel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.exitPanel);
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(835, 60);
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
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
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = global::EasyFine.Properties.Resources.EasyFineLogo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainPanel.Controls.Add(this.flowLayoutPanel1);
            this.mainPanel.Controls.Add(this.itemBox);
            this.mainPanel.Location = new System.Drawing.Point(5, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(370, 440);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.openFolder);
            this.flowLayoutPanel1.Controls.Add(this.mailLink);
            this.flowLayoutPanel1.Controls.Add(this.blogLink);
            this.flowLayoutPanel1.Controls.Add(this.gitLink);
            this.flowLayoutPanel1.Controls.Add(this.ytLink);
            this.flowLayoutPanel1.Controls.Add(this.tLink);
            this.flowLayoutPanel1.Controls.Add(this.dcLink);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 395);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // itemBox
            // 
            this.itemBox.AutoScroll = true;
            this.itemBox.Location = new System.Drawing.Point(10, 20);
            this.itemBox.Margin = new System.Windows.Forms.Padding(5);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(350, 370);
            this.itemBox.TabIndex = 0;
            this.itemBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // openFolder
            // 
            this.openFolder.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(0)))));
            this.openFolder.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(3)))), ((int)(((byte)(58)))));
            this.openFolder.folder = true;
            this.openFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openFolder.image = null;
            this.openFolder.Location = new System.Drawing.Point(3, 0);
            this.openFolder.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(80, 40);
            this.openFolder.TabIndex = 3;
            this.openFolder.URL = "";
            // 
            // mailLink
            // 
            this.mailLink.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(46)))));
            this.mailLink.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.mailLink.folder = false;
            this.mailLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mailLink.image = null;
            this.mailLink.Location = new System.Drawing.Point(87, 0);
            this.mailLink.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mailLink.Name = "mailLink";
            this.mailLink.Size = new System.Drawing.Size(40, 40);
            this.mailLink.TabIndex = 4;
            this.mailLink.URL = "mailto::admin@nitrostudio.dev";
            // 
            // blogLink
            // 
            this.blogLink.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(224)))), ((int)(((byte)(95)))));
            this.blogLink.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(171)))), ((int)(((byte)(151)))));
            this.blogLink.folder = false;
            this.blogLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.blogLink.image = null;
            this.blogLink.Location = new System.Drawing.Point(131, 0);
            this.blogLink.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.blogLink.Name = "blogLink";
            this.blogLink.Size = new System.Drawing.Size(40, 40);
            this.blogLink.TabIndex = 5;
            this.blogLink.URL = "http://blog.nitrostudio.dev";
            // 
            // gitLink
            // 
            this.gitLink.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(242)))), ((int)(((byte)(156)))));
            this.gitLink.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(184)))), ((int)(((byte)(224)))));
            this.gitLink.folder = false;
            this.gitLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gitLink.image = null;
            this.gitLink.Location = new System.Drawing.Point(175, 0);
            this.gitLink.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.gitLink.Name = "gitLink";
            this.gitLink.Size = new System.Drawing.Size(40, 40);
            this.gitLink.TabIndex = 6;
            this.gitLink.URL = "https://github.nitrostudio.dev";
            // 
            // ytLink
            // 
            this.ytLink.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ytLink.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(171)))));
            this.ytLink.folder = false;
            this.ytLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ytLink.image = null;
            this.ytLink.Location = new System.Drawing.Point(219, 0);
            this.ytLink.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.ytLink.Name = "ytLink";
            this.ytLink.Size = new System.Drawing.Size(40, 40);
            this.ytLink.TabIndex = 7;
            this.ytLink.URL = "https://youtube.nitrostudio.dev";
            // 
            // tLink
            // 
            this.tLink.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(88)))), ((int)(((byte)(162)))));
            this.tLink.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(92)))));
            this.tLink.folder = false;
            this.tLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tLink.image = null;
            this.tLink.Location = new System.Drawing.Point(263, 0);
            this.tLink.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.tLink.Name = "tLink";
            this.tLink.Size = new System.Drawing.Size(40, 40);
            this.tLink.TabIndex = 8;
            this.tLink.URL = "https://twitter.nitrostudio.dev";
            // 
            // dcLink
            // 
            this.dcLink.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.dcLink.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.dcLink.folder = false;
            this.dcLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dcLink.image = null;
            this.dcLink.Location = new System.Drawing.Point(307, 0);
            this.dcLink.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dcLink.Name = "dcLink";
            this.dcLink.Size = new System.Drawing.Size(40, 40);
            this.dcLink.TabIndex = 9;
            this.dcLink.URL = "https://discord.nitrostudio.dev";
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "EasyFine";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel minPanel;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.FlowLayoutPanel itemBox;
        private System.Windows.Forms.PictureBox logo;
        private Link openFolder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Link mailLink;
        private Link blogLink;
        private Link gitLink;
        private Link ytLink;
        private Link tLink;
        private Link dcLink;
    }
}

