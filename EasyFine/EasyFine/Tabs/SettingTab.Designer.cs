namespace EasyFine.Tabs {
    partial class SettingTab {
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFolder = new EasyFine.Link();
            this.mailLink = new EasyFine.Link();
            this.blogLink = new EasyFine.Link();
            this.gitLink = new EasyFine.Link();
            this.ytLink = new EasyFine.Link();
            this.tLink = new EasyFine.Link();
            this.dcLink = new EasyFine.Link();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.mailLink);
            this.flowLayoutPanel1.Controls.Add(this.blogLink);
            this.flowLayoutPanel1.Controls.Add(this.gitLink);
            this.flowLayoutPanel1.Controls.Add(this.ytLink);
            this.flowLayoutPanel1.Controls.Add(this.tLink);
            this.flowLayoutPanel1.Controls.Add(this.dcLink);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 327);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 40);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingTab_MouseMove);
            // 
            // openFolder
            // 
            this.openFolder.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(0)))));
            this.openFolder.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(3)))), ((int)(((byte)(58)))));
            this.openFolder.folder = true;
            this.openFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openFolder.image = null;
            this.openFolder.Location = new System.Drawing.Point(75, 229);
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
            this.mailLink.Location = new System.Drawing.Point(0, 0);
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
            this.blogLink.Location = new System.Drawing.Point(44, 0);
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
            this.gitLink.Location = new System.Drawing.Point(88, 0);
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
            this.ytLink.Location = new System.Drawing.Point(132, 0);
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
            this.tLink.Location = new System.Drawing.Point(176, 0);
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
            this.dcLink.Location = new System.Drawing.Point(220, 0);
            this.dcLink.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dcLink.Name = "dcLink";
            this.dcLink.Size = new System.Drawing.Size(40, 40);
            this.dcLink.TabIndex = 9;
            this.dcLink.URL = "https://discord.nitrostudio.dev";
            // 
            // SettingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "SettingTab";
            this.Size = new System.Drawing.Size(350, 370);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingTab_MouseMove);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Link mailLink;
        private Link blogLink;
        private Link gitLink;
        private Link ytLink;
        private Link tLink;
        private Link dcLink;
        private Link openFolder;
    }
}
