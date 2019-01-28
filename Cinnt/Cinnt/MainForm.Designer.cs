namespace Cinnt
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTb = new System.Windows.Forms.RichTextBox();
            this.Tt = new System.Windows.Forms.ToolTip(this.components);
            this.tbContainer2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.isolateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.changeCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.specialCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.covfefeizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRandomLettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMsgReporterLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.charCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wrdCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.parCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.argsTb = new System.Windows.Forms.TextBox();
            this.tbContainer2.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.statStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTb
            // 
            this.mainTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTb.DetectUrls = false;
            this.mainTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTb.Location = new System.Drawing.Point(4, 4);
            this.mainTb.Margin = new System.Windows.Forms.Padding(4);
            this.mainTb.Name = "mainTb";
            this.mainTb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.mainTb.Size = new System.Drawing.Size(666, 422);
            this.mainTb.TabIndex = 1;
            this.mainTb.Text = "";
            this.mainTb.WordWrap = false;
            this.mainTb.TextChanged += new System.EventHandler(this.WordCountUpdate);
            // 
            // tbContainer2
            // 
            this.tbContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContainer2.BackColor = System.Drawing.Color.White;
            this.tbContainer2.Controls.Add(this.button2);
            this.tbContainer2.Controls.Add(this.button1);
            this.tbContainer2.Controls.Add(this.mainTb);
            this.tbContainer2.Location = new System.Drawing.Point(16, 106);
            this.tbContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.tbContainer2.Name = "tbContainer2";
            this.tbContainer2.Size = new System.Drawing.Size(672, 429);
            this.tbContainer2.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(653, 423);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 6);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(653, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 9);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.encryptionConversionToolStripMenuItem,
            this.randomToolStripMenuItem,
            this.sortationToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(701, 28);
            this.mainMenu.TabIndex = 44;
            this.mainMenu.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.toolStripSeparator1,
            this.isolateToolStripMenuItem,
            this.subtractToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.removeLettersToolStripMenuItem,
            this.toolStripSeparator4,
            this.changeCaseToolStripMenuItem,
            this.toolStripSeparator2,
            this.specialCharactersToolStripMenuItem,
            this.toolStripSeparator5,
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.findToolStripMenuItem.Text = "&Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.Find);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.Replace);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // isolateToolStripMenuItem
            // 
            this.isolateToolStripMenuItem.Name = "isolateToolStripMenuItem";
            this.isolateToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.isolateToolStripMenuItem.Text = "&Isolate";
            this.isolateToolStripMenuItem.Click += new System.EventHandler(this.Isolate);
            // 
            // subtractToolStripMenuItem
            // 
            this.subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            this.subtractToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.subtractToolStripMenuItem.Text = "Sub&tract";
            this.subtractToolStripMenuItem.Click += new System.EventHandler(this.Subtract);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.insertToolStripMenuItem.Text = "Inse&rt";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.Insert);
            // 
            // removeLettersToolStripMenuItem
            // 
            this.removeLettersToolStripMenuItem.Name = "removeLettersToolStripMenuItem";
            this.removeLettersToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.removeLettersToolStripMenuItem.Text = "Remove letters";
            this.removeLettersToolStripMenuItem.Click += new System.EventHandler(this.RemoveLetters);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // changeCaseToolStripMenuItem
            // 
            this.changeCaseToolStripMenuItem.Name = "changeCaseToolStripMenuItem";
            this.changeCaseToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.changeCaseToolStripMenuItem.Text = "Change case";
            this.changeCaseToolStripMenuItem.Click += new System.EventHandler(this.CaseCtrl);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // specialCharactersToolStripMenuItem
            // 
            this.specialCharactersToolStripMenuItem.Name = "specialCharactersToolStripMenuItem";
            this.specialCharactersToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.specialCharactersToolStripMenuItem.Text = "S&pecial characters";
            this.specialCharactersToolStripMenuItem.Click += new System.EventHandler(this.UnicodeInsert);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(200, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.Revert);
            // 
            // encryptionConversionToolStripMenuItem
            // 
            this.encryptionConversionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem,
            this.hashToolStripMenuItem,
            this.generateKeyToolStripMenuItem,
            this.toolStripSeparator3,
            this.convertToolStripMenuItem});
            this.encryptionConversionToolStripMenuItem.Name = "encryptionConversionToolStripMenuItem";
            this.encryptionConversionToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.encryptionConversionToolStripMenuItem.Text = "Encryption / Conversion";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.Encrypt);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.Decrypt);
            // 
            // hashToolStripMenuItem
            // 
            this.hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            this.hashToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.hashToolStripMenuItem.Text = "Hash";
            // 
            // generateKeyToolStripMenuItem
            // 
            this.generateKeyToolStripMenuItem.Name = "generateKeyToolStripMenuItem";
            this.generateKeyToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.generateKeyToolStripMenuItem.Text = "Generate Key";
            this.generateKeyToolStripMenuItem.Click += new System.EventHandler(this.CreateKey);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.convertToolStripMenuItem.Text = "Convert";
            this.convertToolStripMenuItem.Click += new System.EventHandler(this.Format);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.covfefeizeToolStripMenuItem,
            this.addRandomLettersToolStripMenuItem});
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.randomToolStripMenuItem.Text = "Random";
            // 
            // covfefeizeToolStripMenuItem
            // 
            this.covfefeizeToolStripMenuItem.Name = "covfefeizeToolStripMenuItem";
            this.covfefeizeToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.covfefeizeToolStripMenuItem.Text = "C&ovfefeize";
            this.covfefeizeToolStripMenuItem.Click += new System.EventHandler(this.Covfefe);
            // 
            // addRandomLettersToolStripMenuItem
            // 
            this.addRandomLettersToolStripMenuItem.Name = "addRandomLettersToolStripMenuItem";
            this.addRandomLettersToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.addRandomLettersToolStripMenuItem.Text = "Add random letters";
            // 
            // sortationToolStripMenuItem
            // 
            this.sortationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.shuffleToolStripMenuItem,
            this.reverseToolStripMenuItem});
            this.sortationToolStripMenuItem.Name = "sortationToolStripMenuItem";
            this.sortationToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.sortationToolStripMenuItem.Text = "Sortation";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.sortToolStripMenuItem.Text = "&Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.Sort);
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.shuffleToolStripMenuItem.Text = "Shuff&le";
            this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.Shuffle);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.reverseToolStripMenuItem.Text = "Reverse";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.Reverse);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.windowToolStripMenuItem.Text = "Settings";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontChange);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.Options);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About);
            // 
            // tsMsgReporterLbl
            // 
            this.tsMsgReporterLbl.Name = "tsMsgReporterLbl";
            this.tsMsgReporterLbl.Size = new System.Drawing.Size(163, 20);
            this.tsMsgReporterLbl.Text = "No messages to report.";
            // 
            // tsSeprt1
            // 
            this.tsSeprt1.Name = "tsSeprt1";
            this.tsSeprt1.Size = new System.Drawing.Size(13, 20);
            this.tsSeprt1.Text = "|";
            // 
            // charCntLbl
            // 
            this.charCntLbl.Name = "charCntLbl";
            this.charCntLbl.Size = new System.Drawing.Size(93, 20);
            this.charCntLbl.Text = "Characters: 0";
            // 
            // tsSeprt2
            // 
            this.tsSeprt2.Name = "tsSeprt2";
            this.tsSeprt2.Size = new System.Drawing.Size(13, 20);
            this.tsSeprt2.Text = "|";
            // 
            // wrdCntLbl
            // 
            this.wrdCntLbl.Name = "wrdCntLbl";
            this.wrdCntLbl.Size = new System.Drawing.Size(66, 20);
            this.wrdCntLbl.Text = "Words: 0";
            // 
            // tsSeprt3
            // 
            this.tsSeprt3.Name = "tsSeprt3";
            this.tsSeprt3.Size = new System.Drawing.Size(13, 20);
            this.tsSeprt3.Text = "|";
            // 
            // parCntLbl
            // 
            this.parCntLbl.Name = "parCntLbl";
            this.parCntLbl.Size = new System.Drawing.Size(97, 20);
            this.parCntLbl.Text = "Paragraphs: 0";
            // 
            // statStrip
            // 
            this.statStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMsgReporterLbl,
            this.tsSeprt1,
            this.charCntLbl,
            this.tsSeprt2,
            this.wrdCntLbl,
            this.tsSeprt3,
            this.parCntLbl});
            this.statStrip.Location = new System.Drawing.Point(0, 552);
            this.statStrip.Name = "statStrip";
            this.statStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statStrip.Size = new System.Drawing.Size(701, 25);
            this.statStrip.TabIndex = 24;
            this.statStrip.Text = "statusStrip1";
            // 
            // argsTb
            // 
            this.argsTb.Location = new System.Drawing.Point(16, 40);
            this.argsTb.Name = "argsTb";
            this.argsTb.Size = new System.Drawing.Size(421, 22);
            this.argsTb.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 577);
            this.Controls.Add(this.argsTb);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.tbContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Cinnt";
            this.Load += new System.EventHandler(this.FrmLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tbContainer2.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainTb;
        private System.Windows.Forms.ToolTip Tt;
        private System.Windows.Forms.Panel tbContainer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem isolateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLettersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem covfefeizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRandomLettersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsMsgReporterLbl;
        private System.Windows.Forms.ToolStripStatusLabel tsSeprt1;
        private System.Windows.Forms.ToolStripStatusLabel charCntLbl;
        private System.Windows.Forms.ToolStripStatusLabel tsSeprt2;
        private System.Windows.Forms.ToolStripStatusLabel wrdCntLbl;
        private System.Windows.Forms.ToolStripStatusLabel tsSeprt3;
        private System.Windows.Forms.ToolStripStatusLabel parCntLbl;
        private System.Windows.Forms.StatusStrip statStrip;
        private System.Windows.Forms.TextBox argsTb;
        private System.Windows.Forms.ToolStripMenuItem generateKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem changeCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

