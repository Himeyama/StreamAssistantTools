using Microsoft.Win32;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        string dateFormat;
        RegistryKey key;
        int fontSize;
        string fontFamily;
        Color color;

        public Form2()
        {
            InitializeComponent();
        }

        //レジストリに登録
        private void RegEntry(string keyname, object value)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\HikariClock", true);
            key.SetValue(keyname, value);
            key.Close();
        }

        //レジストリ初期化
        private void InitReg()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\HikariClock");
            if (key == null)
            {
                //MessageBox.Show();
                key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\HikariClock");
                dateFormat = "HH:mm:ss";
                key.SetValue("dateFormat", dateFormat);
                fontSize = 72;
                key.SetValue("fontSize", fontSize);
                fontFamily = "Yu Gothic UI";
                key.SetValue("fontFamily", fontFamily);
                key.SetValue("bgColor", "#F0F0F0");
                SetBGColor("#F0F0F0", "規定色");
                key.SetValue("color", "#000000");
                SetTextColor("#000000", "規定色");
            }
            else
            {
                key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\HikariClock");
                dateFormat = (string)key.GetValue("dateFormat");
                fontSize = (int)key.GetValue("fontSize");
                SetFontSize(fontSize);
                fontFamily = (string)key.GetValue("fontFamily");
                SetFontFamily(fontFamily);
                SetBGColor((string)key.GetValue("bgColor"), "規定色");
                SetTextColor((string)key.GetValue("color"), "規定色");
            }
            toolStripStatusLabel1.Text = "";
            key.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitReg();
            timer1.Interval = 200;
            timer1.Enabled = true;
        }

        private void SetFontSize(int fontSize)
        {
            label1.Font = new Font(label1.Font.FontFamily, fontSize);
            this.fontSize = fontSize;
            toolStripStatusLabel1.Text = $"フォントサイズを {fontSize} pt に設定しました";
            RegEntry("fontSize", fontSize);
        }

        private void SetFontFamily(string fontFamily)
        {
            label1.Font = new Font(fontFamily, label1.Font.Size);
            this.fontFamily = fontFamily;
            toolStripStatusLabel1.Text = $"書体を {fontFamily} に設定しました";
            RegEntry("fontFamily", fontFamily);
        }

        private void SetDateFormat(string format)
        {
            this.dateFormat = format;
            RegEntry("dateFormat", this.dateFormat);
            toolStripStatusLabel1.Text = $"形式を {this.dateFormat} に設定しました";
        }

        private void SetBGColor(string color, string chr)
        {
            this.BackColor = ColorTranslator.FromHtml(color);
            RegEntry("bgColor", color);
            toolStripStatusLabel1.Text = $"背景を{chr}に設定しました";
        }

        private void SetTextColor(string color, string chr)
        {
            this.color = ColorTranslator.FromHtml(color);
            label1.ForeColor = this.color;
            RegEntry("color", color);
            toolStripStatusLabel1.Text = $"テキストを{chr}に設定しました";
        }

        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBGColor("#F0F0F0", "規定色");
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBGColor("#00FF00", "緑");
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBGColor("#0000FF", "青");
        }

        private void BGWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBGColor("#FFFFFF", "白");
        }

        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBGColor("#000000", "黒");
        }

        private void BlackBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTextColor("#000000", "黒");
        }

        private void WhiteWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTextColor("#FFFFFF", "白");
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(dateFormat);
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetFontSize(8);
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SetFontSize(9);
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SetFontSize(10);
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SetFontSize(11);
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SetFontSize(12);
        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SetFontSize(14);
        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            SetFontSize(16);
        }

        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            SetFontSize(18);
        }

        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            SetFontSize(20);
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            SetFontSize(22);
        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            SetFontSize(24);
        }

        private void ToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            SetFontSize(26);
        }

        private void ToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            SetFontSize(28);
        }

        private void ToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            SetFontSize(36);
        }

        private void ToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            SetFontSize(48);
        }

        private void ToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            SetFontSize(72);
        }

        private void ToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            SetFontSize(144);
        }

        private void MSGothicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFontFamily("MS Gothis");
        }

        private void YuGothicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFontFamily("Yu Gothic UI");
        }

        private void MeiryoUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFontFamily("Meiryo UI");
        }

        private void ArialBlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFontFamily("Arial Black");
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void HHmmssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDateFormat("HH:mm:ss");
        }

        private void HHmmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDateFormat("HH:mm");
        }
    }
}
