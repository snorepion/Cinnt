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
            this.enterIPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.tsMsgReporterLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.charCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wrdCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.parCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.argsTb = new System.Windows.Forms.TextBox();
            this.tbContainer1 = new System.Windows.Forms.Panel();
            this.formattingToolStrip = new System.Windows.Forms.ToolStrip();
            this.newBtn = new System.Windows.Forms.ToolStripButton();
            this.openBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.saveAsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.italicBtn = new System.Windows.Forms.ToolStripButton();
            this.boldBtn = new System.Windows.Forms.ToolStripButton();
            this.ulBtn = new System.Windows.Forms.ToolStripButton();
            this.colorBtn = new System.Windows.Forms.ToolStripButton();
            this.supBtn = new System.Windows.Forms.ToolStripButton();
            this.subBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.leftBtn = new System.Windows.Forms.ToolStripButton();
            this.centerBtn = new System.Windows.Forms.ToolStripButton();
            this.rightBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearFrmtBtn = new System.Windows.Forms.ToolStripButton();
            this.tbContainer2.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.statStrip.SuspendLayout();
            this.tbContainer1.SuspendLayout();
            this.formattingToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTb
            // 
            this.mainTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTb.BackColor = global::Cinnt.Properties.Settings.Default.tbBC;
            this.mainTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTb.DetectUrls = false;
            this.mainTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainTb.ForeColor = global::Cinnt.Properties.Settings.Default.tbFC;
            this.mainTb.Location = new System.Drawing.Point(4, 4);
            this.mainTb.Margin = new System.Windows.Forms.Padding(4);
            this.mainTb.Name = "mainTb";
            this.mainTb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.mainTb.Size = new System.Drawing.Size(662, 416);
            this.mainTb.TabIndex = 1;
            this.mainTb.Text = "";
            this.mainTb.WordWrap = global::Cinnt.Properties.Settings.Default.WordWrap;
            this.mainTb.TextChanged += new System.EventHandler(this.WordCountUpdate);
            // 
            // tbContainer2
            // 
            this.tbContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContainer2.BackColor = global::Cinnt.Properties.Settings.Default.tbBC;
            this.tbContainer2.Controls.Add(this.mainTb);
            this.tbContainer2.ForeColor = global::Cinnt.Properties.Settings.Default.tbFC;
            this.tbContainer2.Location = new System.Drawing.Point(16, 111);
            this.tbContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.tbContainer2.Name = "tbContainer2";
            this.tbContainer2.Size = new System.Drawing.Size(670, 424);
            this.tbContainer2.TabIndex = 38;
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
            this.editToolStripMenuItem.Text = global::Cinnt.Properties.Language.EditMenu;
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.findToolStripMenuItem.Text = global::Cinnt.Properties.Language.FindMenuItem;
            this.findToolStripMenuItem.Click += new System.EventHandler(this.Find);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.replaceToolStripMenuItem.Text = global::Cinnt.Properties.Language.ReplaceMenuItem;
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
            this.isolateToolStripMenuItem.Text = global::Cinnt.Properties.Language.IsolateMenuItem;
            this.isolateToolStripMenuItem.Click += new System.EventHandler(this.Isolate);
            // 
            // subtractToolStripMenuItem
            // 
            this.subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            this.subtractToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.subtractToolStripMenuItem.Text = global::Cinnt.Properties.Language.SubtractMenuItem;
            this.subtractToolStripMenuItem.Click += new System.EventHandler(this.Subtract);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.insertToolStripMenuItem.Text = global::Cinnt.Properties.Language.InsertMenuItem;
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.Insert);
            // 
            // removeLettersToolStripMenuItem
            // 
            this.removeLettersToolStripMenuItem.Name = "removeLettersToolStripMenuItem";
            this.removeLettersToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.removeLettersToolStripMenuItem.Text = global::Cinnt.Properties.Language.RemoveLettersMenuItem;
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
            this.changeCaseToolStripMenuItem.Text = global::Cinnt.Properties.Language.ChangeCaseMenuItem;
            this.changeCaseToolStripMenuItem.Click += new System.EventHandler(this.CaseCtrl);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // specialCharactersToolStripMenuItem
            // 
            this.specialCharactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterIPAToolStripMenuItem});
            this.specialCharactersToolStripMenuItem.Name = "specialCharactersToolStripMenuItem";
            this.specialCharactersToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.specialCharactersToolStripMenuItem.Text = global::Cinnt.Properties.Language.SpecialCharactersMenuItem;
            this.specialCharactersToolStripMenuItem.Click += new System.EventHandler(this.UnicodeInsert);
            // 
            // enterIPAToolStripMenuItem
            // 
            this.enterIPAToolStripMenuItem.Name = "enterIPAToolStripMenuItem";
            this.enterIPAToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.enterIPAToolStripMenuItem.Text = global::Cinnt.Properties.Language.EnterIpaMenuItem;
            this.enterIPAToolStripMenuItem.Click += new System.EventHandler(this.enterIPAToolStripMenuItem_Click);
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
            this.undoToolStripMenuItem.Text = global::Cinnt.Properties.Language.UndoMenuItem;
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.Revert);
            // 
            // encryptionConversionToolStripMenuItem
            // 
            this.encryptionConversionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hashToolStripMenuItem,
            this.convertToolStripMenuItem});
            this.encryptionConversionToolStripMenuItem.Name = "encryptionConversionToolStripMenuItem";
            this.encryptionConversionToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.encryptionConversionToolStripMenuItem.Text = global::Cinnt.Properties.Language.DataMenu;
            // 
            // hashToolStripMenuItem
            // 
            this.hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            this.hashToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.hashToolStripMenuItem.Text = global::Cinnt.Properties.Language.HashMenuItem;
            this.hashToolStripMenuItem.Click += new System.EventHandler(this.Hash);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
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
            this.covfefeizeToolStripMenuItem.Text = global::Cinnt.Properties.Language.CovfefeizeMenuItem;
            this.covfefeizeToolStripMenuItem.Click += new System.EventHandler(this.Covfefe);
            // 
            // addRandomLettersToolStripMenuItem
            // 
            this.addRandomLettersToolStripMenuItem.Name = "addRandomLettersToolStripMenuItem";
            this.addRandomLettersToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.addRandomLettersToolStripMenuItem.Text = global::Cinnt.Properties.Language.AddRandomLettersMenuItem;
            this.addRandomLettersToolStripMenuItem.Click += new System.EventHandler(this.Add);
            // 
            // sortationToolStripMenuItem
            // 
            this.sortationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.shuffleToolStripMenuItem,
            this.reverseToolStripMenuItem});
            this.sortationToolStripMenuItem.Name = "sortationToolStripMenuItem";
            this.sortationToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.sortationToolStripMenuItem.Text = global::Cinnt.Properties.Language.SortationMenu;
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.sortToolStripMenuItem.Text = global::Cinnt.Properties.Language.SortMenuItem;
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.Sort);
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.shuffleToolStripMenuItem.Text = global::Cinnt.Properties.Language.ShuffleMenuItem;
            this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.Shuffle);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.reverseToolStripMenuItem.Text = global::Cinnt.Properties.Language.ReverseMenuItem;
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
            this.windowToolStripMenuItem.Text = global::Cinnt.Properties.Language.SettingsMenu;
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.fontToolStripMenuItem.Text = global::Cinnt.Properties.Language.FontMenuItem;
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontChange);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.optionsToolStripMenuItem.Text = global::Cinnt.Properties.Language.OptionsMenuItem;
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.Options);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.aboutToolStripMenuItem.Text = global::Cinnt.Properties.Language.AboutMenuItem;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About);
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
            // argsTb
            // 
            this.argsTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.argsTb.BackColor = global::Cinnt.Properties.Settings.Default.tbBC;
            this.argsTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.argsTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.argsTb.ForeColor = global::Cinnt.Properties.Settings.Default.tbFC;
            this.argsTb.Location = new System.Drawing.Point(5, 11);
            this.argsTb.Name = "argsTb";
            this.argsTb.Size = new System.Drawing.Size(660, 20);
            this.argsTb.TabIndex = 0;
            // 
            // tbContainer1
            // 
            this.tbContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContainer1.BackColor = global::Cinnt.Properties.Settings.Default.tbBC;
            this.tbContainer1.Controls.Add(this.argsTb);
            this.tbContainer1.Location = new System.Drawing.Point(16, 63);
            this.tbContainer1.Name = "tbContainer1";
            this.tbContainer1.Size = new System.Drawing.Size(670, 42);
            this.tbContainer1.TabIndex = 45;
            // 
            // formattingToolStrip
            // 
            this.formattingToolStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.formattingToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.formattingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBtn,
            this.openBtn,
            this.saveBtn,
            this.saveAsBtn,
            this.toolStripSeparator7,
            this.italicBtn,
            this.boldBtn,
            this.ulBtn,
            this.colorBtn,
            this.supBtn,
            this.subBtn,
            this.toolStripSeparator6,
            this.leftBtn,
            this.centerBtn,
            this.rightBtn,
            this.toolStripSeparator3,
            this.clearFrmtBtn});
            this.formattingToolStrip.Location = new System.Drawing.Point(0, 28);
            this.formattingToolStrip.Name = "formattingToolStrip";
            this.formattingToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.formattingToolStrip.Size = new System.Drawing.Size(701, 31);
            this.formattingToolStrip.TabIndex = 46;
            // 
            // newBtn
            // 
            this.newBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newBtn.Image = global::Cinnt.Properties.Resources._new;
            this.newBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(28, 28);
            this.newBtn.ToolTipText = "New file";
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openBtn.Image = global::Cinnt.Properties.Resources.open;
            this.openBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(28, 28);
            this.openBtn.ToolTipText = "Open file";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Image = global::Cinnt.Properties.Resources.save;
            this.saveBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(28, 28);
            this.saveBtn.ToolTipText = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsBtn.Image = global::Cinnt.Properties.Resources.save_as;
            this.saveAsBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(28, 28);
            this.saveAsBtn.ToolTipText = "Save file with a different name";
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // italicBtn
            // 
            this.italicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicBtn.Image = global::Cinnt.Properties.Resources.italic;
            this.italicBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(28, 28);
            this.italicBtn.ToolTipText = "Italicize text";
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // boldBtn
            // 
            this.boldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldBtn.Image = global::Cinnt.Properties.Resources.bold;
            this.boldBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(28, 28);
            this.boldBtn.ToolTipText = "Bold text";
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // ulBtn
            // 
            this.ulBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ulBtn.Image = global::Cinnt.Properties.Resources.ul;
            this.ulBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.ulBtn.Name = "ulBtn";
            this.ulBtn.Size = new System.Drawing.Size(28, 28);
            this.ulBtn.ToolTipText = "Underline text";
            this.ulBtn.Click += new System.EventHandler(this.ulBtn_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorBtn.Image = global::Cinnt.Properties.Resources.color;
            this.colorBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(28, 28);
            this.colorBtn.ToolTipText = "Change text color";
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // supBtn
            // 
            this.supBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supBtn.Image = global::Cinnt.Properties.Resources.sup;
            this.supBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.supBtn.Name = "supBtn";
            this.supBtn.Size = new System.Drawing.Size(28, 28);
            this.supBtn.ToolTipText = "Superscript";
            this.supBtn.Click += new System.EventHandler(this.supBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subBtn.Image = global::Cinnt.Properties.Resources.sub;
            this.subBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(28, 28);
            this.subBtn.ToolTipText = "Subscript";
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // leftBtn
            // 
            this.leftBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftBtn.Image = global::Cinnt.Properties.Resources.left;
            this.leftBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(28, 28);
            this.leftBtn.ToolTipText = "Left align";
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // centerBtn
            // 
            this.centerBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centerBtn.Image = global::Cinnt.Properties.Resources.center;
            this.centerBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.centerBtn.Name = "centerBtn";
            this.centerBtn.Size = new System.Drawing.Size(28, 28);
            this.centerBtn.ToolTipText = "Center text";
            this.centerBtn.Click += new System.EventHandler(this.centerBtn_Click);
            // 
            // rightBtn
            // 
            this.rightBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightBtn.Image = global::Cinnt.Properties.Resources.right;
            this.rightBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(28, 28);
            this.rightBtn.ToolTipText = "Right align";
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // clearFrmtBtn
            // 
            this.clearFrmtBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearFrmtBtn.Image = global::Cinnt.Properties.Resources.clear;
            this.clearFrmtBtn.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearFrmtBtn.Name = "clearFrmtBtn";
            this.clearFrmtBtn.Size = new System.Drawing.Size(28, 28);
            this.clearFrmtBtn.ToolTipText = "Clear formatting";
            this.clearFrmtBtn.Click += new System.EventHandler(this.clearFrmtBtn_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 577);
            this.Controls.Add(this.formattingToolStrip);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.tbContainer2);
            this.Controls.Add(this.tbContainer1);
            this.Font = global::Cinnt.Properties.Settings.Default.def_fnt;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
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
            this.tbContainer1.ResumeLayout(false);
            this.tbContainer1.PerformLayout();
            this.formattingToolStrip.ResumeLayout(false);
            this.formattingToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainTb;
        private System.Windows.Forms.ToolTip Tt;
        private System.Windows.Forms.Panel tbContainer2;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem isolateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionConversionToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem changeCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Panel tbContainer1;
        private System.Windows.Forms.ToolStrip formattingToolStrip;
        private System.Windows.Forms.ToolStripButton italicBtn;
        private System.Windows.Forms.ToolStripButton boldBtn;
        private System.Windows.Forms.ToolStripButton ulBtn;
        private System.Windows.Forms.ToolStripButton supBtn;
        private System.Windows.Forms.ToolStripButton subBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton leftBtn;
        private System.Windows.Forms.ToolStripButton centerBtn;
        private System.Windows.Forms.ToolStripButton rightBtn;
        private System.Windows.Forms.ToolStripButton newBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton openBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton saveAsBtn;
        private System.Windows.Forms.ToolStripButton colorBtn;
        private System.Windows.Forms.ToolStripButton clearFrmtBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem enterIPAToolStripMenuItem;
    }
}

