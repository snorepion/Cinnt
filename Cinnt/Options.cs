using Cinnt.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Cinnt
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/snorepion/Cinnt/issues/new?title=[v0.4.0.0S]&body=[v0.4.0.0S]&labels=bug");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.github.com/snorepion/Cinnt");
        }
        private void uiFntBtn_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = Settings.Default.uiFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.uiFont = fd.Font;
            }
        }
        private void applyBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            Font f = Settings.Default.def_fnt;
            string gs = Settings.Default.GarbleSave;
            Settings.Default.Reset();
            Settings.Default.def_fnt = f;
            Settings.Default.GarbleSave = gs;
        }
        ColorDialog cd = new ColorDialog();
        Color[] cc = new Color[] { Settings.Default.tbBC, Settings.Default.tbFC, Settings.Default.btnBC, Settings.Default.btnMoBC,Settings.Default.btnMdBC,Settings.Default.btnFC,Settings.Default.uiBC,Settings.Default.matchC };
        private void modBtn_Click(object sender, EventArgs e)
        {
            cd.Color = cc[colorSelectLb.SelectedIndex];
            if (cd.ShowDialog()==DialogResult.OK)
            {
                cc[colorSelectLb.SelectedIndex] = cd.Color;
            }
        }
    }
}
