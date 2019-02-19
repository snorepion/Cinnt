using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Unicode;

namespace Cinnt
{
    public partial class CharacterBrowserDialog : Form
    {
        public string SpecialCharacters = "";
        public CharacterBrowserDialog()
        {
            InitializeComponent();
        }
        private void blockSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            charView.Items.Clear();
            UnicodeBlock newB = UnicodeInfo.GetBlocks()[blockSelection.SelectedIndex];
            int i = newB.CodePointRange.FirstCodePoint;
            int range_upper = newB.CodePointRange.LastCodePoint;
            UnicodeCharInfo uc = new UnicodeCharInfo();
            int itemind = 0;
            string name = "RESERVED CODEPOINT";
            while (i <= range_upper)
            {
                uc = UnicodeInfo.GetCharInfo(i);
                charView.Items.Add(UnicodeInfo.GetDisplayText(uc));
                if (uc.Name != null) name = uc.Name;
                charView.Items[itemind].ToolTipText = name + "\r\nCode point: U+" + BitConverter.ToString(BitConverter.GetBytes(uc.CodePoint).Reverse().ToArray()).Replace("-", "");
                i++;
                itemind++;
            }
        }
        private void charView_ItemActivate(object sender, EventArgs e)
        {
            charTb.Text += charView.SelectedItems[0].Text;
        }
        private void fontBtn_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
               if (fd.ShowDialog() == DialogResult.OK)
                {
                    charView.Font = fd.Font;
                }
            }
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            this.SpecialCharacters = charTb.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void CharacterBrowserDialog_Load(object sender, EventArgs e)
        {
            okBtn.FlatAppearance.MouseDownBackColor = Properties.Settings.Default.btnMdBC;
            okBtn.FlatAppearance.MouseOverBackColor = Properties.Settings.Default.btnMoBC;
        }
    }
}
