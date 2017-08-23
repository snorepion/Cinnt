namespace Cinnt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTb = new System.Windows.Forms.TextBox();
            this.covfefeBtn = new System.Windows.Forms.Button();
            this.garbleBtn = new System.Windows.Forms.Button();
            this.degarbleBtn = new System.Windows.Forms.Button();
            this.removeLttrBtn = new System.Windows.Forms.Button();
            this.lttrCntTb = new System.Windows.Forms.TextBox();
            this.addRandBtn = new System.Windows.Forms.Button();
            this.isoBtn = new System.Windows.Forms.Button();
            this.sbtrctBtn = new System.Windows.Forms.Button();
            this.insBtn = new System.Windows.Forms.Button();
            this.insTb1 = new System.Windows.Forms.TextBox();
            this.insTb2 = new System.Windows.Forms.TextBox();
            this.isoTb = new System.Windows.Forms.TextBox();
            this.sbtrctTb = new System.Windows.Forms.TextBox();
            this.garbleDictBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.frmtCombox1 = new System.Windows.Forms.ComboBox();
            this.frmtCombox2 = new System.Windows.Forms.ComboBox();
            this.caseCtrlBtn = new System.Windows.Forms.Button();
            this.caseCtrlCombox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMsgReporterLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.charCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wrdCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.frmtBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.fontBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTb
            // 
            this.mainTb.Location = new System.Drawing.Point(13, 13);
            this.mainTb.MaxLength = 33554432;
            this.mainTb.Multiline = true;
            this.mainTb.Name = "mainTb";
            this.mainTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTb.Size = new System.Drawing.Size(398, 273);
            this.mainTb.TabIndex = 0;
            this.mainTb.TextChanged += new System.EventHandler(this.wrdCntUpdate);
            // 
            // covfefeBtn
            // 
            this.covfefeBtn.Location = new System.Drawing.Point(417, 13);
            this.covfefeBtn.Name = "covfefeBtn";
            this.covfefeBtn.Size = new System.Drawing.Size(96, 23);
            this.covfefeBtn.TabIndex = 1;
            this.covfefeBtn.Text = "Covfefeize";
            this.toolTip1.SetToolTip(this.covfefeBtn, "Makes a string like the word \"covfefe\" based on your input.");
            this.covfefeBtn.UseVisualStyleBackColor = true;
            this.covfefeBtn.Click += new System.EventHandler(this.covfefeBtn_Click);
            // 
            // garbleBtn
            // 
            this.garbleBtn.Location = new System.Drawing.Point(417, 42);
            this.garbleBtn.Name = "garbleBtn";
            this.garbleBtn.Size = new System.Drawing.Size(96, 55);
            this.garbleBtn.TabIndex = 3;
            this.garbleBtn.Text = "Garble (only restores on this PC)";
            this.toolTip1.SetToolTip(this.garbleBtn, "Randomize characters, which are saved to this PC\'s installation of Cinnt.");
            this.garbleBtn.UseVisualStyleBackColor = true;
            this.garbleBtn.Click += new System.EventHandler(this.garbleBtn_Click);
            // 
            // degarbleBtn
            // 
            this.degarbleBtn.Location = new System.Drawing.Point(417, 177);
            this.degarbleBtn.Name = "degarbleBtn";
            this.degarbleBtn.Size = new System.Drawing.Size(96, 41);
            this.degarbleBtn.TabIndex = 4;
            this.degarbleBtn.Text = "Restore from Garble";
            this.toolTip1.SetToolTip(this.degarbleBtn, "Restore from garbled text.");
            this.degarbleBtn.UseVisualStyleBackColor = true;
            this.degarbleBtn.Click += new System.EventHandler(this.ungarbleBtn_Click);
            // 
            // removeLttrBtn
            // 
            this.removeLttrBtn.Location = new System.Drawing.Point(417, 224);
            this.removeLttrBtn.Name = "removeLttrBtn";
            this.removeLttrBtn.Size = new System.Drawing.Size(96, 23);
            this.removeLttrBtn.TabIndex = 5;
            this.removeLttrBtn.Text = "Remove Letters";
            this.toolTip1.SetToolTip(this.removeLttrBtn, "Remove letters from the beginning of a string.");
            this.removeLttrBtn.UseVisualStyleBackColor = true;
            this.removeLttrBtn.Click += new System.EventHandler(this.removeLttrBtn_Click);
            // 
            // lttrCntTb
            // 
            this.lttrCntTb.Location = new System.Drawing.Point(417, 253);
            this.lttrCntTb.Name = "lttrCntTb";
            this.lttrCntTb.Size = new System.Drawing.Size(96, 20);
            this.lttrCntTb.TabIndex = 6;
            this.lttrCntTb.Text = "How many letters?";
            this.lttrCntTb.Enter += new System.EventHandler(this.lttrCntTb_Erase);
            this.lttrCntTb.Leave += new System.EventHandler(this.lttrCntTb_Watermark);
            // 
            // addRandBtn
            // 
            this.addRandBtn.Location = new System.Drawing.Point(417, 279);
            this.addRandBtn.Name = "addRandBtn";
            this.addRandBtn.Size = new System.Drawing.Size(96, 34);
            this.addRandBtn.TabIndex = 7;
            this.addRandBtn.Text = "Add Rand. Letters";
            this.toolTip1.SetToolTip(this.addRandBtn, "Add random letters to the end of a string.");
            this.addRandBtn.UseVisualStyleBackColor = true;
            this.addRandBtn.Click += new System.EventHandler(this.addRandBtn_Click);
            // 
            // isoBtn
            // 
            this.isoBtn.Location = new System.Drawing.Point(13, 294);
            this.isoBtn.Name = "isoBtn";
            this.isoBtn.Size = new System.Drawing.Size(75, 21);
            this.isoBtn.TabIndex = 8;
            this.isoBtn.Text = "Isolate";
            this.toolTip1.SetToolTip(this.isoBtn, "Locate specific string(s) and take out everything else.");
            this.isoBtn.UseVisualStyleBackColor = true;
            this.isoBtn.Click += new System.EventHandler(this.isoBtn_Click);
            // 
            // sbtrctBtn
            // 
            this.sbtrctBtn.Location = new System.Drawing.Point(94, 294);
            this.sbtrctBtn.Name = "sbtrctBtn";
            this.sbtrctBtn.Size = new System.Drawing.Size(75, 21);
            this.sbtrctBtn.TabIndex = 9;
            this.sbtrctBtn.Text = "Subtract";
            this.toolTip1.SetToolTip(this.sbtrctBtn, "Take out specific strings and keep everything else.");
            this.sbtrctBtn.UseVisualStyleBackColor = true;
            this.sbtrctBtn.Click += new System.EventHandler(this.sbtrctBtn_Click);
            // 
            // insBtn
            // 
            this.insBtn.Location = new System.Drawing.Point(175, 294);
            this.insBtn.Name = "insBtn";
            this.insBtn.Size = new System.Drawing.Size(75, 21);
            this.insBtn.TabIndex = 10;
            this.insBtn.Text = "Insert";
            this.toolTip1.SetToolTip(this.insBtn, "Add a certain string after another string, specified by you.");
            this.insBtn.UseVisualStyleBackColor = true;
            this.insBtn.Click += new System.EventHandler(this.insBtn_Click);
            // 
            // insTb1
            // 
            this.insTb1.Location = new System.Drawing.Point(175, 320);
            this.insTb1.Name = "insTb1";
            this.insTb1.Size = new System.Drawing.Size(75, 20);
            this.insTb1.TabIndex = 11;
            this.insTb1.Text = "Where to insert?";
            this.toolTip1.SetToolTip(this.insTb1, resources.GetString("insTb1.ToolTip"));
            // 
            // insTb2
            // 
            this.insTb2.Location = new System.Drawing.Point(175, 346);
            this.insTb2.Name = "insTb2";
            this.insTb2.Size = new System.Drawing.Size(75, 20);
            this.insTb2.TabIndex = 12;
            this.insTb2.Text = "What to insert?";
            // 
            // isoTb
            // 
            this.isoTb.Location = new System.Drawing.Point(13, 320);
            this.isoTb.Name = "isoTb";
            this.isoTb.Size = new System.Drawing.Size(75, 20);
            this.isoTb.TabIndex = 13;
            this.isoTb.Text = "Isolate what?";
            // 
            // sbtrctTb
            // 
            this.sbtrctTb.Location = new System.Drawing.Point(94, 320);
            this.sbtrctTb.Name = "sbtrctTb";
            this.sbtrctTb.Size = new System.Drawing.Size(75, 20);
            this.sbtrctTb.TabIndex = 14;
            this.sbtrctTb.Text = "Subtract what?";
            // 
            // garbleDictBtn
            // 
            this.garbleDictBtn.Location = new System.Drawing.Point(418, 103);
            this.garbleDictBtn.Name = "garbleDictBtn";
            this.garbleDictBtn.Size = new System.Drawing.Size(96, 41);
            this.garbleDictBtn.TabIndex = 21;
            this.garbleDictBtn.Text = "Export Garble Dict.";
            this.toolTip1.SetToolTip(this.garbleDictBtn, "Allow other PCs to degarble your strings.");
            this.garbleDictBtn.UseVisualStyleBackColor = true;
            // 
            // frmtCombox1
            // 
            this.frmtCombox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frmtCombox1.FormattingEnabled = true;
            this.frmtCombox1.Items.AddRange(new object[] {
            "Hexadecimal",
            "Binary",
            "Text"});
            this.frmtCombox1.Location = new System.Drawing.Point(337, 319);
            this.frmtCombox1.Name = "frmtCombox1";
            this.frmtCombox1.Size = new System.Drawing.Size(74, 21);
            this.frmtCombox1.TabIndex = 26;
            this.toolTip1.SetToolTip(this.frmtCombox1, "Base type - can convert from hex, binary, string");
            // 
            // frmtCombox2
            // 
            this.frmtCombox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frmtCombox2.FormattingEnabled = true;
            this.frmtCombox2.Items.AddRange(new object[] {
            "Hexadecimal",
            "Binary",
            "Text"});
            this.frmtCombox2.Location = new System.Drawing.Point(337, 345);
            this.frmtCombox2.Name = "frmtCombox2";
            this.frmtCombox2.Size = new System.Drawing.Size(74, 21);
            this.frmtCombox2.TabIndex = 27;
            this.toolTip1.SetToolTip(this.frmtCombox2, "Base type - can convert from hex, binary, string");
            // 
            // caseCtrlBtn
            // 
            this.caseCtrlBtn.Location = new System.Drawing.Point(256, 294);
            this.caseCtrlBtn.Name = "caseCtrlBtn";
            this.caseCtrlBtn.Size = new System.Drawing.Size(75, 21);
            this.caseCtrlBtn.TabIndex = 22;
            this.caseCtrlBtn.Text = "Case Ctrl";
            this.caseCtrlBtn.UseVisualStyleBackColor = true;
            this.caseCtrlBtn.Click += new System.EventHandler(this.caseCtrlBtn_Click);
            // 
            // caseCtrlCombox
            // 
            this.caseCtrlCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caseCtrlCombox.FormattingEnabled = true;
            this.caseCtrlCombox.Items.AddRange(new object[] {
            "Capital",
            "Lower",
            "Sentence",
            "Reverse Sentence",
            "Alternating",
            "Word Alternating"});
            this.caseCtrlCombox.Location = new System.Drawing.Point(256, 319);
            this.caseCtrlCombox.Name = "caseCtrlCombox";
            this.caseCtrlCombox.Size = new System.Drawing.Size(75, 21);
            this.caseCtrlCombox.TabIndex = 23;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMsgReporterLbl,
            this.tsSeprt1,
            this.charCntLbl,
            this.tsSeprt2,
            this.wrdCntLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(526, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsMsgReporterLbl
            // 
            this.tsMsgReporterLbl.Name = "tsMsgReporterLbl";
            this.tsMsgReporterLbl.Size = new System.Drawing.Size(129, 17);
            this.tsMsgReporterLbl.Text = "No messages to report.";
            // 
            // tsSeprt1
            // 
            this.tsSeprt1.Name = "tsSeprt1";
            this.tsSeprt1.Size = new System.Drawing.Size(10, 17);
            this.tsSeprt1.Text = "|";
            // 
            // charCntLbl
            // 
            this.charCntLbl.Name = "charCntLbl";
            this.charCntLbl.Size = new System.Drawing.Size(75, 17);
            this.charCntLbl.Text = "Characters: 0";
            // 
            // tsSeprt2
            // 
            this.tsSeprt2.Name = "tsSeprt2";
            this.tsSeprt2.Size = new System.Drawing.Size(10, 17);
            this.tsSeprt2.Text = "|";
            // 
            // wrdCntLbl
            // 
            this.wrdCntLbl.Name = "wrdCntLbl";
            this.wrdCntLbl.Size = new System.Drawing.Size(53, 17);
            this.wrdCntLbl.Text = "Words: 0";
            // 
            // frmtBtn
            // 
            this.frmtBtn.Location = new System.Drawing.Point(336, 294);
            this.frmtBtn.Name = "frmtBtn";
            this.frmtBtn.Size = new System.Drawing.Size(75, 21);
            this.frmtBtn.TabIndex = 25;
            this.frmtBtn.Text = "Format";
            this.frmtBtn.UseVisualStyleBackColor = true;
            this.frmtBtn.Click += new System.EventHandler(this.frmtBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(417, 345);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(96, 21);
            this.aboutBtn.TabIndex = 28;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // fontBtn
            // 
            this.fontBtn.Location = new System.Drawing.Point(417, 319);
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(96, 21);
            this.fontBtn.TabIndex = 29;
            this.fontBtn.Text = "Font";
            this.fontBtn.UseVisualStyleBackColor = true;
            this.fontBtn.Click += new System.EventHandler(this.fontBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(417, 150);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(96, 21);
            this.importBtn.TabIndex = 30;
            this.importBtn.Text = "Import Dict.";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 394);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.fontBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.frmtCombox2);
            this.Controls.Add(this.frmtCombox1);
            this.Controls.Add(this.frmtBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.caseCtrlCombox);
            this.Controls.Add(this.caseCtrlBtn);
            this.Controls.Add(this.garbleDictBtn);
            this.Controls.Add(this.sbtrctTb);
            this.Controls.Add(this.isoTb);
            this.Controls.Add(this.insTb2);
            this.Controls.Add(this.insTb1);
            this.Controls.Add(this.insBtn);
            this.Controls.Add(this.sbtrctBtn);
            this.Controls.Add(this.isoBtn);
            this.Controls.Add(this.addRandBtn);
            this.Controls.Add(this.lttrCntTb);
            this.Controls.Add(this.removeLttrBtn);
            this.Controls.Add(this.degarbleBtn);
            this.Controls.Add(this.garbleBtn);
            this.Controls.Add(this.covfefeBtn);
            this.Controls.Add(this.mainTb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "cinnt";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTb;
        private System.Windows.Forms.Button covfefeBtn;
        private System.Windows.Forms.Button garbleBtn;
        private System.Windows.Forms.Button degarbleBtn;
        private System.Windows.Forms.Button removeLttrBtn;
        private System.Windows.Forms.TextBox lttrCntTb;
        private System.Windows.Forms.Button addRandBtn;
        private System.Windows.Forms.Button isoBtn;
        private System.Windows.Forms.Button sbtrctBtn;
        private System.Windows.Forms.Button insBtn;
        private System.Windows.Forms.TextBox insTb1;
        private System.Windows.Forms.TextBox insTb2;
        private System.Windows.Forms.TextBox isoTb;
        private System.Windows.Forms.TextBox sbtrctTb;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button garbleDictBtn;
        private System.Windows.Forms.Button caseCtrlBtn;
        private System.Windows.Forms.ComboBox caseCtrlCombox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsMsgReporterLbl;
        private System.Windows.Forms.Button frmtBtn;
        private System.Windows.Forms.ComboBox frmtCombox1;
        private System.Windows.Forms.ComboBox frmtCombox2;
        private System.Windows.Forms.ToolStripStatusLabel tsSeprt1;
        private System.Windows.Forms.ToolStripStatusLabel charCntLbl;
        private System.Windows.Forms.ToolStripStatusLabel tsSeprt2;
        private System.Windows.Forms.ToolStripStatusLabel wrdCntLbl;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button fontBtn;
        private System.Windows.Forms.Button importBtn;
    }
}

