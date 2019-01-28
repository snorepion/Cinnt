﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Unicode;
using System.Windows.Forms;
using Cinnt.Properties;
using System.Text.RegularExpressions;

namespace Cinnt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region Miscellaneous/basic things
        string OriginalContent = ""; // used for undo
        char[] separator = new char[] { ' ', '\r', '\n' };
        private string GetOneArgument()
        {
            return String.Concat(argsTb.Text.TakeWhile(x => !x.Equals(' ')));
        }
        private string[] GetMultipleArguments()
        {
            string[] args = argsTb.Text.Split(' ');
            if (args.Length > 1) return args;
            else { tsMsgReporterLbl.Text = "Error A1: not enough arguments"; return null; }
        }
        private void WordCountUpdate(object sender, EventArgs e)
        {
            charCntLbl.Text = "Characters: " + mainTb.Text.Replace("\r", "").Length;
            wrdCntLbl.Text = "Words: " + mainTb.Text.Split(new char[] { ' ', '\r' }).TakeWhile(x => !x.Equals("")).ToArray().Length;
            parCntLbl.Text = "Paragraphs: " + mainTb.Text.Split('\r').Length;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e) // implements all keyboard shortcuts
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    // in order of their appearance in the menu
                    case Keys.F:
                        Find(null, null);
                        break;
                    case Keys.H:
                        Replace(null, null);
                        break;
                    case Keys.I:
                        Isolate(null, null);
                        break;
                    case Keys.T:
                        Subtract(null, null);
                        break;
                    case Keys.R:
                        Insert(null, null);
                        break;
                    case Keys.P:
                        UnicodeInsert(null, null);
                        break;
                    case Keys.O:
                        Covfefe(null, null);
                        break;
                    case Keys.S:
                        Sort(null, null);
                        break;
                    case Keys.L:
                        Shuffle(null, null);
                        break;
                    case Keys.Q:
                        Revert(null, null);
                        break;
                }
            }
        }
        private void FontChange(object sender, EventArgs e)
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
        private void FrmLoad(object sender, EventArgs e)
        {
            mainTb.BackColor = Settings.Default.tbBC; mainTb.ForeColor = Settings.Default.tbFC;
            Font = Settings.Default.uiFont;
            BackColor = Settings.Default.uiBC;
            mainTb.Font = Settings.Default.def_fnt;
            statStrip.Renderer = new ToolStripProfessionalRenderer(new Override());
        }
        private void Revert(object sender, EventArgs e)
        {
            mainTb.Text = OriginalContent;
        }
        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("Cinnt version 1.0.0.0R\r\nMade by snorepion\r\nGithub: https://www.github.com/snorepion" + "\r\nSource code available at https://www.github.com/snorepion/cinnt" + "\r\nYou should not have paid for this software (other than by donating to snorepion via Paypal). If you did, request a refund.");
        }
        private void Options(object sender, EventArgs e)
        {
            new Options().Show();
        }
        #endregion
        #region Edit functions
        private void Isolate(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            string[] isolation = mainTb.Text.Split(separator).Where(s => s.StartsWith(GetOneArgument())).ToArray();
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
        private void Subtract(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            mainTb.Text = mainTb.Text.Replace(GetOneArgument(), "");
        }
        private void Insert(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            char[] cc = new char[] { ' ', ',', '/', '|' };
            string[] args = GetMultipleArguments();
            string str = mainTb.Text;
            if (int.TryParse(args[0], out int i))
            {
                try
                {
                    str = str.Insert(i, args[1]);
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
            mainTb.Text = str;
        }
        private void RemoveLetters(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            string[] args = GetMultipleArguments();
            StringBuilder sb = new StringBuilder();
            if (int.TryParse(args[0], out int i) && int.TryParse(args[1], out int ɪ))
            {
                foreach (string s in mainTb.Text.Split('\n'))
                {
                    sb.Append(s);
                    sb.Append("\r\n");
                    sb.Remove(i, ɪ); // removes from argument 1 to argument 2
                }
                mainTb.Text = sb.ToString();
            }
        }
        private void CaseCtrl(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            // implements human-readable arguments for this conversion
            switch (argsTb.Text)
            {
                case "caps":
                    mainTb.Text = CaseControl(mainTb.Text, 0);
                    break;
                case "lower":
                    mainTb.Text = CaseControl(mainTb.Text, 1);
                    break;
                case "sentence":
                    mainTb.Text = CaseControl(mainTb.Text, 2);
                    break;
                case "-sentence":
                    mainTb.Text = CaseControl(mainTb.Text, 3);
                    break;
                default:
                    break;
            }
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
            if (index == 2) // sentence
            {
                input = input.ToLower();
                char[] cc = input.ToCharArray();
                cc[0] = cc[0].ToString().ToUpper()[0];
                return new string(cc);
            }
            if (index == 3) // reverse sentence
            {
                input = input.ToUpper();
                char[] cc = input.ToCharArray();
                cc[0] = cc[0].ToString().ToLower()[0];
                return new string(cc);
            }
            if (index == 4) // alternating, starting uppercase
            {
                char[] cc = input.ToCharArray();
                int i = 0;
                foreach (char c in cc)
                {
                    if (i % 2 == 0)
                    {
                        cc[i] = cc[i].ToString().ToUpper()[0];
                    }
                    else
                    {
                        cc[i] = cc[i].ToString().ToLower()[0];
                    }
                }
                return new string(cc);
            }
            if (index == 5) // i have no idea what this is and don't have support for it atm
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
            // error 201 deprecated
            return null;
        }
        private void PadLeft(object sender, EventArgs e)
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
        private void UnicodeInsert(object sender, EventArgs e)
        {
            if (GetOneArgument() == "")
            {
                using (CharacterBrowserDialog cbd = new CharacterBrowserDialog())
                {
                    if (cbd.ShowDialog()==DialogResult.OK)
                    {
                        mainTb.Text = mainTb.Text.Insert(mainTb.SelectionStart, cbd.SpecialCharacters);
                    }
                }
            }
            else
            {
                string[] args = GetMultipleArguments();
                StringBuilder addChars = new StringBuilder();
                foreach (string s in args)
                {
                    addChars.Append(UnicodeInfo.GetDisplayText(Convert.ToInt32(s)));
                }
                mainTb.Text = mainTb.Text.Insert(mainTb.SelectionStart, addChars.ToString());
            }
        }
        #endregion
        #region Find and replace
        private void Find(object sender, EventArgs e)
        {
            Regex r = new Regex(argsTb.Text);
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
        private void Replace(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            string[] args = GetMultipleArguments();
            Regex.Replace(mainTb.Text, args[0], args[1]);
        }
        #endregion
        #region Format
        private void Format(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            FormatType[] Formats = new FormatType[] { FormatType.ASCII, FormatType.ASCII };
            int i = 0;
            foreach (string s in argsTb.Text.Split(' ')) // gets our format types from human text
            {
                if (i > 1) break;
                switch (s)
                {
                    case "hex":
                        Formats[i] = FormatType.Hexadecimal;
                        continue;
                    case "ascii":
                        Formats[i] = FormatType.ASCII;
                        continue;
                    case "bin":
                        Formats[i] = FormatType.Binary;
                        continue;
                }
                i++;
            }
            mainTb.Text = ReformatString(mainTb.Text, Formats, tsMsgReporterLbl);
        }
        enum FormatType
        {
            ASCII,
            Hexadecimal,
            Binary
        }
        // I didn't really change much about any of these except for changing ints to more readable enums since I just gave them a cursory look, and they're probably inefficient because I wrote them two years ago.
        // The main thing here is that the ifs could be nested instead of using &&, which would simplify and beautify the code a good deal. I'll get around to that eventually, but in the meantime adding "else" helps a bit.
        private string ReformatString(string StringToReformat, FormatType[] Types, ToolStripStatusLabel tssl)
        {
            try
            {
                if (Types[0] == Types[1]) return StringToReformat;
                else if (Types[0] == FormatType.Hexadecimal && Types[1] == FormatType.Binary)
                {
                    // Hexadecimal to binary
                    string BinResult = "";
                    byte[] bb = GetBytes(string.Join("", Regex.Split(StringToReformat.Replace(" ", ""), "(?<=\\G..)(?!$)").Select(str => (char)Convert.ToByte(str, 16))), Encoding.UTF8);
                    string bs = "";
                    foreach (byte b in bb)
                    {
                        bs = Convert.ToString(b, 2);
                        while (bs.Length < 8)
                        {
                            bs = "0" + bs;
                        }
                        BinResult += bs + "";
                    }
                    return BinResult;
                }
                else if (Types[0] == FormatType.Binary && Types[1] == FormatType.Hexadecimal)
                {
                    // Binary to hexadecimal
                    return BitConverter.ToString(
                        Encoding.Unicode.GetBytes(
                            Encoding.UTF8.GetString(
                                GetHexFromBin(StringToReformat).ToArray()
                                )
                            )
                         )
                         .Replace("-", " ");
                }
                else if (Types[0] == FormatType.Binary && Types[1] == FormatType.ASCII)
                {
                    // Binary to text
                    return Encoding.UTF8.GetString(GetHexFromBin(StringToReformat).ToArray());
                }
                else if (Types[0] == FormatType.ASCII && Types[1] == FormatType.Binary)
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
                else if (Types[0] == FormatType.Hexadecimal && Types[1] == FormatType.ASCII)
                {
                    // Hexadecimal to text
                    return string.Join("", Regex.Split(StringToReformat.Replace(" ", ""), "(?<=\\G..)(?!$)").Select(str => (char)Convert.ToByte(str, 16)));
                }
                else if (Types[0] == FormatType.ASCII && Types[1] == FormatType.Hexadecimal)
                {
                    // Text to hexadecimal
                    return BitConverter.ToString(Encoding.Unicode.GetBytes(StringToReformat)).Replace("-", " ");
                }
            }
            catch
            {
                tssl.Text = "Error 002: Attempt to convert from a type that is not present in base text, probably. Unknown exact cause.";
            }
            return null;
        }
        private static byte[] GetBytes(string s, Encoding e)
        {
            return e.GetBytes(s);
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
        #endregion
        #region Encryption, decryption, and hashing
        private void Encrypt(object sender, EventArgs e)
        {
            string[] args = GetMultipleArguments();
            switch (args[0])
            {
                case "des":
                    if (args.Length > 1) mainTb.Text = DesEncrypt(String.Concat(args.Skip(1)));
                    else tsMsgReporterLbl.Text = "Error A1: not enough arguments";
                    break;
                case "aes":
                    if (args.Length > 1) mainTb.Text = AesEncrypt(String.Concat(args.Skip(1)));
                    else tsMsgReporterLbl.Text = "Error A1: not enough arguments";
                    break;
                case "rc2":
                    if (args.Length > 1) mainTb.Text = Rc2Encrypt(String.Concat(args.Skip(1)));
                    else tsMsgReporterLbl.Text = "Error A1: not enough arguments";
                    break;
                default:
                    tsMsgReporterLbl.Text = "Error A2: invalid argument (<special>)";
                    break;
            }
        }
        private void Decrypt(object sender, EventArgs e)
        {
            string[] args = GetMultipleArguments();
            switch (args[0])
            {
                case "des":
                    if (args.Length > 1) mainTb.Text = DesDecrypt(String.Concat(args.Skip(1)));
                    else tsMsgReporterLbl.Text = "Error A1: not enough arguments";
                    break;
                case "aes":
                    if (args.Length > 1) mainTb.Text = AesDecrypt(String.Concat(args.Skip(1)));
                    else tsMsgReporterLbl.Text = "Error A1: not enough arguments";
                    break;
                case "rc2":
                    if (args.Length > 1) mainTb.Text = Rc2Decrypt(String.Concat(args.Skip(1)));
                    else tsMsgReporterLbl.Text = "Error A1: not enough arguments";
                    break;
                default:
                    tsMsgReporterLbl.Text = "Error A2: invalid argument (<special>)";
                    break;
            }
        }
        private string DesEncrypt(string Key)
        {
            // doesn't store the original text in the OriginalContent in encryption for safety reasons
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.Key = Encoding.Unicode.GetBytes(Key);
            des.GenerateIV();
            byte[] _new = new byte[mainTb.TextLength];
            des.CreateEncryptor().TransformBlock(Encoding.Unicode.GetBytes(mainTb.Text), 0, mainTb.TextLength, _new, 0);
            return Encoding.Unicode.GetString(_new);
        }
        private string DesDecrypt(string Key)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.Key = Encoding.Unicode.GetBytes(Key);
            byte[] _new = new byte[mainTb.TextLength];
            des.CreateDecryptor().TransformBlock(Encoding.Unicode.GetBytes(mainTb.Text), 0, mainTb.TextLength, _new, 0);
            return Encoding.Unicode.GetString(_new);
        }
        private string AesEncrypt(string Key)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.Key = Encoding.Unicode.GetBytes(Key);
            aes.GenerateIV();
            byte[] _new = new byte[mainTb.TextLength];
            aes.CreateEncryptor().TransformBlock(Encoding.Unicode.GetBytes(mainTb.Text), 0, mainTb.TextLength, _new, 0);
            return Encoding.Unicode.GetString(_new);
        }
        private string AesDecrypt(string Key)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.Key = Encoding.Unicode.GetBytes(Key);
            byte[] _new = new byte[mainTb.TextLength];
            aes.CreateDecryptor().TransformBlock(Encoding.Unicode.GetBytes(mainTb.Text), 0, mainTb.TextLength, _new, 0);
            return Encoding.Unicode.GetString(_new);
        }
        private string Rc2Encrypt(string Key)
        {
            RC2CryptoServiceProvider rc2 = new RC2CryptoServiceProvider();
            rc2.Key = Encoding.Unicode.GetBytes(Key);
            rc2.GenerateIV();
            byte[] _new = new byte[mainTb.TextLength];
            rc2.CreateEncryptor().TransformBlock(Encoding.Unicode.GetBytes(mainTb.Text), 0, mainTb.TextLength, _new, 0);
            return Encoding.Unicode.GetString(_new);
        }
        private string Rc2Decrypt(string Key)
        {
            RC2CryptoServiceProvider rc2 = new RC2CryptoServiceProvider();
            rc2.Key = Encoding.Unicode.GetBytes(Key);
            byte[] _new = new byte[mainTb.TextLength];
            rc2.CreateDecryptor().TransformBlock(Encoding.Unicode.GetBytes(mainTb.Text), 0, mainTb.TextLength, _new, 0);
            return Encoding.Unicode.GetString(_new);
        }
        private void CreateKey(object sender, EventArgs e)
        {
            byte[] b = new byte[32]; // 256-bit key
            new RNGCryptoServiceProvider().GetBytes(b);
            if (Clipboard.GetText() != "") {
                if (MessageBox.Show("This will overwrite the contents of your clipboard. Continue?", "Warning", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    Clipboard.SetText(Encoding.ASCII.GetString(b));
                }
            }
            else Clipboard.SetText(Encoding.ASCII.GetString(b));
        }

        private string HashSha256()
        {
            SHA256CryptoServiceProvider sha = new SHA256CryptoServiceProvider();
            return Encoding.ASCII.GetString(sha.ComputeHash(Encoding.Unicode.GetBytes(mainTb.Text)));
        }
        private string HashSha512()
        {
            SHA512CryptoServiceProvider sha = new SHA512CryptoServiceProvider();
            return Encoding.ASCII.GetString(sha.ComputeHash(Encoding.Unicode.GetBytes(mainTb.Text)));
        }
        private string HashMd5()
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return Encoding.ASCII.GetString(md5.ComputeHash(Encoding.Unicode.GetBytes(mainTb.Text)));
        }
        #endregion
        #region Random
        // only returns an actual string for covfefe=false
        private string GenerateString(int letters, bool covfefe, string[] array)
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
                else
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
        private void Covfefe(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            GenerateString(2, true, mainTb.Text.Split(separator));
        }
        private void Add(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            if (int.TryParse(GetOneArgument(), out int i))
            {
                if (i < Settings.Default.MaximumRand)
                {
                    mainTb.Text += GenerateString(i, false, mainTb.Text.Split('\n'));
                }
                else
                {
                    tsMsgReporterLbl.Text = "Error 201: Generating this many letters is prevented in Cinnt in order to protect your data. You can change the limit in Settings.";
                }
            }
        }
        #endregion
        #region Sortation
        private void Reverse(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            mainTb.Text = String.Concat(mainTb.Text.Reverse());
        }
        private void Randomize(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            var lc = new List<char>(mainTb.Text.ToCharArray());
            lc.Shuffle();
            mainTb.Text = String.Concat(lc);
        }
        private void Sort(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            char c = '\n';
            if (argsTb.Text != "") c = argsTb.Text[0];
            List<string> ls = mainTb.Text.Split(c).ToList();
            ls.Sort();
            mainTb.Text = String.Join("\r\n", ls);
        }
        private void Shuffle(object sender, EventArgs e)
        {
            OriginalContent = mainTb.Text;
            char c = '\n';
            if (argsTb.Text != "") c = argsTb.Text[0];
            List<string> list = mainTb.Text.Split(c).ToList();
            list.Shuffle();
            mainTb.Text = String.Join(argsTb.Text[0].ToString(), list);
        }
        #endregion
    }
    static class Ext
    {
        static RNGCryptoServiceProvider r = new RNGCryptoServiceProvider();
        /// <summary>
        /// Shuffles a list of items. Does not return a new list, applies to a specific list. 
        /// </summary>
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
    public override Color StatusStripGradientBegin { get { return Settings.Default.statBC; } }
    public override Color StatusStripGradientEnd { get { return Settings.Default.statBC; } }
}