namespace Cinnt
{
    partial class IpaEntryDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IpaEntryDialog));
            this.entryTb = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryTb
            // 
            this.entryTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryTb.BackColor = global::Cinnt.Properties.Settings.Default.tbBC;
            this.entryTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entryTb.ForeColor = global::Cinnt.Properties.Settings.Default.tbFC;
            this.entryTb.Location = new System.Drawing.Point(3, 4);
            this.entryTb.Multiline = true;
            this.entryTb.Name = "entryTb";
            this.entryTb.Size = new System.Drawing.Size(471, 248);
            this.entryTb.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.BackColor = global::Cinnt.Properties.Settings.Default.btnBC;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.okBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = global::Cinnt.Properties.Settings.Default.btnFC;
            this.okBtn.Location = new System.Drawing.Point(362, 274);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(127, 31);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = global::Cinnt.Properties.Language.Ok;
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = global::Cinnt.Properties.Settings.Default.tbBC;
            this.panel1.Controls.Add(this.entryTb);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 256);
            this.panel1.TabIndex = 2;
            // 
            // IpaEntryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Cinnt.Properties.Settings.Default.uiBC;
            this.ClientSize = new System.Drawing.Size(501, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.okBtn);
            this.Font = global::Cinnt.Properties.Settings.Default.uiFont;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IpaEntryDialog";
            this.Text = "IPA";
            this.Load += new System.EventHandler(this.IpaEntryDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox entryTb;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel panel1;
    }
}