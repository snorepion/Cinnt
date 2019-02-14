using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Unicode;
using System.Windows.Forms;
using Cinnt.Properties;

namespace Cinnt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Language.Culture = Settings.Default.Culture;
            InitializeComponent();
        }
        #region Miscellaneous/basic things
        bool saved = false;
        string OriginalContent = ""; // used for undo
        string CurrentFilename = "";
        char[] separator = new char[] { ' ', '\r', '\n' };
        private string GetOneArgument()
        {
            return String.Concat(argsTb.Text.TakeWhile(x => !x.Equals(' ')));
        }
        private string[] GetMultipleArguments()
        {
            string[] args = argsTb.Text.Split(' ');
            if (args.Length > 1) return args;
            else { tsMsgReporterLbl.Text = "Error A1: not enough arguments"; return new string[] { " ", " " }; }
        }
        private void WordCountUpdate(object sender, EventArgs e)
        {
            charCntLbl.Text = "Characters: " + mainTb.SelectedText.Replace("\r", "").Length;
            wrdCntLbl.Text = "Words: " + mainTb.SelectedText.Split(new char[] { ' ', '\r' }).TakeWhile(x => !x.Equals("")).ToArray().Length;
            parCntLbl.Text = "Paragraphs: " + mainTb.SelectedText.Split('\r').Length;
            saved = false;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e) // implements all keyboard shortcuts
        {
            if (e.Control)
            {
                if (e.Shift)
                {
                    switch (e.KeyCode)
                    {
                        // in order of their appearance in the menu
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
                else
                {
                    switch (e.KeyCode)
                    {
                        case Keys.F:
                            Find(null, null);
                            break;
                        case Keys.H:
                            Replace(null, null);
                            break;
                        case Keys.N:
                            newBtn_Click(null, null);
                            break;
                        case Keys.O:
                            openBtn_Click(null, null);
                            break;
                        case Keys.S:
                            saveBtn_Click(null, null);
                            break;
                        case Keys.I:
                            italicBtn_Click(null, null);
                            break;
                        case Keys.B:
                            boldBtn_Click(null, null);
                            break;
                        case Keys.U:
                            ulBtn_Click(null, null);
                            break;
                        case Keys.OemPeriod:
                            subBtn_Click(null, null);
                            break;
                        case Keys.Oemcomma:
                            supBtn_Click(null, null);
                            break;
                    }
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
                Settings.Default.Save();
            }
        }
        private void FrmLoad(object sender, EventArgs e)
        {
            BackColor = Settings.Default.uiBC;
            mainTb.Font = Settings.Default.def_fnt;
            ToolStripProfessionalRenderer rend = new ToolStripProfessionalRenderer(new Override()) { RoundedEdges = true };
            statStrip.Renderer = rend;
            statStrip.ForeColor = Settings.Default.btnFC;
            mainMenu.Renderer = rend;
            mainMenu.ForeColor = Settings.Default.btnFC;
            mainMenu.BackColor = Settings.Default.btnBC;
            formattingToolStrip.Renderer = rend;
            formattingToolStrip.ForeColor = Settings.Default.btnFC;
            formattingToolStrip.BackColor = Settings.Default.btnBC;
        }
        private void ClipboardSet(string s)
        {
            if (Clipboard.GetText() != "")
            {
                if (MessageBox.Show("This will overwrite the contents of your clipboard. Continue?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Clipboard.SetText(s);
                }
            }
            else Clipboard.SetText(s);
        }
        private void Revert(object sender, EventArgs e)
        {
            mainTb.SelectedText = OriginalContent;
        }
        private void enterIPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IpaEntryDialog().Show();
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
            OriginalContent = mainTb.SelectedText;
            string[] isolation = mainTb.SelectedText.Split(separator).Where(s => s.StartsWith(GetOneArgument())).ToArray();
            if (isolation.Length == 0)
            {
                tsMsgReporterLbl.Text = "Error 001: Couldn't find an instance of the string you chose.";
            }
            if (isolation.Length > 0)
            {
                tsMsgReporterLbl.Text = "Note: more than one string to isolate was found. This does not affect isolation.";
            }
            mainTb.SelectedText = String.Concat(isolation);
        }
        private void Subtract(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText;
            mainTb.SelectedText = mainTb.SelectedText.Replace(GetOneArgument(), "");
        }
        private void Insert(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText;
            char[] cc = new char[] { ' ', ',', '/', '|' };
            string[] args = GetMultipleArguments();
            string str = mainTb.SelectedText;
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
            mainTb.SelectedText = str;
        }
        private void RemoveLetters(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText;
            string[] args = GetMultipleArguments();
            StringBuilder sb = new StringBuilder();
            if (int.TryParse(args[0], out int i) && int.TryParse(args[1], out int ɪ))
            {
                foreach (string s in mainTb.SelectedText.Split('\n'))
                {
                    if (i < s.Length - 1 && i + ɪ < s.Length - 1)
                    {
                        sb.Append(s);
                        sb.Append("\r\n");
                        sb.Remove(i, ɪ); // removes arg 2 elements from text beginning at argument 1
                    }
                    else
                    {
                        sb.Append(s + "\r\n");
                    }
                }
                mainTb.SelectedText = sb.ToString();
            }
        }
        private void CaseCtrl(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText;
            // implements human-readable arguments for this conversion
            switch (argsTb.Text)
            {
                case "caps":
                    mainTb.SelectedText = CaseControl(mainTb.SelectedText, 0);
                    break;
                case "lower":
                    mainTb.SelectedText = CaseControl(mainTb.SelectedText, 1);
                    break;
                case "sentence":
                    mainTb.SelectedText = CaseControl(mainTb.SelectedText, 2);
                    break;
                case "-sentence":
                    mainTb.SelectedText = CaseControl(mainTb.SelectedText, 3);
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
            if (index == 5) // i do not remember what this is and don't have support for it atm
            {
                string[] alternate = mainTb.SelectedText.Split(new char[] { ' ', '\r', '\n' });
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
            OriginalContent = mainTb.SelectedText;
            string[] s = mainTb.SelectedText.Split('\n');
            int i = 0;
            foreach (string o in s)
            {
                s[i] = " " + s[i];
                i++;
            }
            mainTb.SelectedText = String.Join("\n", s);
        }
        private void UnicodeInsert(object sender, EventArgs e)
        {
            if (GetOneArgument() == "")
            {
                using (CharacterBrowserDialog cbd = new CharacterBrowserDialog())
                {
                    if (cbd.ShowDialog()==DialogResult.OK)
                    {
                        mainTb.SelectedText = mainTb.SelectedText.Insert(mainTb.SelectionStart, cbd.SpecialCharacters);
                    }
                }
            }
            else
            {
                string[] args = GetMultipleArguments();
                if (args[0] == " ") { args = new string[] { GetOneArgument() };  tsMsgReporterLbl.Text = "No messages to report."; }
                StringBuilder addChars = new StringBuilder();
                foreach (string s in args)
                {
                    try
                    {
                        addChars.Append(UnicodeInfo.GetDisplayText(Convert.ToInt32(s)));
                    }
                    catch
                    {
                        tsMsgReporterLbl.Text = "Error U1: Not a Unicode character";
                    }
                }
                mainTb.SelectedText = mainTb.SelectedText.Insert(mainTb.SelectionStart, addChars.ToString());
            }
        }
        #endregion
        #region Find and replace
        private void Find(object sender, EventArgs e)
        {
            Regex r = new Regex(argsTb.Text);
            MatchCollection mc = r.Matches(mainTb.SelectedText);
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
            OriginalContent = mainTb.SelectedText;
            string[] args = GetMultipleArguments();
            Regex.Replace(mainTb.SelectedText, args[0], args[1]);
        }
        #endregion
        #region Format
        private void Format(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText;
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
            mainTb.SelectedText = ReformatString(mainTb.SelectedText, Formats, tsMsgReporterLbl);
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
        private void Hash(object sender, EventArgs e)
        {
            if (GetOneArgument() == Language.ArgSha256Hash)
                ClipboardSet(Encoding.UTF8.GetString(new SHA256CryptoServiceProvider().ComputeHash(Encoding.Unicode.GetBytes(mainTb.SelectedText))));
            else if (GetOneArgument() == Language.ArgSha512Hash)
                ClipboardSet(Encoding.UTF8.GetString(new SHA512CryptoServiceProvider().ComputeHash(Encoding.Unicode.GetBytes(mainTb.SelectedText))));
            else if (GetOneArgument() == Language.ArgMd5Hash)
                ClipboardSet(Encoding.UTF8.GetString(new MD5CryptoServiceProvider().ComputeHash(Encoding.Unicode.GetBytes(mainTb.SelectedText))));
        }
        private string HashSha256()
        {
            SHA256CryptoServiceProvider sha = new SHA256CryptoServiceProvider();
            return Encoding.ASCII.GetString(sha.ComputeHash(Encoding.Unicode.GetBytes(mainTb.SelectedText)));
        }
        private string HashSha512()
        {
            SHA512CryptoServiceProvider sha = new SHA512CryptoServiceProvider();
            return Encoding.ASCII.GetString(sha.ComputeHash(Encoding.Unicode.GetBytes(mainTb.SelectedText)));
        }
        private string HashMd5()
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return Encoding.ASCII.GetString(md5.ComputeHash(Encoding.Unicode.GetBytes(mainTb.SelectedText)));
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
                    if (Language.CanCovfefeize == "Y")
                    {
                        string consonants = Language.CovfefeizeConsonants;
                        string vowels = Language.CovfefeizeVowels;
                        char c;
                        char v;
                        for (int i = 0; i < 1; i++)
                        {
                            c = consonants[r.Next(0, consonants.Length - 1)];
                            sb.Append(c);
                            v = vowels[r.Next(0, vowels.Length - 1)];
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
                        mainTb.SelectedText += Environment.NewLine;
                        mainTb.SelectedText += number.ToString() + ". ";
                        mainTb.SelectedText += s.ToString();
                        sb.Clear();
                        s.Clear();
                        return "";
                    }
                    else
                    {
                        MessageBox.Show(Language.CanCovfefeize);
                    }
                }
                else
                {
                    char a;
                    for (int i = 0; i <= letters; i++)
                    {
                        a = Settings.Default.Alphabet.ToCharArray()[r.Next(Settings.Default.Alphabet.Length)];
                        sb.Append(a);
                    }
                    return sb.ToString();
                }
            }
            return sb.ToString();
        }
        private void Covfefe(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText; 
            GenerateString(2, true, mainTb.SelectedText.Split(separator));
        }
        private void Add(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText;
            if (int.TryParse(GetOneArgument(), out int i))
            {
                if (i <= Settings.Default.MaximumRand)
                {
                    mainTb.SelectedText += GenerateString(i, false, mainTb.SelectedText.Split('\n'));
                }
                else
                {
                    tsMsgReporterLbl.Text = "Error 201: Generating this many letters is prevented in Cinnt in order to protect your data. You can change the limit in Settings.";
                }
            }
            else
            {
                tsMsgReporterLbl.Text = "Error 202: Illegal number";
            }
        }
        #endregion
        #region Sortation
        private void Reverse(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText;
            mainTb.SelectedText = String.Concat(mainTb.SelectedText.Reverse());
        }
        private void Sort(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText;
            char c = '\n';
            if (argsTb.Text != "") c = argsTb.Text[0];
            List<string> ls = mainTb.SelectedText.Split(c).ToList();
            ls.Sort();
            mainTb.SelectedText = String.Join("\r\n", ls);
        }
        private void Shuffle(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText;
            char c = '\n';
            if (argsTb.Text != "") c = argsTb.Text[0];
            else { Randomize(null, null); return; }
            List<string> list = mainTb.SelectedText.Split(c).ToList();
            list.Shuffle();
            mainTb.SelectedText = String.Join(argsTb.Text[0].ToString(), list);
        }
        private void Randomize(object sender, EventArgs e)
        {
            OriginalContent = mainTb.SelectedText;
            var lc = new List<char>(mainTb.SelectedText.ToCharArray());
            lc.Shuffle();
            mainTb.SelectedText = String.Concat(lc);
        }
        #endregion
        #region IO
        private void newBtn_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                if (MessageBox.Show("Your data has not been saved. Continue?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mainTb.Text = "";
                    this.Text = global::Cinnt.Properties.Language.Title + "*";
                }
            }
            else mainTb.Text = "";
        }
        private void openBtn_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                if (MessageBox.Show("Your data has not been saved. Continue?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OpenFile();
                }
            }
            else OpenFile();
        }
        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog() {
                Filter = "Text files|*.txt|Rich text files|*.rtf|All files|*.*",
                Multiselect = false
            };
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                switch (Path.GetExtension(ofd.FileName)) // switch because I initially had some other file types available
                {
                    case ".rtf":
                        mainTb.LoadFile(ofd.FileName);
                        break;
                    default:
                        mainTb.Text = File.ReadAllText(ofd.FileName);
                        break;
                }
                CurrentFilename = ofd.FileName;
                saved = true;
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (CurrentFilename != "")
            {
                switch (Path.GetExtension(CurrentFilename))
                {
                    case ".rtf":
                        mainTb.SaveFile(CurrentFilename);
                        break;
                    default:
                        File.WriteAllText(CurrentFilename, mainTb.Text);
                        break;
                }
                saved = true;
            }
            else SaveFile();
        }
        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Text files|*.txt|Rich text files|*.rtf|All files|*.*"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(sfd.FileName))
                {
                    case ".rtf":
                        mainTb.SaveFile(sfd.FileName);
                        break;
                    default:
                        File.WriteAllText(sfd.FileName, mainTb.Text);
                        break;
                }
                CurrentFilename = sfd.FileName;
                saved = true;
            }
        }
        #endregion
        #region Text style
        private void italicBtn_Click(object sender, EventArgs e)
        {
            if (!mainTb.SelectionFont.Italic) mainTb.SelectionFont = new Font(mainTb.SelectionFont, FontStyle.Italic | mainTb.SelectionFont.Style);
            else mainTb.SelectionFont = new Font(mainTb.SelectionFont, mainTb.SelectionFont.Style & ~FontStyle.Italic);
        }
        private void boldBtn_Click(object sender, EventArgs e)
        {
            if (!mainTb.SelectionFont.Bold) mainTb.SelectionFont = new Font(mainTb.SelectionFont, FontStyle.Bold | mainTb.SelectionFont.Style);
            else mainTb.SelectionFont = new Font(mainTb.SelectionFont, mainTb.SelectionFont.Style & ~FontStyle.Bold);
        }
        private void ulBtn_Click(object sender, EventArgs e)
        {
            if (!mainTb.SelectionFont.Underline) mainTb.SelectionFont = new Font(mainTb.SelectionFont, FontStyle.Underline | mainTb.SelectionFont.Style);
            else mainTb.SelectionFont = new Font(mainTb.SelectionFont, mainTb.SelectionFont.Style & ~FontStyle.Underline);
        }
        private void colorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog()
            {
                Color = mainTb.SelectionColor,
                FullOpen = true
            };
            if (c.ShowDialog() == DialogResult.OK) {
                mainTb.SelectionColor = c.Color;
            }
        }
        private void supBtn_Click(object sender, EventArgs e)
        {
            if (mainTb.SelectionCharOffset != 5) { mainTb.SelectionCharOffset = 5; mainTb.SelectionFont = new Font(mainTb.SelectionFont.FontFamily, mainTb.SelectionFont.Size / 2); }
            else { mainTb.SelectionCharOffset = 0; mainTb.SelectionFont = new Font(mainTb.SelectionFont.FontFamily, mainTb.SelectionFont.Size * 2); }
        }
        private void subBtn_Click(object sender, EventArgs e)
        {
            if (mainTb.SelectionCharOffset != -5) { mainTb.SelectionCharOffset = -5; mainTb.SelectionFont = new Font(mainTb.SelectionFont.FontFamily, mainTb.SelectionFont.Size / 2); }
            else { mainTb.SelectionCharOffset = 0; mainTb.SelectionFont = new Font(mainTb.SelectionFont.FontFamily, mainTb.SelectionFont.Size * 2); }
        }
        private void leftBtn_Click(object sender, EventArgs e) => mainTb.SelectionAlignment = HorizontalAlignment.Left;
        private void centerBtn_Click(object sender, EventArgs e) => mainTb.SelectionAlignment = HorizontalAlignment.Center;
        private void rightBtn_Click(object sender, EventArgs e) => mainTb.SelectionAlignment = HorizontalAlignment.Right;
        private void clearFrmtBtn_Click(object sender, EventArgs e)
        {
            mainTb.SelectionFont = mainTb.Font;
            mainTb.SelectionColor = Settings.Default.tbFC;
            mainTb.SelectionAlignment = HorizontalAlignment.Left;
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
    // status strip
    public override Color StatusStripGradientBegin { get { return Settings.Default.statBC; } }
    public override Color StatusStripGradientEnd { get { return Settings.Default.statBC; } }

    // main menu
    public override Color MenuBorder { get { return Settings.Default.btnBC; } }
    public override Color MenuItemSelected { get { return Settings.Default.btnMoBC; } }
    public override Color MenuItemBorder { get { return Settings.Default.btnBC; } }
    public override Color MenuItemSelectedGradientBegin { get { return Settings.Default.btnMoBC; } }
    public override Color MenuItemSelectedGradientEnd { get { return Settings.Default.btnMoBC; } }
    public override Color MenuItemPressedGradientBegin { get { return Settings.Default.btnMdBC; } }
    public override Color MenuItemPressedGradientEnd { get { return Settings.Default.btnMdBC; } }
    public override Color MenuStripGradientBegin { get { return Settings.Default.statBC; } }
    public override Color MenuStripGradientEnd { get { return Settings.Default.statBC; } }
    public override Color ButtonPressedGradientBegin { get { return Settings.Default.btnMdBC; } }
    public override Color ButtonPressedGradientEnd { get { return Settings.Default.btnMdBC; } }
    public override Color ButtonPressedHighlight { get { return Settings.Default.btnMdBC; } }
    public override Color ButtonPressedBorder { get { return Settings.Default.btnMdBC; } }
    public override Color ButtonPressedHighlightBorder { get { return Settings.Default.btnMdBC; } }
    public override Color ButtonSelectedGradientBegin { get { return Settings.Default.btnMoBC; } }
    public override Color ButtonSelectedGradientEnd { get { return Settings.Default.btnMoBC; } }
    public override Color ButtonSelectedHighlight { get { return Settings.Default.btnMoBC; } }
    public override Color ButtonSelectedBorder { get { return Settings.Default.btnMoBC; } }
    public override Color ButtonSelectedHighlightBorder { get { return Settings.Default.btnMoBC; } }
    public override Color CheckBackground { get { return Settings.Default.btnBC; } }
    public override Color ImageMarginGradientBegin { get { return Settings.Default.btnBC; } }
    public override Color ImageMarginGradientMiddle { get { return Settings.Default.btnBC; } }
    public override Color ImageMarginGradientEnd { get { return Settings.Default.btnBC; } }
    public override Color ToolStripBorder { get { return Settings.Default.statBC; } }
    public override Color ToolStripContentPanelGradientBegin { get { return Settings.Default.statBC; } }
    public override Color ToolStripContentPanelGradientEnd { get { return Settings.Default.statBC; } }
    public override Color ToolStripGradientBegin { get { return Settings.Default.statBC; } }
    public override Color ToolStripGradientMiddle { get { return Settings.Default.statBC; } }
    public override Color ToolStripGradientEnd { get { return Settings.Default.statBC; } }
    public override Color ToolStripPanelGradientBegin { get { return Settings.Default.statBC; } }
    public override Color ToolStripPanelGradientEnd { get { return Settings.Default.statBC; } }
}