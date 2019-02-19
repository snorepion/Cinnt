using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinnt
{
    public partial class LocalizationSelector : Form
    {
        public CultureInfo ChosenCulture { get; set; }
        public CultureInfo[] cultures = new CultureInfo[]
        {
            new CultureInfo("en-GB"),
            new CultureInfo("en-US")
        };
        /* // Commented out since full translations aren't available for these languages
        public CultureInfo[] cultures = new CultureInfo[] {
            new CultureInfo("af-ZA"),
            new CultureInfo("sq-AL"),
            new CultureInfo("ar-EG"),
            new CultureInfo("ar-SY"),
            new CultureInfo("ar-LY"),
            new CultureInfo("ar-IQ"),
            new CultureInfo("ar"),
            new CultureInfo("ar-SA "),
            new CultureInfo("hy-AM"),
            new CultureInfo("az-Latn-AZ"),
            new CultureInfo("bg-BG"),
            new CultureInfo("my-MY"),
            new CultureInfo("zh-HK"),
            new CultureInfo("zh-CN"),
            new CultureInfo("cs-CZ"),
            new CultureInfo("dn-DK"),
            new CultureInfo("et-EE"),
            new CultureInfo("en-GB"),
            new CultureInfo("en-US"),
            new CultureInfo("fi-FI"),
            new CultureInfo("fr-FR"),
            new CultureInfo("ka-GE"),
            new CultureInfo("de-DE"),
            new CultureInfo("el-GR"),
            new CultureInfo("ha-Latn-NG"),
            new CultureInfo("he-IL"),
            new CultureInfo("hi-IN"),
            new CultureInfo("is-IS"),
            new CultureInfo("ig-NG"),
            new CultureInfo("id-ID"),
            new CultureInfo("it-IT"),
            new CultureInfo("ja-JP"),
            new CultureInfo("jv-ID"),
            new CultureInfo("kk-KZ"),
            new CultureInfo("km-KH"),
            new CultureInfo("rw-RW"),
            new CultureInfo("ko-KR"),
            new CultureInfo("ky-KG"),
            new CultureInfo("lv-LV"),
            new CultureInfo("lt-LT"),
            new CultureInfo("lo-LA"),
            new CultureInfo("mk-MK"),
            new CultureInfo("mn-MN"),
            new CultureInfo("nl-NL"),
            new CultureInfo("nb-NO"),
            new CultureInfo("ps-AF"),
            new CultureInfo("fa-IR"),
            new CultureInfo("pl-PL"),
            new CultureInfo("pt-BR"),
            new CultureInfo("ro-RO"),
            new CultureInfo("ru-RU"),
            new CultureInfo("hr-HR"),
            new CultureInfo("sr-Cyrl-RS"),
            new CultureInfo("sk-SK"),
            new CultureInfo("sl-SI"),
            new CultureInfo("es-ES"),
            new CultureInfo("sw-KE"),
            new CultureInfo("sv-SE"),
            new CultureInfo("tg-Cyrl-TJ"),
            new CultureInfo("fil-PH"),
            new CultureInfo("ta-IN"),
            new CultureInfo("th-TH"),
            new CultureInfo("tr-TR"),
            new CultureInfo("tk-TM"),
            new CultureInfo("uk-UA"),
            new CultureInfo("ur-PK"),
            new CultureInfo("uz-Latn-UZ"),
            new CultureInfo("uz-Cyrl-UZ"),
            new CultureInfo("vi-VN"),
            new CultureInfo("cy-GB"),
            new CultureInfo("yo-NG"),
            new CultureInfo("zu-ZA")
        }; */
        public LocalizationSelector(string path)
        {
            InitializeComponent();
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            ChosenCulture = cultures[locLb.SelectedIndex];
            DialogResult = DialogResult.OK;
            MessageBox.Show("To apply your changes, restart the program.");
            this.Close();
        }
        private void LocalizationSelector_Load(object sender, EventArgs e)
        {
            okBtn.FlatAppearance.MouseDownBackColor = Properties.Settings.Default.btnMdBC;
            okBtn.FlatAppearance.MouseOverBackColor = Properties.Settings.Default.btnMoBC;
        }
    }
}
