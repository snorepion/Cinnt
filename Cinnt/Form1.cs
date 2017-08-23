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

namespace Cinnt
{
    public partial class Form1 : Form
    {
        public Form1()
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
                lttrCntTb.Text = "How many letters?";
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
                            mainTb.Text += definitions[i+1];
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
                    for(int i = 0; i <= letters; i++)
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
            string empty = GenerateString(2, true, false, false, mainTb.Text.Split('\n'));
        }

        private void garbleBtn_Click(object sender, EventArgs e)
        {
            mainTb.Text = GenerateString(2, false, true, false, mainTb.Text.Split('\n'));
        }

        private void ungarbleBtn_Click(object sender, EventArgs e)
        {
            string[] definitions = Settings.Default.GarbleSave.Split('\n');
            int i = 0;
            foreach (string s in definitions)
            {
                if (s.Contains(mainTb.Text))
                {
                    mainTb.Text += Environment.NewLine;
                    try { mainTb.Text += definitions[i - 1]; }
                    catch(Exception) { tsMsgReporterLbl.Text = "Error 000: various causes - you probably don't have text in the main text box."; }
                    break;
                }
                i += 1;
            }
        }

        private void removeLttrBtn_Click(object sender, EventArgs e)
        {
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
            if (int.TryParse(lttrCntTb.Text, out int i))
            {
                mainTb.Text += GenerateString(i, false, false, true, mainTb.Text.Split('\n'));
            }
        }

        private void isoBtn_Click(object sender, EventArgs e)
        {
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
            StringBuilder sb = new StringBuilder();
            int i = 0;
            int foo = 0;
            string[] subtract = mainTb.Text.Split(separator).Where(s => s.StartsWith(sbtrctTb.Text)).ToArray();
            foreach (string s in subtract)
            {
                if (i == 0)
                {
                    sb.Append(mainTb.Text.Substring(0, mainTb.Text.IndexOf(s)));
                    foo = mainTb.Text.IndexOf(s) + s.Length;
                }
                if (i > 0)
                {
                    tsMsgReporterLbl.Text = "Note: more than one string being removed.";
                    sb.Append(mainTb.Text.Substring(foo, mainTb.Text.IndexOf(s) + foo));
                }
                i++;
            }
        }

        private void insBtn_Click(object sender, EventArgs e)
        {
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
                        str = str.Insert(i + insTb2.Text.Length*el, insTb2.Text);
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
            charCntLbl.Text = "Characters: " + mainTb.Text.Length;
            wrdCntLbl.Text = "Words: " + mainTb.Text.Split(new char[] { ' ', '\r' }).Length.ToString();
        }

        private void frmtBtn_Click(object sender, EventArgs e)
        {
            mainTb.Text=ReformatString(mainTb.Text,new int[]{frmtCombox1.SelectedIndex, frmtCombox2.SelectedIndex}, tsMsgReporterLbl);
        }

        private static string ReformatString(string StringToReformat, int[] FormatIndices, ToolStripStatusLabel tssl)
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
                    List<byte> lb = new List<byte>();
                    for (int i = 0; i < StringToReformat.Length; i += 8)
                    {
                        string s = StringToReformat.Substring(i, 8);
                        lb.Add(Convert.ToByte(s, 2));
                    }
                    return BitConverter.ToString(Encoding.Default.GetBytes(Encoding.UTF8.GetString(lb.ToArray()))).Replace("-", " ");
                }
                if (FormatIndices[0] == 1 & FormatIndices[1] == 2)
                {
                    // Binary to text
                    List<byte> lb = new List<byte>();
                    for (int i = 0; i < StringToReformat.Length; i += 8)
                    {
                        string s = StringToReformat.Substring(i, 8);
                        lb.Add(Convert.ToByte(s, 2));
                    }
                    return Encoding.UTF8.GetString(lb.ToArray());
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
            }
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cinnt version 0.2\r\nMade by snorepion\r\nGithub: https://www.github.com/snorepion"+"\r\nSource code available at https://www.github.com/snorepion/cinnt"+"\r\nYou should not have paid for this software (other than by donating to snorepion via Paypal). If you did, request a refund immediately, though you probably won't get one.");
        }
    }
}
