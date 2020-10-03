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
            this.minPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainTabPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tab1 = new EasyFine.Ctl.Tab();
            this.tab2 = new EasyFine.Ctl.Tab();
            this.mainPanel.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // minPanel
            // 
            this.minPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.minPanel.Location = new System.Drawing.Point(317, 12);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(18, 18);
            this.minPanel.TabIndex = 1;
            this.minPanel.Click += new System.EventHandler(this.minPanel_Click);
            this.minPanel.DoubleClick += new System.EventHandler(this.minPanel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "EasyFine";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // exitPanel
            // 
            this.exitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.exitPanel.Location = new System.Drawing.Point(340, 12);
            this.exitPanel.Margin = new System.Windows.Forms.Padding(2);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(18, 18);
            this.exitPanel.TabIndex = 0;
            this.exitPanel.Click += new System.EventHandler(this.exitPanel_Click);
            this.exitPanel.DoubleClick += new System.EventHandler(this.exitPanel_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainPanel.Controls.Add(this.mainTabPanel);
            this.mainPanel.Controls.Add(this.tabPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(370, 440);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // mainTabPanel
            // 
            this.mainTabPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabPanel.Location = new System.Drawing.Point(0, 56);
            this.mainTabPanel.Name = "mainTabPanel";
            this.mainTabPanel.Size = new System.Drawing.Size(370, 384);
            this.mainTabPanel.TabIndex = 2;
            this.mainTabPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tab1);
            this.tabPanel.Controls.Add(this.tab2);
            this.tabPanel.Location = new System.Drawing.Point(10, 10);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(256, 40);
            this.tabPanel.TabIndex = 1;
            this.tabPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tab1.ButtonText = "EasyFine";
            this.tab1.Clicked = true;
            this.tab1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(242)))), ((int)(((byte)(156)))));
            this.tab1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(184)))), ((int)(((byte)(224)))));
            this.tab1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tab1.Index = 0;
            this.tab1.Location = new System.Drawing.Point(10, 0);
            this.tab1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(120, 40);
            this.tab1.TabIndex = 0;
            this.tab1.TabClick += new System.EventHandler(this.tab_TabClick);
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tab2.ButtonText = "Setting";
            this.tab2.Clicked = false;
            this.tab2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(88)))), ((int)(((byte)(162)))));
            this.tab2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(92)))));
            this.tab2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tab2.Index = 1;
            this.tab2.Location = new System.Drawing.Point(140, 0);
            this.tab2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(90, 40);
            this.tab2.TabIndex = 1;
            this.tab2.TabClick += new System.EventHandler(this.tab_TabClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(370, 540);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.minPanel);
            this.Controls.Add(this.exitPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "EasyFine";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.mainPanel.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel minPanel;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.FlowLayoutPanel tabPanel;
        private Ctl.Tab tab1;
        private Ctl.Tab tab2;
        private System.Windows.Forms.FlowLayoutPanel mainTabPanel;
    }
}

