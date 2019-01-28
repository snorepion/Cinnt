namespace Cinnt
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.genTp = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.persTp = new System.Windows.Forms.TabPage();
            this.applyBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.uiFntBtn = new System.Windows.Forms.Button();
            this.modBtn = new System.Windows.Forms.Button();
            this.colorSelectLb = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.genTp.SuspendLayout();
            this.persTp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.genTp);
            this.tabControl1.Controls.Add(this.persTp);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 253);
            this.tabControl1.TabIndex = 0;
            // 
            // genTp
            // 
            this.genTp.Controls.Add(this.linkLabel2);
            this.genTp.Controls.Add(this.linkLabel1);
            this.genTp.Controls.Add(this.label1);
            this.genTp.Location = new System.Drawing.Point(4, 29);
            this.genTp.Name = "genTp";
            this.genTp.Padding = new System.Windows.Forms.Padding(3);
            this.genTp.Size = new System.Drawing.Size(469, 220);
            this.genTp.TabIndex = 0;
            this.genTp.Text = "General";
            this.genTp.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(5, 47);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(53, 20);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Github";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(5, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Report an issue";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version: Cinnt v1.0.0.0R";
            // 
            // persTp
            // 
            this.persTp.Controls.Add(this.applyBtn);
            this.persTp.Controls.Add(this.resetBtn);
            this.persTp.Controls.Add(this.uiFntBtn);
            this.persTp.Controls.Add(this.modBtn);
            this.persTp.Controls.Add(this.colorSelectLb);
            this.persTp.Location = new System.Drawing.Point(4, 29);
            this.persTp.Name = "persTp";
            this.persTp.Padding = new System.Windows.Forms.Padding(3);
            this.persTp.Size = new System.Drawing.Size(469, 220);
            this.persTp.TabIndex = 1;
            this.persTp.Text = "Personalization";
            this.persTp.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(391, 168);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(72, 43);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(391, 121);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(72, 41);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // uiFntBtn
            // 
            this.uiFntBtn.Location = new System.Drawing.Point(391, 62);
            this.uiFntBtn.Name = "uiFntBtn";
            this.uiFntBtn.Size = new System.Drawing.Size(72, 53);
            this.uiFntBtn.TabIndex = 2;
            this.uiFntBtn.Text = "Change UI Font";
            this.uiFntBtn.UseVisualStyleBackColor = true;
            this.uiFntBtn.Click += new System.EventHandler(this.uiFntBtn_Click);
            // 
            // modBtn
            // 
            this.modBtn.Location = new System.Drawing.Point(391, 7);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(72, 49);
            this.modBtn.TabIndex = 1;
            this.modBtn.Text = "Modify";
            this.modBtn.UseVisualStyleBackColor = true;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // colorSelectLb
            // 
            this.colorSelectLb.FormattingEnabled = true;
            this.colorSelectLb.ItemHeight = 20;
            this.colorSelectLb.Items.AddRange(new object[] {
            "Textbox background",
            "Textbox foreground",
            "Inactive button background",
            "Selected button background",
            "Active button background",
            "Button text color",
            "Window background",
            "Find and replace match color",
            "Status strip background"});
            this.colorSelectLb.Location = new System.Drawing.Point(4, 7);
            this.colorSelectLb.Name = "colorSelectLb";
            this.colorSelectLb.Size = new System.Drawing.Size(381, 204);
            this.colorSelectLb.TabIndex = 0;
            // 
            // Options
            // 
            this.AcceptButton = this.modBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 254);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Cinnt Options";
            this.tabControl1.ResumeLayout(false);
            this.genTp.ResumeLayout(false);
            this.genTp.PerformLayout();
            this.persTp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage genTp;
        private System.Windows.Forms.TabPage persTp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button uiFntBtn;
        private System.Windows.Forms.Button modBtn;
        private System.Windows.Forms.ListBox colorSelectLb;
    }
}