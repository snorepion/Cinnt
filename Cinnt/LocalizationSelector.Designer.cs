namespace Cinnt
{
    partial class LocalizationSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizationSelector));
            this.locLb = new System.Windows.Forms.ListBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // locLb
            // 
            this.locLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locLb.BackColor = global::Cinnt.Properties.Settings.Default.tbBC;
            this.locLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locLb.ForeColor = global::Cinnt.Properties.Settings.Default.tbFC;
            this.locLb.FormattingEnabled = true;
            this.locLb.ItemHeight = 20;
            this.locLb.Items.AddRange(new object[] {
            "English (U.K.)",
            "English (U.S.)"});
            this.locLb.Location = new System.Drawing.Point(3, 2);
            this.locLb.Name = "locLb";
            this.locLb.Size = new System.Drawing.Size(252, 180);
            this.locLb.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = global::Cinnt.Properties.Settings.Default.btnBC;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.okBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Location = new System.Drawing.Point(195, 213);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 28);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = global::Cinnt.Properties.Settings.Default.tbBC;
            this.panel1.Controls.Add(this.locLb);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 195);
            this.panel1.TabIndex = 2;
            // 
            // LocalizationSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Cinnt.Properties.Settings.Default.uiBC;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.okBtn);
            this.Font = global::Cinnt.Properties.Settings.Default.uiFont;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocalizationSelector";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.LocalizationSelector_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.ListBox locLb;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel panel1;
    }
}