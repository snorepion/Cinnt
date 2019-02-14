using Cinnt;
using Cinnt.Properties;
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
            this.localizSelBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.alphabetCb = new System.Windows.Forms.ComboBox();
            this.alphTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxLetterNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.wordWrapCb = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.maxLetterNud)).BeginInit();
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
            this.genTp.Controls.Add(this.localizSelBtn);
            this.genTp.Controls.Add(this.label4);
            this.genTp.Controls.Add(this.alphabetCb);
            this.genTp.Controls.Add(this.alphTb);
            this.genTp.Controls.Add(this.label3);
            this.genTp.Controls.Add(this.maxLetterNud);
            this.genTp.Controls.Add(this.label2);
            this.genTp.Controls.Add(this.wordWrapCb);
            this.genTp.Controls.Add(this.linkLabel2);
            this.genTp.Controls.Add(this.linkLabel1);
            this.genTp.Controls.Add(this.label1);
            this.genTp.Location = new System.Drawing.Point(4, 29);
            this.genTp.Name = "genTp";
            this.genTp.Padding = new System.Windows.Forms.Padding(3);
            this.genTp.Size = new System.Drawing.Size(469, 220);
            this.genTp.TabIndex = 0;
            this.genTp.Text = global::Cinnt.Properties.Language.SettingsGeneralTab;
            this.genTp.UseVisualStyleBackColor = true;
            // 
            // localizSelBtn
            // 
            this.localizSelBtn.Location = new System.Drawing.Point(315, 4);
            this.localizSelBtn.Name = "localizSelBtn";
            this.localizSelBtn.Size = new System.Drawing.Size(143, 28);
            this.localizSelBtn.TabIndex = 10;
            this.localizSelBtn.Text = global::Cinnt.Properties.Language.SettingsLocalizationSelect;
            this.localizSelBtn.UseVisualStyleBackColor = true;
            this.localizSelBtn.Click += new System.EventHandler(this.localizSelBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Localization:";
            // 
            // alphabetCb
            // 
            this.alphabetCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alphabetCb.FormattingEnabled = true;
            this.alphabetCb.Items.AddRange(new object[] {
            "26-letter Latin",
            "26-letter Latin (with capitals)",
            "Russian Cyrillic",
            "Russian Cyrillic (with capitals)",
            "Arabic (Standard)",
            "Devanagari",
            "Japanese (hiragana)",
            "Japanese (katakana)",
            "Japanese (hiragana+katakana)",
            "Syriac",
            "Armenian",
            "Armenian (with capitals)",
            "Georgian (mkhedruli)",
            "Ge\'ez",
            "Cree",
            "Inuktitut",
            "Cherokee",
            "Greek",
            "Greek (with capitals)",
            "Mandaic",
            "Vai"});
            this.alphabetCb.Location = new System.Drawing.Point(280, 183);
            this.alphabetCb.Name = "alphabetCb";
            this.alphabetCb.Size = new System.Drawing.Size(178, 28);
            this.alphabetCb.TabIndex = 8;
            this.alphabetCb.SelectedIndexChanged += new System.EventHandler(this.alphabetCb_SelectedIndexChanged);
            // 
            // alphTb
            // 
            this.alphTb.Location = new System.Drawing.Point(84, 128);
            this.alphTb.Multiline = true;
            this.alphTb.Name = "alphTb";
            this.alphTb.Size = new System.Drawing.Size(374, 49);
            this.alphTb.TabIndex = 7;
            this.alphTb.Text = "abcdefghijklmnopqrstuvwxyz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alphabet";
            // 
            // maxLetterNud
            // 
            this.maxLetterNud.Location = new System.Drawing.Point(148, 95);
            this.maxLetterNud.Maximum = new decimal(new int[] {
            5242880,
            0,
            0,
            0});
            this.maxLetterNud.Name = "maxLetterNud";
            this.maxLetterNud.Size = new System.Drawing.Size(122, 27);
            this.maxLetterNud.TabIndex = 5;
            this.maxLetterNud.Value = new decimal(new int[] {
            5242880,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max letters (/1024)";
            // 
            // wordWrapCb
            // 
            this.wordWrapCb.AutoSize = true;
            this.wordWrapCb.Location = new System.Drawing.Point(9, 70);
            this.wordWrapCb.Name = "wordWrapCb";
            this.wordWrapCb.Size = new System.Drawing.Size(104, 24);
            this.wordWrapCb.TabIndex = 3;
            this.wordWrapCb.Text = global::Cinnt.Properties.Language.SettingsWordWrapCheckBox;
            this.wordWrapCb.UseVisualStyleBackColor = true;
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
            this.persTp.Text = global::Cinnt.Properties.Language.SettingsPersonalTab;
            this.persTp.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(391, 168);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(72, 43);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = global::Cinnt.Properties.Language.SettingsApply;
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(391, 121);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(72, 41);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = global::Cinnt.Properties.Language.SettingsReset;
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // uiFntBtn
            // 
            this.uiFntBtn.Location = new System.Drawing.Point(391, 62);
            this.uiFntBtn.Name = "uiFntBtn";
            this.uiFntBtn.Size = new System.Drawing.Size(72, 53);
            this.uiFntBtn.TabIndex = 2;
            this.uiFntBtn.Text = global::Cinnt.Properties.Language.SettingsChangeUIFont;
            this.uiFntBtn.UseVisualStyleBackColor = true;
            this.uiFntBtn.Click += new System.EventHandler(this.uiFntBtn_Click);
            // 
            // modBtn
            // 
            this.modBtn.Location = new System.Drawing.Point(391, 7);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(72, 49);
            this.modBtn.TabIndex = 1;
            this.modBtn.Text = global::Cinnt.Properties.Language.SettingsModify;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.genTp.ResumeLayout(false);
            this.genTp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLetterNud)).EndInit();
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
        private System.Windows.Forms.NumericUpDown maxLetterNud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox wordWrapCb;
        private System.Windows.Forms.ComboBox alphabetCb;
        private System.Windows.Forms.TextBox alphTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button localizSelBtn;
        private System.Windows.Forms.Label label4;
    }
}