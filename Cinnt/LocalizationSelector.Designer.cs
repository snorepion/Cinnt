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
            this.SuspendLayout();
            // 
            // locLb
            // 
            this.locLb.FormattingEnabled = true;
            this.locLb.ItemHeight = 16;
            this.locLb.Items.AddRange(new object[] {
            "English (U.K.)",
            "English (U.S.)"});
            this.locLb.Location = new System.Drawing.Point(12, 12);
            this.locLb.Name = "locLb";
            this.locLb.Size = new System.Drawing.Size(258, 196);
            this.locLb.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(195, 213);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 28);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // LocalizationSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.locLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocalizationSelector";
            this.Text = "Select";
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.ListBox locLb;
        private System.Windows.Forms.Button okBtn;
    }
}