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
            this.rndmzBtn = new System.Windows.Forms.Button();
            this.autIndBtn = new System.Windows.Forms.Button();
            this.separChrTb = new System.Windows.Forms.TextBox();
            this.caseCtrlBtn = new System.Windows.Forms.Button();
            this.caseCtrlCombox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMsgReporterLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.charCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wrdCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeprt3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.parCntLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.frmtBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.fontBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.rvrsBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.tbExtender1 = new System.Windows.Forms.Panel();
            this.tbContainer2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.tbExtender3 = new System.Windows.Forms.Panel();
            this.findTb = new System.Windows.Forms.TextBox();
            this.tbExtender4 = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.revBtn = new System.Windows.Forms.Button();
            this.reverseBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.tbExtender5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.tbExtender1.SuspendLayout();
            this.tbContainer2.SuspendLayout();
            this.tbExtender3.SuspendLayout();
            this.tbExtender4.SuspendLayout();
            this.tbExtender5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.mainTb.Location = new System.Drawing.Point(3, 3);
            this.mainTb.Name = "mainTb";
            this.mainTb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.mainTb.Size = new System.Drawing.Size(394, 310);
            this.mainTb.TabIndex = 0;
            this.mainTb.Text = "";
            this.mainTb.WordWrap = false;
            this.mainTb.TextChanged += new System.EventHandler(this.wrdCntUpdate);
            // 
            // covfefeBtn
            // 
            this.covfefeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.covfefeBtn.BackColor = System.Drawing.Color.White;
            this.covfefeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.covfefeBtn.FlatAppearance.BorderSize = 0;
            this.covfefeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.covfefeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.covfefeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.covfefeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.covfefeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covfefeBtn.Location = new System.Drawing.Point(417, 13);
            this.covfefeBtn.Name = "covfefeBtn";
            this.covfefeBtn.Size = new System.Drawing.Size(96, 23);
            this.covfefeBtn.TabIndex = 1;
            this.covfefeBtn.Text = "Covfefeize";
            this.toolTip1.SetToolTip(this.covfefeBtn, "Makes a string like the word \"covfefe\" based on your input.");
            this.covfefeBtn.UseVisualStyleBackColor = false;
            this.covfefeBtn.Click += new System.EventHandler(this.covfefeBtn_Click);
            // 
            // garbleBtn
            // 
            this.garbleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.garbleBtn.BackColor = System.Drawing.Color.White;
            this.garbleBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.garbleBtn.FlatAppearance.BorderSize = 0;
            this.garbleBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.garbleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.garbleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.garbleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.garbleBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbleBtn.Location = new System.Drawing.Point(417, 42);
            this.garbleBtn.Name = "garbleBtn";
            this.garbleBtn.Size = new System.Drawing.Size(96, 55);
            this.garbleBtn.TabIndex = 3;
            this.garbleBtn.Text = "Garble (only restores on this PC)";
            this.toolTip1.SetToolTip(this.garbleBtn, "Randomize characters, which are saved to this PC\'s installation of Cinnt.");
            this.garbleBtn.UseVisualStyleBackColor = false;
            this.garbleBtn.Click += new System.EventHandler(this.garbleBtn_Click);
            // 
            // degarbleBtn
            // 
            this.degarbleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.degarbleBtn.BackColor = System.Drawing.Color.White;
            this.degarbleBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.degarbleBtn.FlatAppearance.BorderSize = 0;
            this.degarbleBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.degarbleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.degarbleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.degarbleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.degarbleBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degarbleBtn.Location = new System.Drawing.Point(417, 177);
            this.degarbleBtn.Name = "degarbleBtn";
            this.degarbleBtn.Size = new System.Drawing.Size(96, 41);
            this.degarbleBtn.TabIndex = 4;
            this.degarbleBtn.Text = "Restore from Garble";
            this.toolTip1.SetToolTip(this.degarbleBtn, "Restore from garbled text.");
            this.degarbleBtn.UseVisualStyleBackColor = false;
            this.degarbleBtn.Click += new System.EventHandler(this.ungarbleBtn_Click);
            // 
            // removeLttrBtn
            // 
            this.removeLttrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeLttrBtn.BackColor = System.Drawing.Color.White;
            this.removeLttrBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeLttrBtn.FlatAppearance.BorderSize = 0;
            this.removeLttrBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.removeLttrBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.removeLttrBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.removeLttrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeLttrBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLttrBtn.Location = new System.Drawing.Point(417, 224);
            this.removeLttrBtn.Name = "removeLttrBtn";
            this.removeLttrBtn.Size = new System.Drawing.Size(96, 23);
            this.removeLttrBtn.TabIndex = 5;
            this.removeLttrBtn.Text = "Remove Letters";
            this.toolTip1.SetToolTip(this.removeLttrBtn, "Remove letters from the beginning of a string.");
            this.removeLttrBtn.UseVisualStyleBackColor = false;
            this.removeLttrBtn.Click += new System.EventHandler(this.removeLttrBtn_Click);
            // 
            // lttrCntTb
            // 
            this.lttrCntTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lttrCntTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lttrCntTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lttrCntTb.Location = new System.Drawing.Point(3, 3);
            this.lttrCntTb.Name = "lttrCntTb";
            this.lttrCntTb.Size = new System.Drawing.Size(89, 16);
            this.lttrCntTb.TabIndex = 6;
            this.lttrCntTb.Text = "How many?";
            this.lttrCntTb.Enter += new System.EventHandler(this.lttrCntTb_Erase);
            this.lttrCntTb.Leave += new System.EventHandler(this.lttrCntTb_Watermark);
            // 
            // addRandBtn
            // 
            this.addRandBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRandBtn.BackColor = System.Drawing.Color.White;
            this.addRandBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addRandBtn.FlatAppearance.BorderSize = 0;
            this.addRandBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.addRandBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addRandBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.addRandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRandBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRandBtn.Location = new System.Drawing.Point(417, 279);
            this.addRandBtn.Name = "addRandBtn";
            this.addRandBtn.Size = new System.Drawing.Size(96, 49);
            this.addRandBtn.TabIndex = 7;
            this.addRandBtn.Text = "Add Rand. Letters";
            this.toolTip1.SetToolTip(this.addRandBtn, "Add random letters to the end of a string.");
            this.addRandBtn.UseVisualStyleBackColor = false;
            this.addRandBtn.Click += new System.EventHandler(this.addRandBtn_Click);
            // 
            // isoBtn
            // 
            this.isoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.isoBtn.BackColor = System.Drawing.Color.White;
            this.isoBtn.FlatAppearance.BorderSize = 0;
            this.isoBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.isoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.isoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.isoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isoBtn.Location = new System.Drawing.Point(13, 334);
            this.isoBtn.Name = "isoBtn";
            this.isoBtn.Size = new System.Drawing.Size(75, 21);
            this.isoBtn.TabIndex = 8;
            this.isoBtn.Text = "Isolate";
            this.toolTip1.SetToolTip(this.isoBtn, "Locate specific string(s) and take out everything else.");
            this.isoBtn.UseVisualStyleBackColor = false;
            this.isoBtn.Click += new System.EventHandler(this.isoBtn_Click);
            // 
            // sbtrctBtn
            // 
            this.sbtrctBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbtrctBtn.BackColor = System.Drawing.Color.White;
            this.sbtrctBtn.FlatAppearance.BorderSize = 0;
            this.sbtrctBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.sbtrctBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.sbtrctBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.sbtrctBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbtrctBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtrctBtn.Location = new System.Drawing.Point(94, 334);
            this.sbtrctBtn.Name = "sbtrctBtn";
            this.sbtrctBtn.Size = new System.Drawing.Size(75, 21);
            this.sbtrctBtn.TabIndex = 9;
            this.sbtrctBtn.Text = "Subtract";
            this.toolTip1.SetToolTip(this.sbtrctBtn, "Take out specific strings and keep everything else.");
            this.sbtrctBtn.UseVisualStyleBackColor = false;
            this.sbtrctBtn.Click += new System.EventHandler(this.sbtrctBtn_Click);
            // 
            // insBtn
            // 
            this.insBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insBtn.BackColor = System.Drawing.Color.White;
            this.insBtn.FlatAppearance.BorderSize = 0;
            this.insBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.insBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.insBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.insBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insBtn.Location = new System.Drawing.Point(175, 334);
            this.insBtn.Name = "insBtn";
            this.insBtn.Size = new System.Drawing.Size(75, 21);
            this.insBtn.TabIndex = 10;
            this.insBtn.Text = "Insert";
            this.toolTip1.SetToolTip(this.insBtn, "Add a certain string after another string, specified by you.");
            this.insBtn.UseVisualStyleBackColor = false;
            this.insBtn.Click += new System.EventHandler(this.insBtn_Click);
            // 
            // insTb1
            // 
            this.insTb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insTb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insTb1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insTb1.Location = new System.Drawing.Point(3, 4);
            this.insTb1.Name = "insTb1";
            this.insTb1.Size = new System.Drawing.Size(75, 16);
            this.insTb1.TabIndex = 11;
            this.insTb1.Text = "Where?";
            this.toolTip1.SetToolTip(this.insTb1, resources.GetString("insTb1.ToolTip"));
            // 
            // insTb2
            // 
            this.insTb2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insTb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insTb2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insTb2.Location = new System.Drawing.Point(2, 3);
            this.insTb2.Name = "insTb2";
            this.insTb2.Size = new System.Drawing.Size(75, 16);
            this.insTb2.TabIndex = 12;
            this.insTb2.Text = "What to insert?";
            // 
            // isoTb
            // 
            this.isoTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.isoTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isoTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isoTb.Location = new System.Drawing.Point(3, 3);
            this.isoTb.Name = "isoTb";
            this.isoTb.Size = new System.Drawing.Size(75, 16);
            this.isoTb.TabIndex = 13;
            this.isoTb.Text = "Isolate what?";
            // 
            // sbtrctTb
            // 
            this.sbtrctTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbtrctTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sbtrctTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtrctTb.Location = new System.Drawing.Point(3, 3);
            this.sbtrctTb.Name = "sbtrctTb";
            this.sbtrctTb.Size = new System.Drawing.Size(75, 16);
            this.sbtrctTb.TabIndex = 14;
            this.sbtrctTb.Text = "Subtract what?";
            // 
            // garbleDictBtn
            // 
            this.garbleDictBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.garbleDictBtn.BackColor = System.Drawing.Color.White;
            this.garbleDictBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.garbleDictBtn.FlatAppearance.BorderSize = 0;
            this.garbleDictBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.garbleDictBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.garbleDictBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.garbleDictBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.garbleDictBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbleDictBtn.Location = new System.Drawing.Point(418, 103);
            this.garbleDictBtn.Name = "garbleDictBtn";
            this.garbleDictBtn.Size = new System.Drawing.Size(96, 41);
            this.garbleDictBtn.TabIndex = 21;
            this.garbleDictBtn.Text = "Export Garble Dict.";
            this.toolTip1.SetToolTip(this.garbleDictBtn, "Allow other PCs to degarble your strings.");
            this.garbleDictBtn.UseVisualStyleBackColor = false;
            this.garbleDictBtn.Click += new System.EventHandler(this.garbleDictBtn_Click);
            // 
            // frmtCombox1
            // 
            this.frmtCombox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frmtCombox1.BackColor = System.Drawing.Color.White;
            this.frmtCombox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frmtCombox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmtCombox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmtCombox1.FormattingEnabled = true;
            this.frmtCombox1.Items.AddRange(new object[] {
            "Hexadecimal",
            "Binary",
            "Text"});
            this.frmtCombox1.Location = new System.Drawing.Point(351, 359);
            this.frmtCombox1.Name = "frmtCombox1";
            this.frmtCombox1.Size = new System.Drawing.Size(60, 23);
            this.frmtCombox1.TabIndex = 26;
            this.toolTip1.SetToolTip(this.frmtCombox1, "Base type - can convert from hex, binary, string");
            // 
            // frmtCombox2
            // 
            this.frmtCombox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frmtCombox2.BackColor = System.Drawing.Color.White;
            this.frmtCombox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frmtCombox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmtCombox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmtCombox2.FormattingEnabled = true;
            this.frmtCombox2.Items.AddRange(new object[] {
            "Hexadecimal",
            "Binary",
            "Text"});
            this.frmtCombox2.Location = new System.Drawing.Point(351, 388);
            this.frmtCombox2.Name = "frmtCombox2";
            this.frmtCombox2.Size = new System.Drawing.Size(59, 23);
            this.frmtCombox2.TabIndex = 27;
            this.toolTip1.SetToolTip(this.frmtCombox2, "Base type - can convert from hex, binary, string");
            // 
            // rndmzBtn
            // 
            this.rndmzBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rndmzBtn.BackColor = System.Drawing.Color.White;
            this.rndmzBtn.FlatAppearance.BorderSize = 0;
            this.rndmzBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.rndmzBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rndmzBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.rndmzBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndmzBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndmzBtn.Location = new System.Drawing.Point(94, 385);
            this.rndmzBtn.Name = "rndmzBtn";
            this.rndmzBtn.Size = new System.Drawing.Size(75, 26);
            this.rndmzBtn.TabIndex = 33;
            this.rndmzBtn.Text = "Anagram";
            this.toolTip1.SetToolTip(this.rndmzBtn, "Randomly reorder letters.");
            this.rndmzBtn.UseVisualStyleBackColor = false;
            this.rndmzBtn.Click += new System.EventHandler(this.rndmzBtn_Click);
            // 
            // autIndBtn
            // 
            this.autIndBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.autIndBtn.BackColor = System.Drawing.Color.White;
            this.autIndBtn.FlatAppearance.BorderSize = 0;
            this.autIndBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.autIndBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.autIndBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.autIndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autIndBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autIndBtn.Location = new System.Drawing.Point(255, 385);
            this.autIndBtn.Name = "autIndBtn";
            this.autIndBtn.Size = new System.Drawing.Size(90, 26);
            this.autIndBtn.TabIndex = 34;
            this.autIndBtn.Text = "Auto-Indent";
            this.toolTip1.SetToolTip(this.autIndBtn, "Indent every (detected, not perfect) paragraph by one space. Use again to indent " +
        "further.");
            this.autIndBtn.UseVisualStyleBackColor = false;
            this.autIndBtn.Click += new System.EventHandler(this.autIndBtn_Click);
            // 
            // separChrTb
            // 
            this.separChrTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.separChrTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.separChrTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separChrTb.Location = new System.Drawing.Point(94, 420);
            this.separChrTb.MaxLength = 1;
            this.separChrTb.Name = "separChrTb";
            this.separChrTb.Size = new System.Drawing.Size(12, 16);
            this.separChrTb.TabIndex = 36;
            this.toolTip1.SetToolTip(this.separChrTb, "Separator character. Leave blank to sort by line.");
            // 
            // caseCtrlBtn
            // 
            this.caseCtrlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.caseCtrlBtn.BackColor = System.Drawing.Color.White;
            this.caseCtrlBtn.FlatAppearance.BorderSize = 0;
            this.caseCtrlBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.caseCtrlBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.caseCtrlBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.caseCtrlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caseCtrlBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseCtrlBtn.Location = new System.Drawing.Point(255, 334);
            this.caseCtrlBtn.Name = "caseCtrlBtn";
            this.caseCtrlBtn.Size = new System.Drawing.Size(90, 21);
            this.caseCtrlBtn.TabIndex = 22;
            this.caseCtrlBtn.Text = "Case Ctrl";
            this.caseCtrlBtn.UseVisualStyleBackColor = false;
            this.caseCtrlBtn.Click += new System.EventHandler(this.caseCtrlBtn_Click);
            // 
            // caseCtrlCombox
            // 
            this.caseCtrlCombox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.caseCtrlCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caseCtrlCombox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caseCtrlCombox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseCtrlCombox.FormattingEnabled = true;
            this.caseCtrlCombox.Items.AddRange(new object[] {
            "Capital",
            "Lower",
            "Sentence",
            "Reverse Sentence",
            "Alternating",
            "Word Alternating"});
            this.caseCtrlCombox.Location = new System.Drawing.Point(255, 359);
            this.caseCtrlCombox.Name = "caseCtrlCombox";
            this.caseCtrlCombox.Size = new System.Drawing.Size(90, 23);
            this.caseCtrlCombox.TabIndex = 23;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMsgReporterLbl,
            this.tsSeprt1,
            this.charCntLbl,
            this.tsSeprt2,
            this.wrdCntLbl,
            this.tsSeprt3,
            this.parCntLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            // tsSeprt3
            // 
            this.tsSeprt3.Name = "tsSeprt3";
            this.tsSeprt3.Size = new System.Drawing.Size(10, 17);
            this.tsSeprt3.Text = "|";
            // 
            // parCntLbl
            // 
            this.parCntLbl.Name = "parCntLbl";
            this.parCntLbl.Size = new System.Drawing.Size(78, 17);
            this.parCntLbl.Text = "Paragraphs: 0";
            // 
            // frmtBtn
            // 
            this.frmtBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frmtBtn.BackColor = System.Drawing.Color.White;
            this.frmtBtn.FlatAppearance.BorderSize = 0;
            this.frmtBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.frmtBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.frmtBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.frmtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmtBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmtBtn.Location = new System.Drawing.Point(351, 334);
            this.frmtBtn.Name = "frmtBtn";
            this.frmtBtn.Size = new System.Drawing.Size(60, 21);
            this.frmtBtn.TabIndex = 25;
            this.frmtBtn.Text = "Format";
            this.frmtBtn.UseVisualStyleBackColor = false;
            this.frmtBtn.Click += new System.EventHandler(this.frmtBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutBtn.BackColor = System.Drawing.Color.White;
            this.aboutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.aboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.aboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Location = new System.Drawing.Point(417, 390);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(96, 21);
            this.aboutBtn.TabIndex = 28;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // fontBtn
            // 
            this.fontBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontBtn.BackColor = System.Drawing.Color.White;
            this.fontBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.fontBtn.FlatAppearance.BorderSize = 0;
            this.fontBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.fontBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.fontBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.fontBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontBtn.Location = new System.Drawing.Point(417, 334);
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(97, 21);
            this.fontBtn.TabIndex = 29;
            this.fontBtn.Text = "Font";
            this.fontBtn.UseVisualStyleBackColor = false;
            this.fontBtn.Click += new System.EventHandler(this.fontBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importBtn.BackColor = System.Drawing.Color.White;
            this.importBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.importBtn.FlatAppearance.BorderSize = 0;
            this.importBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.Location = new System.Drawing.Point(417, 150);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(96, 21);
            this.importBtn.TabIndex = 30;
            this.importBtn.Text = "Import Dict.";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // rvrsBtn
            // 
            this.rvrsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rvrsBtn.BackColor = System.Drawing.Color.White;
            this.rvrsBtn.FlatAppearance.BorderSize = 0;
            this.rvrsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.rvrsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rvrsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.rvrsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rvrsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rvrsBtn.Location = new System.Drawing.Point(13, 385);
            this.rvrsBtn.Name = "rvrsBtn";
            this.rvrsBtn.Size = new System.Drawing.Size(75, 26);
            this.rvrsBtn.TabIndex = 32;
            this.rvrsBtn.Text = "Reverse";
            this.rvrsBtn.UseVisualStyleBackColor = false;
            this.rvrsBtn.Click += new System.EventHandler(this.rvrsBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortBtn.BackColor = System.Drawing.Color.White;
            this.sortBtn.FlatAppearance.BorderSize = 0;
            this.sortBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.sortBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.sortBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBtn.Location = new System.Drawing.Point(13, 417);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 21);
            this.sortBtn.TabIndex = 35;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // tbExtender1
            // 
            this.tbExtender1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExtender1.BackColor = System.Drawing.Color.White;
            this.tbExtender1.Controls.Add(this.lttrCntTb);
            this.tbExtender1.Location = new System.Drawing.Point(418, 254);
            this.tbExtender1.Name = "tbExtender1";
            this.tbExtender1.Size = new System.Drawing.Size(95, 19);
            this.tbExtender1.TabIndex = 37;
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
            this.tbContainer2.Location = new System.Drawing.Point(12, 12);
            this.tbContainer2.Name = "tbContainer2";
            this.tbContainer2.Size = new System.Drawing.Size(398, 316);
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
            this.button2.Location = new System.Drawing.Point(384, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(14, 5);
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
            this.button1.Location = new System.Drawing.Point(384, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 7);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shuffleBtn.BackColor = System.Drawing.Color.White;
            this.shuffleBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.shuffleBtn.FlatAppearance.BorderSize = 0;
            this.shuffleBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.shuffleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.shuffleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.shuffleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleBtn.Location = new System.Drawing.Point(112, 417);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(64, 21);
            this.shuffleBtn.TabIndex = 39;
            this.shuffleBtn.Text = "Shuffle";
            this.toolTip1.SetToolTip(this.shuffleBtn, "Shuffle the order of a list based on a chosen character.");
            this.shuffleBtn.UseVisualStyleBackColor = false;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // tbExtender3
            // 
            this.tbExtender3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExtender3.BackColor = System.Drawing.Color.White;
            this.tbExtender3.Controls.Add(this.findTb);
            this.tbExtender3.Location = new System.Drawing.Point(318, 418);
            this.tbExtender3.Name = "tbExtender3";
            this.tbExtender3.Size = new System.Drawing.Size(91, 20);
            this.tbExtender3.TabIndex = 38;
            // 
            // findTb
            // 
            this.findTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.findTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTb.Location = new System.Drawing.Point(3, 3);
            this.findTb.Name = "findTb";
            this.findTb.Size = new System.Drawing.Size(85, 16);
            this.findTb.TabIndex = 6;
            this.findTb.Text = "What to find";
            // 
            // tbExtender4
            // 
            this.tbExtender4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbExtender4.BackColor = System.Drawing.Color.White;
            this.tbExtender4.Controls.Add(this.isoTb);
            this.tbExtender4.Location = new System.Drawing.Point(13, 361);
            this.tbExtender4.Name = "tbExtender4";
            this.tbExtender4.Size = new System.Drawing.Size(75, 19);
            this.tbExtender4.TabIndex = 38;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.BackColor = System.Drawing.Color.White;
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.Location = new System.Drawing.Point(417, 360);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(96, 23);
            this.settingsBtn.TabIndex = 40;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // revBtn
            // 
            this.revBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revBtn.BackColor = System.Drawing.Color.White;
            this.revBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.revBtn.FlatAppearance.BorderSize = 0;
            this.revBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.revBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.revBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.revBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revBtn.Location = new System.Drawing.Point(417, 417);
            this.revBtn.Name = "revBtn";
            this.revBtn.Size = new System.Drawing.Size(97, 21);
            this.revBtn.TabIndex = 41;
            this.revBtn.Text = "Revert";
            this.revBtn.UseVisualStyleBackColor = false;
            this.revBtn.Click += new System.EventHandler(this.revBtn_Click);
            // 
            // reverseBtn
            // 
            this.reverseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reverseBtn.BackColor = System.Drawing.Color.White;
            this.reverseBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reverseBtn.FlatAppearance.BorderSize = 0;
            this.reverseBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.reverseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.reverseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.reverseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reverseBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverseBtn.Location = new System.Drawing.Point(182, 417);
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(68, 21);
            this.reverseBtn.TabIndex = 42;
            this.reverseBtn.Text = "Swap";
            this.toolTip1.SetToolTip(this.reverseBtn, "Reverse the order of a list based on the chosen character.");
            this.reverseBtn.UseVisualStyleBackColor = false;
            this.reverseBtn.Click += new System.EventHandler(this.reverseBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.findBtn.BackColor = System.Drawing.Color.White;
            this.findBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.findBtn.FlatAppearance.BorderSize = 0;
            this.findBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.findBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.findBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(256, 417);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(56, 21);
            this.findBtn.TabIndex = 43;
            this.findBtn.Text = "Find";
            this.toolTip1.SetToolTip(this.findBtn, "Highlight specific text. You may enter a regex or plain text to find.");
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // tbExtender5
            // 
            this.tbExtender5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbExtender5.BackColor = System.Drawing.Color.White;
            this.tbExtender5.Controls.Add(this.sbtrctTb);
            this.tbExtender5.Location = new System.Drawing.Point(94, 361);
            this.tbExtender5.Name = "tbExtender5";
            this.tbExtender5.Size = new System.Drawing.Size(75, 19);
            this.tbExtender5.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.insTb1);
            this.panel1.Location = new System.Drawing.Point(174, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 19);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.insTb2);
            this.panel2.Location = new System.Drawing.Point(175, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 19);
            this.panel2.TabIndex = 41;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(526, 469);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbExtender5);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.reverseBtn);
            this.Controls.Add(this.revBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.tbExtender4);
            this.Controls.Add(this.tbExtender3);
            this.Controls.Add(this.shuffleBtn);
            this.Controls.Add(this.tbExtender1);
            this.Controls.Add(this.separChrTb);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.autIndBtn);
            this.Controls.Add(this.rndmzBtn);
            this.Controls.Add(this.rvrsBtn);
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
            this.Controls.Add(this.insBtn);
            this.Controls.Add(this.sbtrctBtn);
            this.Controls.Add(this.isoBtn);
            this.Controls.Add(this.addRandBtn);
            this.Controls.Add(this.removeLttrBtn);
            this.Controls.Add(this.degarbleBtn);
            this.Controls.Add(this.garbleBtn);
            this.Controls.Add(this.covfefeBtn);
            this.Controls.Add(this.tbContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Cinnt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tbExtender1.ResumeLayout(false);
            this.tbExtender1.PerformLayout();
            this.tbContainer2.ResumeLayout(false);
            this.tbExtender3.ResumeLayout(false);
            this.tbExtender3.PerformLayout();
            this.tbExtender4.ResumeLayout(false);
            this.tbExtender4.PerformLayout();
            this.tbExtender5.ResumeLayout(false);
            this.tbExtender5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainTb;
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
        private System.Windows.Forms.Button rvrsBtn;
        private System.Windows.Forms.Button rndmzBtn;
        private System.Windows.Forms.ToolStripStatusLabel tsSeprt3;
        private System.Windows.Forms.ToolStripStatusLabel parCntLbl;
        private System.Windows.Forms.Button autIndBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.TextBox separChrTb;
        private System.Windows.Forms.Panel tbExtender1;
        private System.Windows.Forms.Panel tbContainer2;
        private System.Windows.Forms.Button shuffleBtn;
        private System.Windows.Forms.Panel tbExtender3;
        private System.Windows.Forms.TextBox findTb;
        private System.Windows.Forms.Panel tbExtender4;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button revBtn;
        private System.Windows.Forms.Button reverseBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel tbExtender5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

