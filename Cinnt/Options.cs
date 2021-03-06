﻿using Cinnt.Properties;
using System;
using System.Configuration;
using System.Configuration.Assemblies;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.IO;

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
            Process.Start("https://github.com/snorepion/Cinnt/issues/new?title=[v1.0.0.0R]&body=[v1.0.0.0R]&labels=bug");
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
        Color[] sc = new Color[] { Settings.Default.tbBC, Settings.Default.tbFC, Settings.Default.btnBC, Settings.Default.btnMoBC, Settings.Default.btnMdBC, Settings.Default.btnFC, Settings.Default.uiBC, Settings.Default.matchC, Settings.Default.statBC };
        private void applyBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Color c in cc)
            {
                if (c != sc[i]) {
                    if (i == 0) Settings.Default.tbBC = c;
                    if (i == 1) Settings.Default.tbFC = c;
                    if (i == 2) Settings.Default.btnBC = c;
                    if (i == 3) Settings.Default.btnMoBC = c;
                    if (i == 4) Settings.Default.btnMdBC = c;
                    if (i == 5) Settings.Default.btnFC = c;
                    if (i == 6) Settings.Default.uiBC = c;
                    if (i == 7) Settings.Default.matchC = c;
                    if (i == 8) Settings.Default.statBC = c;
                }
                i++;
            }
            Settings.Default.Save();
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            Font f = Settings.Default.def_fnt; // reset doesn't change default font
            Settings.Default.Reset();
            Settings.Default.def_fnt = f;
        }
        ColorDialog cd = new ColorDialog();
        Color[] cc = new Color[] { Settings.Default.tbBC, Settings.Default.tbFC, Settings.Default.btnBC, Settings.Default.btnMoBC, Settings.Default.btnMdBC, Settings.Default.btnFC, Settings.Default.uiBC, Settings.Default.matchC, Settings.Default.statBC };
        private void modBtn_Click(object sender, EventArgs e)
        {
            cd.Color = cc[colorSelectLb.SelectedIndex];
            if (cd.ShowDialog()==DialogResult.OK)
            {
                cc[colorSelectLb.SelectedIndex] = cd.Color;
            }
        }
        private void alphabetCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            alphTb.Text = WritingSystems.GetAll()[alphabetCb.SelectedIndex];
        }
        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save non-personalization settings
            Settings.Default.MaximumRand = (int)maxLetterNud.Value * 1024;
            Settings.Default.WordWrap = wordWrapCb.Checked;
            Settings.Default.Alphabet = alphTb.Text;
            Settings.Default.Save();
        }
        private void localizSelBtn_Click(object sender, EventArgs e)
        {
            string loc = System.Reflection.Assembly.GetEntryAssembly().Location + "/local/";
            using (LocalizationSelector l = new LocalizationSelector(loc))
            {
                if (l.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.Culture = l.ChosenCulture;
                    Settings.Default.Save();
                }
            }
        }
        private void Options_Load(object sender, EventArgs e)
        {
            // These values are deleted if they are in InitializeComponent(), so they will be implemented on form load.
            this.localizSelBtn.FlatAppearance.MouseDownBackColor = Settings.Default.btnMdBC;
            this.localizSelBtn.FlatAppearance.MouseOverBackColor = Settings.Default.btnMoBC;
            this.modBtn.FlatAppearance.MouseDownBackColor = Settings.Default.btnMdBC;
            this.modBtn.FlatAppearance.MouseOverBackColor = Settings.Default.btnMoBC;
            this.applyBtn.FlatAppearance.MouseDownBackColor = Settings.Default.btnMdBC;
            this.applyBtn.FlatAppearance.MouseOverBackColor = Settings.Default.btnMoBC;
            this.uiFntBtn.FlatAppearance.MouseDownBackColor = Settings.Default.btnMdBC;
            this.uiFntBtn.FlatAppearance.MouseOverBackColor = Settings.Default.btnMoBC;
            this.resetBtn.FlatAppearance.MouseDownBackColor = Settings.Default.btnMdBC;
            this.resetBtn.FlatAppearance.MouseOverBackColor = Settings.Default.btnMoBC;
        }
    }
    static class WritingSystems
    {
        public const string LatinNoCaps = "abcdefghijklmnopqrstuvwxyz";
        public const string LatinCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public const string CyrillicNoCaps = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public const string CyrillicCaps = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public const string Arabic = "ضصشسزرذدخحجثتباءيوهنملكقفغعظط";
        public const string Devanagari = "कखगघङचछजझञटठडढणतथदधनपफबभमक़ख़ग़ज़ड़ढ़फ़यरलळवहशषसअआइईउऊऋॠऌॡएऐओऔ"; //might not be formatted right
        public const string JapaneseHiragana = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよらりるれろわをん";
        public const string JapaneseKatakana = "アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲン";
        public const string JapaneseKana = JapaneseHiragana + JapaneseKatakana;
        public const string Syriac = "ܟܝܛܚܙܘܗܕܓܒܐܬܫܪܩܨܦܥܣܢܡܠ";
        public const string ArmenianNoCaps = "աբգդեզէըթժիլխծկհձղճմյնշոչպջռսվտրցւփքօֆև";
        public const string ArmenianCaps = "ԱԲԳԴԵԶԷԸԹԺԻԼԽԾԿՀՁՂՃՄՅՆՇՈՉՊՋՌՍՎՏՐՑՒՓՔՕՖևաբգդեզէըթժիլխծկհձղճմյնշոչպջռսվտրցւփքօֆև";
        public const string GeorgianModern = "აბგდევზთიკლმნოპზჰრსტუფქღყშჩცძწჭხჯჰ";
        public const string Geez = "ሀሁሂሃሄህሆለሉሊላሌልሎሏሐሑሒሓሔሕሖሗመሙሚማሜምሞሟሠሡሢሣሤሥሦሧረሩሪራሬርሮሯሰሱሲሳሴስሶሷሸሹሺሻሼሽሾሿቀቁቂቃቄቅቆቇቐቑቒቓቔቕቖበቡቢባቤብቦቧቨቩቪቫቬቭቮቯተቱቲታቴትቶቷቸቹቺቻቼችቾቿኀኁኂኃኄኅኆኇነኑኒናኔንኖኗኘኙኚኛኜኝኞኟአኡኢኣኤእኦኧከኩኪካኬክኮኯኸኹኺኻኼኽኾወዉዊዋዌውዎዐዑዒዓዔዕዖዘዙዚዛዜዝዞዟዠዡዢዣዤዥዦዧየዩዪያዬይዮዯደዱዲዳዴድዶዷዸዹዺዻዼዽዾዿጀጁጂጃጄጅጆጇገጉጊጋጌግጎጏጘጙጚጛጜጝጞጟጠጡጢጣጤጥጦጧጨጩጪጫጬጭጮጯጰጱጲጳጴጵጶጷጸጹጺጻጼጽጾጿጸጹጺጻጼጽጾጿፀፁፂፃፄፅፆፇፈፉፊፋፌፍፎፏፐፑፒፓፔፕፖፗቈቊቋቌቍቘቚቛቜቝኈኊኋኌኍኰኲኳኴኵዀዂዃዄዅጐጒጓጔጕ";
        public const string Cree = "ᐁᐃᐅᐊᐄᐆᐋᐯᐱᐳᐸᐲᐴᐹᑉᑌᑎᑐᑕᑏᑑᑖᑦᑫᑭᑯᑲᑮᑰᑳᒃᒉᒋᒍᒐᒌᒎᒑᒡᒣᒥᒧᒪᒦᒨᒫᒻᓀᓂᓄᓇᓃᓅᓈᓐᓭᓯᓱᓴᓰᓲᓵᔅᔐᔑᔓᔕᔒᔔᔖᔥᔦᔨᔪᔭᔩᔫᔮᔾᕃᕆᕈᕋᕇᕉᕌᕐᓓᓕᓗᓚᓖᓘᓛᓪᕓᕕᕗᕙᕖᕘᕚᕝᕞᕠᕤᕦᕢᕥᕧᕪᐌᐎᐒᐗᐐᐔᐙᐤᐦᐁᐦᐃᐦᐅᐦᐊᐦᐄᐦᐆᐦᐋᐦ"; // eastern, includes finals
        public const string Inuktitut = "ᐁᐃᐄᐅᐆᐊᐋᐦᐯᐱᐲᐳᐴᐸᐹᑉᑌᑎᑏᑐᑑᑕᑖᑦᑫᑭᑮᑯᑰᑲᑳᒃᒉᒋᒌᒍᒎᒐᒑᒡᒣᒥᒦᒧᒨᒪᒫᒻᓀᓂᓃᓄᓅᓇᓈᓐᓭᓯᓰᓱᓲᓴᓵᔅᓓᓕᓖᓗᓘᓚᓛᓪᔦᔨᔩᔪᔫᔭᔮᔾᕓᕕᕖᕗᕘᕙᕚᕝᕃᕆᕇᕈᕉᕋᕌᕐᙯᕿᖀᖁᖂᖃᖄᖅᙰᖏᖐᖑᖒᖓᖔᖕᙱᙲᙳᙴᙵᙶᖖᖠᖡᖢᖣᖤᖥᖦ"; //includes long vowels & finals
        public const string Cherokee = "ᎠᎡᎢᎣᎤᎥᎦᎧᎨᎩᎪᎫᎬᎭᎮᎯᎰᎱᎲᎳᎴᎵᎶᎷᎸᎹᎺᎻᎼᎽᏵᎾᎿᏀᏁᏂᏃᏄᏅᏆᏇᏈᏉᏊᏋᏍᏌᏎᏏᏐᏑᏒᏓᏔᏕᏖᏗᏘᏙᏚᏛᏜᏝᏞᏟᏠᏡᏢᏣᏤᏥᏦᏧᏨᏩᏪᏫᏬᏭᏮᏯᏰᏱᏲᏳᏴ"; // no capital/lowercase differentiation
        public const string GreekNoCaps = "αβγδεζηθικλμνξοπρστυφχψω";
        public const string GreekCaps = "ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρστυφχψω";
        public const string Mandaic = "ࡀࡁࡂࡃࡄࡅࡆࡇࡈࡉࡊࡋࡌࡎࡏࡐࡑࡒࡓࡔࡕࡖ"; // the final ࡀ is not included here so that it doesn't have a larger chance of being included, despite its position in the alphabet
        public const string Vai = "ꔀꔤꕉꕱꖕꖺꗡꔁꔥꕊꕲꖖꖻꗢꕋꖼꗣꔂꔦꕌꕳꖗꖽꗤꔧꕍꖘꖾꗥꔃꔨꕎꕴꖙꖿꗦꔄꔩꕏꕵꖚꗀꗧꔅꔪꕐꕶꖛꗁꗨꔆꔫꕑꕷꖜꗂꗩꔇꔬꕒꕸꖝꗃꗪꔈꔭꕓꕹꖞꗄꗫꔉꔮꕔꕺꖟꗅꗬꕕꗭꔊꔯꕖꕻꖠꗆꗮꔋꔰꕗꕼꖡꗇꗯꗈꗰꔌꔱꕘꕽꖢꗉꗱꔍꔲꕙꕾꖣꗊꗲꔎꔳꕚꕿꖤꗋꗳꔏꔴꕛꖀꖥꗌꗴꔐꔵꕜꖁꖦꗍꗵꔑꔶꕝꖂꖧꗎꗶꔒꔷꕞꖃꖨꗏꗷꔓꔸꕟꖄꖩꗐꗸꔔꔹꕠꖅꖪꗑꗹꔕꔺꕡꖆꖫꗒꗺꔖꔻꕢꖇꖬꗓꗻꔗꔼꕣꖈꖭꗔꗼꔘꔽꕤꖉꖮꗕꗽꔙꔾꕥꖊꖯꗖꗾꔚꔿꕦꖋꖰꗗꗿꔛꕀꕧꖌꖱꗘꘀꔜꕁꕨꖍꖲꗙꘁꔝꕂꕩꖎꖳꗚꘂꔞꕃꕪꖏꖴꗛꘃꕫꔟꕄꕬꖐꖵꗜꘄꘅꔠꕅꕭꖑꖶꗝꘆꘇꔡꕆꕮꖒꖷꗞꘈꔢꕇꕯꖓꖸꗟꘉꔣꕈꕰꖔꖹꗠꘊ";
        // Perso-Arabic, Hebrew, Tamil, Thai, and Khmer forthcoming
        public static string[] GetAll()
        {
            return new string[]
            {
                LatinNoCaps,
                LatinCaps,
                CyrillicNoCaps,
                CyrillicCaps,
                Arabic,
                Devanagari,
                JapaneseHiragana,
                JapaneseKatakana,
                JapaneseKana,
                Syriac,
                ArmenianNoCaps,
                ArmenianCaps,
                GeorgianModern,
                Geez,
                Cree,
                Inuktitut,
                Cherokee,
                GreekNoCaps,
                GreekCaps,
                Mandaic,
                Vai
            };
        }
    }
}
