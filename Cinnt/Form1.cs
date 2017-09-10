using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinnt.Properties;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Cinnt
{
    public partial class MainForm : Form
    {
        string OriginalContent = "";
        public MainForm()
        {
            InitializeComponent();
        }
        char[] separator = new char[] { ' ', '\r', '\n' };
        private void lttrCntTb_Erase(object sender, EventArgs e)
        {
            lttrCntTb.Text = "";
        }
        private void lttrCntTb_Watermark(object sender, EventArgs e)
        {
            if (lttrCntTb.Text == "")
            {
                lttrCntTb.Text = "How many?";
            }
        }
        private string GenerateString(int letters, bool covfefe, bool garble, bool genlet, string[] array)
        {
            int number = 0;
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            foreach (string str in array)
            {
                if (covfefe == true)
                {
                    string consonants = "bcdfghjklmnpqrstvwxyz";
                    string vowels = "aeiou";
                    char c;
                    char v;
                    for (int i = 0; i < 1; i++)
                    {
                        c = consonants[r.Next(0, 21)];
                        sb.Append(c);
                        v = vowels[r.Next(0, 5)];
                        sb.Append(v);
                        sb.Append(c);
                        sb.Append(v);
                    }
                    string empty = String.Empty;
                    StringBuilder s = new StringBuilder();
                    int it = 0;
                    foreach (char ch in str)
                    {
                        s.Append(ch);
                        it += 1;
                        if (it == str.Length - 5)
                        {
                            s.Append(sb.ToString());
                            break;
                        }
                    }
                    if (string.Equals(str, "coverage", StringComparison.CurrentCultureIgnoreCase))
                    {
                        s.Remove(0, s.Length);
                        s.Append("covfefe");
                    }
                    number += 1;
                    mainTb.Text += Environment.NewLine;
                    mainTb.Text += number.ToString() + ". ";
                    mainTb.Text += s.ToString();
                    sb.Remove(0, sb.Length);
                    s.Remove(0, s.Length);
                    return "";
                }
                bool isDone = false;
                if (garble == true)
                {
                    sb.Remove(0, sb.Length);
                    string[] definitions = Settings.Default.GarbleSave.Split('\n');
                    int i = 0;
                    foreach (string s in definitions)
                    {
                        if (s.Contains(str))
                        {
                            mainTb.Text += Environment.NewLine;
                            mainTb.Text += definitions[i + 1];
                            isDone = true;
                            break;
                        }
                        i += 1;
                    }
                    if (isDone == true)
                    {
                        break;
                    }
                    string alphabet = "abcdefghijklmnñopqrstuvwxyz0123456789_;.,/-&!@#$%^*()+=~[]{}ABCDEFGHIJKLMNOPQRSTUVWXYZ<>?:";
                    char a;
                    foreach (char c in str)
                    {
                        a = alphabet[r.Next(0, alphabet.Length)];
                        sb.Append(a);
                    }
                    Settings.Default.GarbleSave += Environment.NewLine;
                    Settings.Default.GarbleSave += str;
                    Settings.Default.GarbleSave += Environment.NewLine;
                    Settings.Default.GarbleSave += sb.ToString();
                    Settings.Default.Save();
                }
                if (genlet == true)
                {
                    string alphabet = "abcdefghijklmnopqrstuvwxyz";
                    char a;
                    for (int i = 0; i <= letters; i++)
                    {
                        a = alphabet.ToCharArray()[r.Next(alphabet.Length)];
                        sb.Append(a);
                    }
                    return sb.ToString();
                }
            }
            return sb.ToString();
        }
        private void covfefeBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            string empty = GenerateString(2, true, false, false, mainTb.Text.Split('\n'));
        }
        private void garbleBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            mainTb.Text = GenerateString(2, false, true, false, mainTb.Text.Split('\n'));
        }
        private void ungarbleBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            string[] definitions = Settings.Default.GarbleSave.Split('\n');
            int i = 0;
            foreach (string s in definitions)
            {
                if (s.Contains(mainTb.Text))
                {
                    mainTb.Text += Environment.NewLine;
                    try { mainTb.Text += definitions[i - 1]; }
                    catch (Exception) { tsMsgReporterLbl.Text = "Error 000: various causes - you probably don't have text in the main text box."; }
                    break;
                }
                i++;
            }
        }
        private void removeLttrBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            StringBuilder sb = new StringBuilder();
            if (int.TryParse(lttrCntTb.Text, out int i))
            {
                foreach (string s in mainTb.Text.Split('\n'))
                {
                    sb.Append(s);
                    sb.Append("\r\n");
                    sb.Remove(0, i);
                }
                mainTb.Text = sb.ToString();
            }
        }
        private void addRandBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            if (int.TryParse(lttrCntTb.Text, out int i))
            {
                if (i < 100000000)
                {
                    mainTb.Text += GenerateString(i, false, false, true, mainTb.Text.Split('\n'));
                }
                else
                {
                    tsMsgReporterLbl.Text = "Generating this many letters is prevented in Cinnt in order to protect your data. If you do want to generate this many, please do so in chunks to allow your memory to be preserved.";
                }
            }
        }
        private void isoBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            string[] isolation = mainTb.Text.Split(separator).Where(s => s.StartsWith(isoTb.Text)).ToArray();
            if (isolation.Length == 0)
            {
                tsMsgReporterLbl.Text = "Error 001: Couldn't find an instance of the string you chose.";
            }
            if (isolation.Length > 0)
            {
                tsMsgReporterLbl.Text = "Note: more than one string to isolate was found. This does not affect isolation.";
            }
            mainTb.Text = String.Concat(isolation);
        }
        private void sbtrctBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            mainTb.Text = mainTb.Text.Replace(sbtrctTb.Text, "");
        }
        private void insBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            char[] cc = new char[] { ' ', ',', '/', '|' };
            string[] poss = insTb1.Text.Split();
            string str = mainTb.Text;
            int el = 0; // heh
            foreach (string s in poss)
            {
                if (int.TryParse(s, out int i))
                {
                    try
                    {
                        str = str.Insert(i + insTb2.Text.Length * el, insTb2.Text);
                        el++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        tsMsgReporterLbl.Text = "ERROR 102: One or more positions to insert at was outside the bounds of the current text.";
                    }
                }
                else
                {
                    tsMsgReporterLbl.Text = "ERROR 101: One or more of the positions to insert at is not a verifiable integer.";
                }
            }
            mainTb.Text = str;
        }
        private void caseCtrlBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            mainTb.Text = CaseControl(mainTb.Text, caseCtrlCombox.SelectedIndex);
        }
        private string CaseControl(string input, int index)
        {
            if (index == 0)
            {
                return input.ToUpper();
            }
            if (index == 1)
            {
                return input.ToLower();
            }
            if (index == 2)
            {
                input = input.ToLower();
                char[] cc = input.ToCharArray();
                cc[0] = cc[0].ToString().ToUpper().ToCharArray()[0];
                return new string(cc);
            }
            if (index == 3)
            {
                input = input.ToUpper();
                char[] cc = input.ToCharArray();
                cc[0] = cc[0].ToString().ToLower().ToCharArray()[0];
                return new string(cc);
            }
            if (index == 4)
            {
                char[] cc = input.ToCharArray();
                int i = 0;
                foreach (char c in cc)
                {
                    if (i % 2 == 0)
                    {
                        cc[i] = cc[i].ToString().ToUpper().ToCharArray()[0];
                    }
                    else
                    {
                        cc[i] = cc[i].ToString().ToLower().ToCharArray()[0];
                    }
                }
                return new string(cc);
            }
            if (index == 5)
            {
                string[] alternate = mainTb.Text.Split(new char[] { ' ', '\r', '\n' });
                int i = 0;
                foreach (string s in alternate)
                {
                    if (i % 2 == 0)
                    {
                        alternate[i] = alternate[i].ToUpper() + " ";
                    }
                    else
                    {
                        alternate[i] = alternate[i].ToLower() + " ";
                    }
                    i++;
                }
                return String.Concat(alternate).Replace("  ", "\r\n");
            }
            tsMsgReporterLbl.Text = "ERROR 201: Couldn't control case. Have you selected an option from the dropdown box?";
            return null;
        }
        private void wrdCntUpdate(object sender, EventArgs e)
        {
            charCntLbl.Text = "Characters: " + mainTb.Text.Replace("\r", "").Length;
            wrdCntLbl.Text = "Words: " + mainTb.Text.Split(new char[] { ' ', '\r' }).TakeWhile(x => !x.Equals("")).ToArray().Length;
            parCntLbl.Text = "Paragraphs: " + mainTb.Text.Split('\r').Length;
        }
        private void frmtBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            mainTb.Text = ReformatString(mainTb.Text, new int[] { frmtCombox1.SelectedIndex, frmtCombox2.SelectedIndex }, tsMsgReporterLbl);
        }
        private string ReformatString(string StringToReformat, int[] FormatIndices, ToolStripStatusLabel tssl)
        {
            try
            {
                if (FormatIndices[0] == FormatIndices[1]) return StringToReformat;
                if (FormatIndices[0] == 0 & FormatIndices[1] == 1)
                {
                    // Hexadecimal to binary
                    string BinResult = "";
                    byte[] bb = GetBytes(string.Join("", Regex.Split(StringToReformat.Replace(" ", ""), "(?<=\\G..)(?!$)").Select(str => (char)Convert.ToByte(str, 16))), Encoding.UTF8);
                    foreach (byte b in bb)
                    {
                        string bs = Convert.ToString(b, 2);
                        while (bs.Length < 8)
                        {
                            bs = "0" + bs;
                        }
                        BinResult += bs + "";
                    }
                    return BinResult;
                }
                if (FormatIndices[0] == 1 & FormatIndices[1] == 0)
                {
                    // Binary to hexadecimal
                    return BitConverter.ToString(Encoding.Default.GetBytes(Encoding.UTF8.GetString(GetHexFromBin(StringToReformat).ToArray()))).Replace("-", " ");
                }
                if (FormatIndices[0] == 1 & FormatIndices[1] == 2)
                {
                    // Binary to text
                    return Encoding.UTF8.GetString(GetHexFromBin(StringToReformat).ToArray());
                }
                if (FormatIndices[0] == 2 & FormatIndices[1] == 1)
                {
                    // Text to binary
                    string BinResult = "";
                    byte[] bb = GetBytes(StringToReformat, Encoding.UTF8);
                    foreach (byte b in bb)
                    {
                        string bs = Convert.ToString(b, 2);
                        while (bs.Length < 8)
                        {
                            bs = "0" + bs;
                        }
                        BinResult += bs + "";
                    }
                    return BinResult;
                }
                if (FormatIndices[0] == 0 & FormatIndices[1] == 2)
                {
                    // Hexadecimal to text
                    return string.Join("", Regex.Split(StringToReformat.Replace(" ", ""), "(?<=\\G..)(?!$)").Select(str => (char)Convert.ToByte(str, 16)));
                }
                if (FormatIndices[0] == 2 & FormatIndices[1] == 0)
                {
                    // Text to hexadecimal
                    return BitConverter.ToString(Encoding.Default.GetBytes(StringToReformat)).Replace("-", " ");
                }
            }
            catch
            {
                tssl.Text = "Error 000.2: Attempt to convert from a type that is not present in base text, probably. Unknown exact cause.";
            }
            return null;
        }
        private static byte[] GetBytes(string s, Encoding e)
        {
            return e.GetBytes(s);
        }
        private void importBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.GarbleSave += mainTb.Text;
        }
        private void fontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog()
            {
                AllowSimulations = true,
                AllowVerticalFonts = false,
                ShowEffects = true,
                ShowApply = false,
                ShowColor = false,
                Font = mainTb.Font
            };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                mainTb.Font = fd.Font;
                Settings.Default.def_fnt = fd.Font;
            }
        }
        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cinnt version 0.4.0.0S\r\nMade by snorepion\r\nGithub: https://www.github.com/snorepion" + "\r\nSource code available at https://www.github.com/snorepion/cinnt" + "\r\nYou should not have paid for this software (other than by donating to snorepion via Paypal). If you did, request a refund IMMEDIATELY.");
        }
        private List<byte> GetHexFromBin(string bin)
        {
            List<byte> lb = new List<byte>();
            for (int i = 0; i < bin.Length; i += 8)
            {
                string s = bin.Substring(i, 8);
                lb.Add(Convert.ToByte(s, 2));
            }
            return lb;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] allBtns = new Button[] {
                covfefeBtn,garbleBtn,degarbleBtn,garbleDictBtn,importBtn,removeLttrBtn,addRandBtn,isoBtn,sbtrctBtn,insBtn,caseCtrlBtn,frmtBtn,fontBtn,settingsBtn,reverseBtn,rndmzBtn,autIndBtn,aboutBtn,sortBtn,shuffleBtn,rvrsBtn,findBtn,revBtn
            };
            object[] tbs = new object[] {
                lttrCntTb,isoTb,sbtrctTb,insTb1,insTb2,findTb,tbExtender1,tbContainer2,tbExtender3,tbExtender4
            };
            mainTb.BackColor = Settings.Default.tbBC; mainTb.ForeColor = Settings.Default.tbFC;
            foreach (TextBox t in tbs.Take(6)) { t.BackColor = Settings.Default.tbBC; t.ForeColor = Settings.Default.tbFC; t.Font = Settings.Default.def_fnt; }
            foreach (Panel p in tbs.Skip(6)) { p.BackColor = Settings.Default.tbBC; }
            foreach (Button b in allBtns) { b.BackColor = Settings.Default.btnBC; b.ForeColor = Settings.Default.btnFC; b.FlatAppearance.MouseDownBackColor = Settings.Default.btnMdBC; b.FlatAppearance.MouseOverBackColor = Settings.Default.btnMoBC;b.Font = Settings.Default.uiFont; }
            Font = Settings.Default.uiFont;
            BackColor = Settings.Default.uiBC;
            mainTb.Font = Settings.Default.def_fnt;
            statusStrip1.Renderer = new ToolStripProfessionalRenderer(new Override());
        }
        private void rvrsBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            mainTb.Text = String.Concat(mainTb.Text.Reverse());
        }
        private void rndmzBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            var lc = new List<char>(mainTb.Text.ToCharArray());
            lc.Shuffle();
            mainTb.Text = String.Concat(lc);
        }
        private void autIndBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            string[] s = mainTb.Text.Split('\n');
            int i = 0;
            foreach (string o in s)
            {
                s[i] = " " + s[i];
                i++;
            }
            mainTb.Text = String.Join("\n", s);
        }
        private void sortBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            char c = '\n';
            if (separChrTb.Text != "") c = separChrTb.Text[0];
            string[] items = mainTb.Text.Split(c);
            List<string> ls = items.ToList();
            ls.Sort();
            mainTb.Text = String.Join("\r\n", ls);
            items = null;
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Form f = new Options();
            f.Show();
        }
        private void shuffleBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            List<string> list = mainTb.Text.Split(separChrTb.Text[0]).ToList();
            list.Shuffle();
            mainTb.Text = String.Join(separChrTb.Text[0].ToString(), list);
        }
        private void reverseBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            List<string> list = mainTb.Text.Split(separChrTb.Text[0]).ToList();
            list.Reverse();
            mainTb.Text = String.Join(separChrTb.Text[0].ToString(), list);
        }
        private void findBtn_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(findTb.Text);
            MatchCollection mc = r.Matches(mainTb.Text);
            int origPos = mainTb.SelectionStart;
            int origLgt = mainTb.SelectionLength;
            foreach (Match m in mc)
            {
                mainTb.Select(m.Index, m.Length);
                mainTb.SelectionColor = Settings.Default.matchC;
            }
            mainTb.SelectionStart = origPos;
            mainTb.SelectionLength = origLgt;
            mainTb.SelectionColor = Settings.Default.tbFC;
        }
        private void garbleDictBtn_Click(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            mainTb.Text = Settings.Default.GarbleSave;
        }
        private void revBtn_Click(object sender, EventArgs e)
        {
            mainTb.Text = OriginalContent;
        }
    }
    static class Ext
    {
        static RNGCryptoServiceProvider r = new RNGCryptoServiceProvider();
        public static void Shuffle<T>(this IList<T> il)
        {
            int i = il.Count;
            while (i > 1)
            {
                byte[] bb = new byte[1];
                do r.GetBytes(bb);
                while (!(bb[0] < i * (Byte.MaxValue / i)));
                int e = (bb[0] % i);
                i--;
                T v = il[e];
                il[e] = il[i];
                il[i] = v;
            }
        }
    }
}
public class Override : ProfessionalColorTable
{
    public override Color StatusStripGradientBegin { get { return Color.White; } }
    public override Color StatusStripGradientEnd { get { return Color.White; } }
}