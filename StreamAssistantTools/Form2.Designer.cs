namespace WinFormsApp2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            BGWhiteToolStripMenuItem = new ToolStripMenuItem();
            BlackToolStripMenuItem = new ToolStripMenuItem();
            fontSizeSToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            toolStripMenuItem12 = new ToolStripMenuItem();
            toolStripMenuItem13 = new ToolStripMenuItem();
            toolStripMenuItem14 = new ToolStripMenuItem();
            toolStripMenuItem15 = new ToolStripMenuItem();
            toolStripMenuItem16 = new ToolStripMenuItem();
            toolStripMenuItem17 = new ToolStripMenuItem();
            toolStripMenuItem18 = new ToolStripMenuItem();
            FontFamilyToolStripMenuItem1 = new ToolStripMenuItem();
            yuGothicToolStripMenuItem = new ToolStripMenuItem();
            mSゴシックToolStripMenuItem = new ToolStripMenuItem();
            meiryoUIToolStripMenuItem = new ToolStripMenuItem();
            ArialBlackToolStripMenuItem = new ToolStripMenuItem();
            textColorToolStripMenuItem = new ToolStripMenuItem();
            blackBToolStripMenuItem = new ToolStripMenuItem();
            whiteWToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            HHmmssToolStripMenuItem = new ToolStripMenuItem();
            HHmmToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ExitToolStripMenuItem, colorToolStripMenuItem, fontSizeSToolStripMenuItem, FontFamilyToolStripMenuItem1, textColorToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(864, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(117, 36);
            ExitToolStripMenuItem.Text = "終了 (&X)";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click_1;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { defaultToolStripMenuItem, greenToolStripMenuItem, blueToolStripMenuItem, BGWhiteToolStripMenuItem, BlackToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(141, 36);
            colorToolStripMenuItem.Text = "背景色 (&B)";
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(233, 44);
            defaultToolStripMenuItem.Text = "規定 (&D)";
            defaultToolStripMenuItem.Click += DefaultToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(233, 44);
            greenToolStripMenuItem.Text = "緑 (&G)";
            greenToolStripMenuItem.Click += GreenToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(233, 44);
            blueToolStripMenuItem.Text = "青 (&B)";
            blueToolStripMenuItem.Click += BlueToolStripMenuItem_Click;
            // 
            // BGWhiteToolStripMenuItem
            // 
            BGWhiteToolStripMenuItem.Name = "BGWhiteToolStripMenuItem";
            BGWhiteToolStripMenuItem.Size = new Size(233, 44);
            BGWhiteToolStripMenuItem.Text = "白 (&W)";
            BGWhiteToolStripMenuItem.Click += BGWhiteToolStripMenuItem_Click;
            // 
            // BlackToolStripMenuItem
            // 
            BlackToolStripMenuItem.Name = "BlackToolStripMenuItem";
            BlackToolStripMenuItem.Size = new Size(233, 44);
            BlackToolStripMenuItem.Text = "黒 (&K)";
            BlackToolStripMenuItem.Click += BlackToolStripMenuItem_Click;
            // 
            // fontSizeSToolStripMenuItem
            // 
            fontSizeSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem8, toolStripMenuItem9, toolStripMenuItem10, toolStripMenuItem11, toolStripMenuItem12, toolStripMenuItem13, toolStripMenuItem14, toolStripMenuItem15, toolStripMenuItem16, toolStripMenuItem17, toolStripMenuItem18 });
            fontSizeSToolStripMenuItem.Name = "fontSizeSToolStripMenuItem";
            fontSizeSToolStripMenuItem.Size = new Size(190, 36);
            fontSizeSToolStripMenuItem.Text = "フォントサイズ (&S)";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(186, 44);
            toolStripMenuItem2.Text = "8";
            toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(186, 44);
            toolStripMenuItem3.Text = "9";
            toolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(186, 44);
            toolStripMenuItem4.Text = "10";
            toolStripMenuItem4.Click += ToolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(186, 44);
            toolStripMenuItem5.Text = "11";
            toolStripMenuItem5.Click += ToolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(186, 44);
            toolStripMenuItem6.Text = "12";
            toolStripMenuItem6.Click += ToolStripMenuItem6_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(186, 44);
            toolStripMenuItem7.Text = "14";
            toolStripMenuItem7.Click += ToolStripMenuItem7_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(186, 44);
            toolStripMenuItem8.Text = "16";
            toolStripMenuItem8.Click += ToolStripMenuItem8_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(186, 44);
            toolStripMenuItem9.Text = "18";
            toolStripMenuItem9.Click += ToolStripMenuItem9_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(186, 44);
            toolStripMenuItem10.Text = "20";
            toolStripMenuItem10.Click += ToolStripMenuItem10_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(186, 44);
            toolStripMenuItem11.Text = "22";
            toolStripMenuItem11.Click += ToolStripMenuItem11_Click;
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new Size(186, 44);
            toolStripMenuItem12.Text = "24";
            toolStripMenuItem12.Click += ToolStripMenuItem12_Click;
            // 
            // toolStripMenuItem13
            // 
            toolStripMenuItem13.Name = "toolStripMenuItem13";
            toolStripMenuItem13.Size = new Size(186, 44);
            toolStripMenuItem13.Text = "26";
            toolStripMenuItem13.Click += ToolStripMenuItem13_Click;
            // 
            // toolStripMenuItem14
            // 
            toolStripMenuItem14.Name = "toolStripMenuItem14";
            toolStripMenuItem14.Size = new Size(186, 44);
            toolStripMenuItem14.Text = "28";
            toolStripMenuItem14.Click += ToolStripMenuItem14_Click;
            // 
            // toolStripMenuItem15
            // 
            toolStripMenuItem15.Name = "toolStripMenuItem15";
            toolStripMenuItem15.Size = new Size(186, 44);
            toolStripMenuItem15.Text = "36";
            toolStripMenuItem15.Click += ToolStripMenuItem15_Click;
            // 
            // toolStripMenuItem16
            // 
            toolStripMenuItem16.Name = "toolStripMenuItem16";
            toolStripMenuItem16.Size = new Size(186, 44);
            toolStripMenuItem16.Text = "48";
            toolStripMenuItem16.Click += ToolStripMenuItem16_Click;
            // 
            // toolStripMenuItem17
            // 
            toolStripMenuItem17.Name = "toolStripMenuItem17";
            toolStripMenuItem17.Size = new Size(186, 44);
            toolStripMenuItem17.Text = "72";
            toolStripMenuItem17.Click += ToolStripMenuItem17_Click;
            // 
            // toolStripMenuItem18
            // 
            toolStripMenuItem18.Name = "toolStripMenuItem18";
            toolStripMenuItem18.Size = new Size(186, 44);
            toolStripMenuItem18.Text = "144";
            toolStripMenuItem18.Click += ToolStripMenuItem18_Click;
            // 
            // FontFamilyToolStripMenuItem1
            // 
            FontFamilyToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { yuGothicToolStripMenuItem, mSゴシックToolStripMenuItem, meiryoUIToolStripMenuItem, ArialBlackToolStripMenuItem });
            FontFamilyToolStripMenuItem1.Name = "FontFamilyToolStripMenuItem1";
            FontFamilyToolStripMenuItem1.Size = new Size(116, 36);
            FontFamilyToolStripMenuItem1.Text = "書体 (&T)";
            // 
            // yuGothicToolStripMenuItem
            // 
            yuGothicToolStripMenuItem.Name = "yuGothicToolStripMenuItem";
            yuGothicToolStripMenuItem.Size = new Size(270, 44);
            yuGothicToolStripMenuItem.Text = "游ゴシック UI";
            yuGothicToolStripMenuItem.Click += YuGothicToolStripMenuItem_Click;
            // 
            // mSゴシックToolStripMenuItem
            // 
            mSゴシックToolStripMenuItem.Name = "mSゴシックToolStripMenuItem";
            mSゴシックToolStripMenuItem.Size = new Size(270, 44);
            mSゴシックToolStripMenuItem.Text = "MS ゴシック";
            mSゴシックToolStripMenuItem.Click += MSGothicToolStripMenuItem_Click;
            // 
            // meiryoUIToolStripMenuItem
            // 
            meiryoUIToolStripMenuItem.Name = "meiryoUIToolStripMenuItem";
            meiryoUIToolStripMenuItem.Size = new Size(270, 44);
            meiryoUIToolStripMenuItem.Text = "メイリオ UI";
            meiryoUIToolStripMenuItem.Click += MeiryoUIToolStripMenuItem_Click;
            // 
            // ArialBlackToolStripMenuItem
            // 
            ArialBlackToolStripMenuItem.Name = "ArialBlackToolStripMenuItem";
            ArialBlackToolStripMenuItem.Size = new Size(270, 44);
            ArialBlackToolStripMenuItem.Text = "Arial Black";
            ArialBlackToolStripMenuItem.Click += ArialBlackToolStripMenuItem_Click;
            // 
            // textColorToolStripMenuItem
            // 
            textColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blackBToolStripMenuItem, whiteWToolStripMenuItem });
            textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            textColorToolStripMenuItem.Size = new Size(142, 36);
            textColorToolStripMenuItem.Text = "文字色 (&C)";
            // 
            // blackBToolStripMenuItem
            // 
            blackBToolStripMenuItem.Name = "blackBToolStripMenuItem";
            blackBToolStripMenuItem.Size = new Size(214, 44);
            blackBToolStripMenuItem.Text = "黒 (&B)";
            blackBToolStripMenuItem.Click += BlackBToolStripMenuItem_Click;
            // 
            // whiteWToolStripMenuItem
            // 
            whiteWToolStripMenuItem.Name = "whiteWToolStripMenuItem";
            whiteWToolStripMenuItem.Size = new Size(214, 44);
            whiteWToolStripMenuItem.Text = "白 (&W)";
            whiteWToolStripMenuItem.Click += WhiteWToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { HHmmssToolStripMenuItem, HHmmToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(165, 36);
            toolStripMenuItem1.Text = "フォーマット (&F)";
            // 
            // HHmmssToolStripMenuItem
            // 
            HHmmssToolStripMenuItem.Name = "HHmmssToolStripMenuItem";
            HHmmssToolStripMenuItem.Size = new Size(253, 44);
            HHmmssToolStripMenuItem.Text = "HH:mm:ss";
            HHmmssToolStripMenuItem.Click += HHmmssToolStripMenuItem_Click;
            // 
            // HHmmToolStripMenuItem
            // 
            HHmmToolStripMenuItem.Name = "HHmmToolStripMenuItem";
            HHmmToolStripMenuItem.Size = new Size(253, 44);
            HHmmToolStripMenuItem.Text = "HH:mm";
            HHmmToolStripMenuItem.Click += HHmmToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(22, 51);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(815, 254);
            label1.TabIndex = 1;
            label1.Text = "00:00:00";
            label1.Click += label1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Window;
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 362);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 26, 0);
            statusStrip1.Size = new Size(864, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.Control;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 12);
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 384);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form2";
            Text = "時計";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem textColorToolStripMenuItem;
        private ToolStripMenuItem blackBToolStripMenuItem;
        private ToolStripMenuItem whiteWToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem fontSizeSToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem toolStripMenuItem18;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem FontFamilyToolStripMenuItem1;
        private ToolStripMenuItem mSゴシックToolStripMenuItem;
        private ToolStripMenuItem yuGothicToolStripMenuItem;
        private ToolStripMenuItem meiryoUIToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem BGWhiteToolStripMenuItem;
        private ToolStripMenuItem HHmmssToolStripMenuItem;
        private ToolStripMenuItem HHmmToolStripMenuItem;
        private ToolStripMenuItem BlackToolStripMenuItem;
        private ToolStripMenuItem ArialBlackToolStripMenuItem;
    }
}