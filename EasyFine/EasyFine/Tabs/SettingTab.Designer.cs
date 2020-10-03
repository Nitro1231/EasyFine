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
            this.linkPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateImg = new System.Windows.Forms.PictureBox();
            this.updateLabel = new System.Windows.Forms.Label();
            this.updateLink = new System.Windows.Forms.LinkLabel();
            this.verLabel = new System.Windows.Forms.Label();
            this.newVerLabel = new System.Windows.Forms.Label();
            this.autoInstallToggle = new EasyFine.Ctl.Toggle();
            this.previewToggle = new EasyFine.Ctl.Toggle();
            this.openFolder = new EasyFine.Link();
            this.mailLink = new EasyFine.Link();
            this.blogLink = new EasyFine.Link();
            this.gitLink = new EasyFine.Link();
            this.ytLink = new EasyFine.Link();
            this.tLink = new EasyFine.Link();
            this.dcLink = new EasyFine.Link();
            this.linkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateImg)).BeginInit();
            this.SuspendLayout();
            // 
            // linkPanel
            // 
            this.linkPanel.Controls.Add(this.mailLink);
            this.linkPanel.Controls.Add(this.blogLink);
            this.linkPanel.Controls.Add(this.gitLink);
            this.linkPanel.Controls.Add(this.ytLink);
            this.linkPanel.Controls.Add(this.tLink);
            this.linkPanel.Controls.Add(this.dcLink);
            this.linkPanel.Location = new System.Drawing.Point(75, 327);
            this.linkPanel.Name = "linkPanel";
            this.linkPanel.Size = new System.Drawing.Size(263, 40);
            this.linkPanel.TabIndex = 2;
            this.linkPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingTab_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Display preview version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Auto install:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Update:";
            // 
            // updateImg
            // 
            this.updateImg.Location = new System.Drawing.Point(79, 71);
            this.updateImg.Name = "updateImg";
            this.updateImg.Size = new System.Drawing.Size(28, 28);
            this.updateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.updateImg.TabIndex = 9;
            this.updateImg.TabStop = false;
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.updateLabel.Location = new System.Drawing.Point(113, 72);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(175, 21);
            this.updateLabel.TabIndex = 10;
            this.updateLabel.Text = "Checking new updates...";
            // 
            // updateLink
            // 
            this.updateLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(242)))), ((int)(((byte)(156)))));
            this.updateLink.AutoSize = true;
            this.updateLink.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.updateLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(184)))), ((int)(((byte)(224)))));
            this.updateLink.Location = new System.Drawing.Point(10, 150);
            this.updateLink.Name = "updateLink";
            this.updateLink.Size = new System.Drawing.Size(321, 21);
            this.updateLink.TabIndex = 11;
            this.updateLink.TabStop = true;
            this.updateLink.Text = "Check and Update a new version of EasyFine.\r\n";
            this.updateLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.updateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateLink_LinkClicked);
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verLabel.Location = new System.Drawing.Point(10, 102);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(126, 21);
            this.verLabel.TabIndex = 12;
            this.verLabel.Text = "Current Version: ";
            // 
            // newVerLabel
            // 
            this.newVerLabel.AutoSize = true;
            this.newVerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVerLabel.Location = new System.Drawing.Point(10, 126);
            this.newVerLabel.Name = "newVerLabel";
            this.newVerLabel.Size = new System.Drawing.Size(105, 21);
            this.newVerLabel.TabIndex = 13;
            this.newVerLabel.Text = "New Version: ";
            // 
            // autoInstallToggle
            // 
            this.autoInstallToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.autoInstallToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoInstallToggle.Location = new System.Drawing.Point(107, 37);
            this.autoInstallToggle.Name = "autoInstallToggle";
            this.autoInstallToggle.Size = new System.Drawing.Size(52, 26);
            this.autoInstallToggle.TabIndex = 7;
            this.autoInstallToggle.Toggled = false;
            this.autoInstallToggle.ToggledOffColorA = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(88)))), ((int)(((byte)(162)))));
            this.autoInstallToggle.ToggledOffColorB = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(92)))));
            this.autoInstallToggle.ToggledOnColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(242)))), ((int)(((byte)(156)))));
            this.autoInstallToggle.ToggledOnColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(184)))), ((int)(((byte)(224)))));
            this.autoInstallToggle.UpdateSetting += new System.EventHandler(this.autoInstallToggle_UpdateSetting);
            // 
            // previewToggle
            // 
            this.previewToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.previewToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewToggle.Location = new System.Drawing.Point(194, 9);
            this.previewToggle.Name = "previewToggle";
            this.previewToggle.Size = new System.Drawing.Size(52, 26);
            this.previewToggle.TabIndex = 4;
            this.previewToggle.Toggled = false;
            this.previewToggle.ToggledOffColorA = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(88)))), ((int)(((byte)(162)))));
            this.previewToggle.ToggledOffColorB = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(92)))));
            this.previewToggle.ToggledOnColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(242)))), ((int)(((byte)(156)))));
            this.previewToggle.ToggledOnColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(184)))), ((int)(((byte)(224)))));
            this.previewToggle.UpdateSetting += new System.EventHandler(this.previewToggle_UpdateSetting);
            // 
            // openFolder
            // 
            this.openFolder.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(0)))));
            this.openFolder.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(3)))), ((int)(((byte)(58)))));
            this.openFolder.folder = true;
            this.openFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openFolder.image = null;
            this.openFolder.Location = new System.Drawing.Point(14, 181);
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
            this.Controls.Add(this.newVerLabel);
            this.Controls.Add(this.verLabel);
            this.Controls.Add(this.updateLink);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.updateImg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.autoInstallToggle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewToggle);
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.linkPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "SettingTab";
            this.Size = new System.Drawing.Size(350, 370);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingTab_MouseMove);
            this.linkPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updateImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel linkPanel;
        private Link mailLink;
        private Link blogLink;
        private Link gitLink;
        private Link ytLink;
        private Link tLink;
        private Link dcLink;
        private Link openFolder;
        private Ctl.Toggle previewToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Ctl.Toggle autoInstallToggle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox updateImg;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.LinkLabel updateLink;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.Label newVerLabel;
    }
}
