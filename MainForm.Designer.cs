namespace StationLabelizer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.groupFont = new System.Windows.Forms.GroupBox();
            this.labelFontSecondary = new System.Windows.Forms.Label();
            this.labelFontPrimary = new System.Windows.Forms.Label();
            this.tabContent = new System.Windows.Forms.TabControl();
            this.tabName = new System.Windows.Forms.TabPage();
            this.groupNextS = new System.Windows.Forms.GroupBox();
            this.textNextSubS = new System.Windows.Forms.TextBox();
            this.textNextMainS = new System.Windows.Forms.TextBox();
            this.groupPrevS = new System.Windows.Forms.GroupBox();
            this.textPrevSubS = new System.Windows.Forms.TextBox();
            this.textPrevMainS = new System.Windows.Forms.TextBox();
            this.groupNext = new System.Windows.Forms.GroupBox();
            this.textNextSub = new System.Windows.Forms.TextBox();
            this.textNextMain = new System.Windows.Forms.TextBox();
            this.textNextTop = new System.Windows.Forms.TextBox();
            this.groupPrev = new System.Windows.Forms.GroupBox();
            this.textPrevSub = new System.Windows.Forms.TextBox();
            this.textPrevMain = new System.Windows.Forms.TextBox();
            this.textPrevTop = new System.Windows.Forms.TextBox();
            this.groupNow = new System.Windows.Forms.GroupBox();
            this.textNowSub = new System.Windows.Forms.TextBox();
            this.textNowMain = new System.Windows.Forms.TextBox();
            this.tabDir = new System.Windows.Forms.TabPage();
            this.groupTarget = new System.Windows.Forms.GroupBox();
            this.boxTarget = new System.Windows.Forms.PictureBox();
            this.textTarget = new System.Windows.Forms.TextBox();
            this.textTargetSub = new System.Windows.Forms.TextBox();
            this.groupLine = new System.Windows.Forms.GroupBox();
            this.textLine = new System.Windows.Forms.TextBox();
            this.textLineSub = new System.Windows.Forms.TextBox();
            this.textHead = new System.Windows.Forms.TextBox();
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.labelColorSecondary = new System.Windows.Forms.Label();
            this.labelColorAccent = new System.Windows.Forms.Label();
            this.labelColorPrimary = new System.Windows.Forms.Label();
            this.groupDir = new System.Windows.Forms.GroupBox();
            this.checkWide = new System.Windows.Forms.CheckBox();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.boxImage = new System.Windows.Forms.PictureBox();
            this.bottomStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.proBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelNST = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorLog = new System.Windows.Forms.ColorDialog();
            this.fontLog = new System.Windows.Forms.FontDialog();
            this.saveLog = new System.Windows.Forms.SaveFileDialog();
            this.openLog = new System.Windows.Forms.OpenFileDialog();
            this.groupInfo.SuspendLayout();
            this.groupFont.SuspendLayout();
            this.tabContent.SuspendLayout();
            this.tabName.SuspendLayout();
            this.groupNextS.SuspendLayout();
            this.groupPrevS.SuspendLayout();
            this.groupNext.SuspendLayout();
            this.groupPrev.SuspendLayout();
            this.groupNow.SuspendLayout();
            this.tabDir.SuspendLayout();
            this.groupTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxTarget)).BeginInit();
            this.groupLine.SuspendLayout();
            this.groupColor.SuspendLayout();
            this.groupDir.SuspendLayout();
            this.groupOutput.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxImage)).BeginInit();
            this.bottomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupInfo.Controls.Add(this.btnGen);
            this.groupInfo.Controls.Add(this.groupFont);
            this.groupInfo.Controls.Add(this.tabContent);
            this.groupInfo.Controls.Add(this.groupColor);
            this.groupInfo.Controls.Add(this.groupDir);
            this.groupInfo.Location = new System.Drawing.Point(12, 12);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(200, 414);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "信息设置";
            // 
            // btnGen
            // 
            this.btnGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGen.Location = new System.Drawing.Point(12, 376);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(182, 32);
            this.btnGen.TabIndex = 7;
            this.btnGen.Text = "生成";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // groupFont
            // 
            this.groupFont.Controls.Add(this.labelFontSecondary);
            this.groupFont.Controls.Add(this.labelFontPrimary);
            this.groupFont.Location = new System.Drawing.Point(6, 122);
            this.groupFont.Name = "groupFont";
            this.groupFont.Size = new System.Drawing.Size(188, 56);
            this.groupFont.TabIndex = 6;
            this.groupFont.TabStop = false;
            this.groupFont.Text = "字体设置";
            // 
            // labelFontSecondary
            // 
            this.labelFontSecondary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFontSecondary.Font = new System.Drawing.Font("宋体", 12F);
            this.labelFontSecondary.Location = new System.Drawing.Point(97, 17);
            this.labelFontSecondary.Name = "labelFontSecondary";
            this.labelFontSecondary.Size = new System.Drawing.Size(85, 32);
            this.labelFontSecondary.TabIndex = 5;
            this.labelFontSecondary.Text = "次要字体";
            this.labelFontSecondary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFontSecondary.Click += new System.EventHandler(this.labelFontSecondary_Click);
            // 
            // labelFontPrimary
            // 
            this.labelFontPrimary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFontPrimary.Font = new System.Drawing.Font("宋体", 12F);
            this.labelFontPrimary.Location = new System.Drawing.Point(6, 17);
            this.labelFontPrimary.Name = "labelFontPrimary";
            this.labelFontPrimary.Size = new System.Drawing.Size(85, 32);
            this.labelFontPrimary.TabIndex = 4;
            this.labelFontPrimary.Text = "主要字体";
            this.labelFontPrimary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFontPrimary.Click += new System.EventHandler(this.labelFontPrimary_Click);
            // 
            // tabContent
            // 
            this.tabContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabContent.Controls.Add(this.tabName);
            this.tabContent.Controls.Add(this.tabDir);
            this.tabContent.Location = new System.Drawing.Point(12, 184);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(182, 186);
            this.tabContent.TabIndex = 5;
            // 
            // tabName
            // 
            this.tabName.AutoScroll = true;
            this.tabName.Controls.Add(this.groupNextS);
            this.tabName.Controls.Add(this.groupPrevS);
            this.tabName.Controls.Add(this.groupNext);
            this.tabName.Controls.Add(this.groupPrev);
            this.tabName.Controls.Add(this.groupNow);
            this.tabName.Location = new System.Drawing.Point(4, 22);
            this.tabName.Name = "tabName";
            this.tabName.Padding = new System.Windows.Forms.Padding(3);
            this.tabName.Size = new System.Drawing.Size(174, 160);
            this.tabName.TabIndex = 0;
            this.tabName.Text = "站名标记";
            // 
            // groupNextS
            // 
            this.groupNextS.Controls.Add(this.textNextSubS);
            this.groupNextS.Controls.Add(this.textNextMainS);
            this.groupNextS.Location = new System.Drawing.Point(6, 370);
            this.groupNextS.Name = "groupNextS";
            this.groupNextS.Size = new System.Drawing.Size(145, 72);
            this.groupNextS.TabIndex = 4;
            this.groupNextS.TabStop = false;
            this.groupNextS.Text = "支线下一站";
            // 
            // textNextSubS
            // 
            this.textNextSubS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNextSubS.Location = new System.Drawing.Point(6, 46);
            this.textNextSubS.Name = "textNextSubS";
            this.textNextSubS.Size = new System.Drawing.Size(133, 21);
            this.textNextSubS.TabIndex = 1;
            this.textNextSubS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNextMainS
            // 
            this.textNextMainS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNextMainS.Location = new System.Drawing.Point(6, 20);
            this.textNextMainS.Name = "textNextMainS";
            this.textNextMainS.Size = new System.Drawing.Size(133, 21);
            this.textNextMainS.TabIndex = 0;
            this.textNextMainS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupPrevS
            // 
            this.groupPrevS.Controls.Add(this.textPrevSubS);
            this.groupPrevS.Controls.Add(this.textPrevMainS);
            this.groupPrevS.Location = new System.Drawing.Point(6, 292);
            this.groupPrevS.Name = "groupPrevS";
            this.groupPrevS.Size = new System.Drawing.Size(145, 72);
            this.groupPrevS.TabIndex = 3;
            this.groupPrevS.TabStop = false;
            this.groupPrevS.Text = "支线上一站";
            // 
            // textPrevSubS
            // 
            this.textPrevSubS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrevSubS.Location = new System.Drawing.Point(5, 46);
            this.textPrevSubS.Name = "textPrevSubS";
            this.textPrevSubS.Size = new System.Drawing.Size(133, 21);
            this.textPrevSubS.TabIndex = 1;
            this.textPrevSubS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPrevMainS
            // 
            this.textPrevMainS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrevMainS.Location = new System.Drawing.Point(6, 20);
            this.textPrevMainS.Name = "textPrevMainS";
            this.textPrevMainS.Size = new System.Drawing.Size(133, 21);
            this.textPrevMainS.TabIndex = 0;
            this.textPrevMainS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupNext
            // 
            this.groupNext.Controls.Add(this.textNextSub);
            this.groupNext.Controls.Add(this.textNextMain);
            this.groupNext.Controls.Add(this.textNextTop);
            this.groupNext.Location = new System.Drawing.Point(6, 188);
            this.groupNext.Name = "groupNext";
            this.groupNext.Size = new System.Drawing.Size(145, 98);
            this.groupNext.TabIndex = 2;
            this.groupNext.TabStop = false;
            this.groupNext.Text = "下一站";
            // 
            // textNextSub
            // 
            this.textNextSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNextSub.Location = new System.Drawing.Point(6, 72);
            this.textNextSub.Name = "textNextSub";
            this.textNextSub.Size = new System.Drawing.Size(133, 21);
            this.textNextSub.TabIndex = 2;
            this.textNextSub.Text = "MIAOYU BEI STATION";
            this.textNextSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNextMain
            // 
            this.textNextMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNextMain.Location = new System.Drawing.Point(6, 46);
            this.textNextMain.Name = "textNextMain";
            this.textNextMain.Size = new System.Drawing.Size(133, 21);
            this.textNextMain.TabIndex = 1;
            this.textNextMain.Text = "喵玉北站";
            this.textNextMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNextTop
            // 
            this.textNextTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNextTop.Location = new System.Drawing.Point(6, 20);
            this.textNextTop.Name = "textNextTop";
            this.textNextTop.Size = new System.Drawing.Size(133, 21);
            this.textNextTop.TabIndex = 0;
            this.textNextTop.Text = "下一站  Next Stop";
            this.textNextTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupPrev
            // 
            this.groupPrev.Controls.Add(this.textPrevSub);
            this.groupPrev.Controls.Add(this.textPrevMain);
            this.groupPrev.Controls.Add(this.textPrevTop);
            this.groupPrev.Location = new System.Drawing.Point(6, 84);
            this.groupPrev.Name = "groupPrev";
            this.groupPrev.Size = new System.Drawing.Size(145, 98);
            this.groupPrev.TabIndex = 1;
            this.groupPrev.TabStop = false;
            this.groupPrev.Text = "上一站";
            // 
            // textPrevSub
            // 
            this.textPrevSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrevSub.Location = new System.Drawing.Point(6, 72);
            this.textPrevSub.Name = "textPrevSub";
            this.textPrevSub.Size = new System.Drawing.Size(133, 21);
            this.textPrevSub.TabIndex = 2;
            this.textPrevSub.Text = "NyaSama South Station";
            this.textPrevSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPrevMain
            // 
            this.textPrevMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrevMain.Location = new System.Drawing.Point(6, 46);
            this.textPrevMain.Name = "textPrevMain";
            this.textPrevMain.Size = new System.Drawing.Size(133, 21);
            this.textPrevMain.TabIndex = 1;
            this.textPrevMain.Text = "喵玉南站";
            this.textPrevMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPrevTop
            // 
            this.textPrevTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrevTop.Location = new System.Drawing.Point(6, 20);
            this.textPrevTop.Name = "textPrevTop";
            this.textPrevTop.Size = new System.Drawing.Size(133, 21);
            this.textPrevTop.TabIndex = 0;
            this.textPrevTop.Text = "上一站  Prev Stop";
            this.textPrevTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupNow
            // 
            this.groupNow.Controls.Add(this.textNowSub);
            this.groupNow.Controls.Add(this.textNowMain);
            this.groupNow.Location = new System.Drawing.Point(6, 6);
            this.groupNow.Name = "groupNow";
            this.groupNow.Size = new System.Drawing.Size(145, 72);
            this.groupNow.TabIndex = 0;
            this.groupNow.TabStop = false;
            this.groupNow.Text = "当前站";
            // 
            // textNowSub
            // 
            this.textNowSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNowSub.Location = new System.Drawing.Point(6, 46);
            this.textNowSub.Name = "textNowSub";
            this.textNowSub.Size = new System.Drawing.Size(133, 21);
            this.textNowSub.TabIndex = 1;
            this.textNowSub.Text = "NyaSama Station";
            this.textNowSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNowMain
            // 
            this.textNowMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNowMain.Location = new System.Drawing.Point(6, 20);
            this.textNowMain.Name = "textNowMain";
            this.textNowMain.Size = new System.Drawing.Size(133, 21);
            this.textNowMain.TabIndex = 0;
            this.textNowMain.Text = "喵玉殿";
            this.textNowMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabDir
            // 
            this.tabDir.Controls.Add(this.groupTarget);
            this.tabDir.Controls.Add(this.groupLine);
            this.tabDir.Location = new System.Drawing.Point(4, 22);
            this.tabDir.Name = "tabDir";
            this.tabDir.Padding = new System.Windows.Forms.Padding(3);
            this.tabDir.Size = new System.Drawing.Size(174, 160);
            this.tabDir.TabIndex = 1;
            this.tabDir.Text = "方向指示 ";
            // 
            // groupTarget
            // 
            this.groupTarget.Controls.Add(this.boxTarget);
            this.groupTarget.Controls.Add(this.textTarget);
            this.groupTarget.Controls.Add(this.textTargetSub);
            this.groupTarget.Location = new System.Drawing.Point(6, 84);
            this.groupTarget.Name = "groupTarget";
            this.groupTarget.Size = new System.Drawing.Size(162, 72);
            this.groupTarget.TabIndex = 6;
            this.groupTarget.TabStop = false;
            this.groupTarget.Text = "目标方向";
            // 
            // boxTarget
            // 
            this.boxTarget.Location = new System.Drawing.Point(112, 20);
            this.boxTarget.Name = "boxTarget";
            this.boxTarget.Size = new System.Drawing.Size(44, 46);
            this.boxTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxTarget.TabIndex = 3;
            this.boxTarget.TabStop = false;
            this.boxTarget.DoubleClick += new System.EventHandler(this.boxTarget_DoubleClick);
            // 
            // textTarget
            // 
            this.textTarget.Location = new System.Drawing.Point(6, 20);
            this.textTarget.Name = "textTarget";
            this.textTarget.Size = new System.Drawing.Size(100, 21);
            this.textTarget.TabIndex = 0;
            this.textTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTargetSub
            // 
            this.textTargetSub.Location = new System.Drawing.Point(6, 46);
            this.textTargetSub.Name = "textTargetSub";
            this.textTargetSub.Size = new System.Drawing.Size(100, 21);
            this.textTargetSub.TabIndex = 1;
            this.textTargetSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupLine
            // 
            this.groupLine.Controls.Add(this.textLine);
            this.groupLine.Controls.Add(this.textLineSub);
            this.groupLine.Controls.Add(this.textHead);
            this.groupLine.Location = new System.Drawing.Point(6, 6);
            this.groupLine.Name = "groupLine";
            this.groupLine.Size = new System.Drawing.Size(162, 72);
            this.groupLine.TabIndex = 5;
            this.groupLine.TabStop = false;
            this.groupLine.Text = "线路名";
            // 
            // textLine
            // 
            this.textLine.Location = new System.Drawing.Point(54, 20);
            this.textLine.Name = "textLine";
            this.textLine.Size = new System.Drawing.Size(102, 21);
            this.textLine.TabIndex = 1;
            this.textLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLineSub
            // 
            this.textLineSub.Location = new System.Drawing.Point(6, 46);
            this.textLineSub.Name = "textLineSub";
            this.textLineSub.Size = new System.Drawing.Size(150, 21);
            this.textLineSub.TabIndex = 2;
            this.textLineSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textHead
            // 
            this.textHead.Location = new System.Drawing.Point(6, 20);
            this.textHead.Name = "textHead";
            this.textHead.Size = new System.Drawing.Size(42, 21);
            this.textHead.TabIndex = 0;
            this.textHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.labelColorSecondary);
            this.groupColor.Controls.Add(this.labelColorAccent);
            this.groupColor.Controls.Add(this.labelColorPrimary);
            this.groupColor.Location = new System.Drawing.Point(6, 20);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(188, 48);
            this.groupColor.TabIndex = 4;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "颜色设置";
            // 
            // labelColorSecondary
            // 
            this.labelColorSecondary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorSecondary.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelColorSecondary.Location = new System.Drawing.Point(64, 17);
            this.labelColorSecondary.Name = "labelColorSecondary";
            this.labelColorSecondary.Size = new System.Drawing.Size(59, 24);
            this.labelColorSecondary.TabIndex = 4;
            this.labelColorSecondary.Text = "次要颜色";
            this.labelColorSecondary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelColorSecondary.Click += new System.EventHandler(this.labelColorSecondary_Click);
            // 
            // labelColorAccent
            // 
            this.labelColorAccent.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelColorAccent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorAccent.ForeColor = System.Drawing.Color.White;
            this.labelColorAccent.Location = new System.Drawing.Point(122, 17);
            this.labelColorAccent.Name = "labelColorAccent";
            this.labelColorAccent.Size = new System.Drawing.Size(59, 24);
            this.labelColorAccent.TabIndex = 3;
            this.labelColorAccent.Text = "强调颜色";
            this.labelColorAccent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelColorAccent.Click += new System.EventHandler(this.labelColorAccent_Click);
            // 
            // labelColorPrimary
            // 
            this.labelColorPrimary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorPrimary.Location = new System.Drawing.Point(6, 17);
            this.labelColorPrimary.Name = "labelColorPrimary";
            this.labelColorPrimary.Size = new System.Drawing.Size(59, 24);
            this.labelColorPrimary.TabIndex = 2;
            this.labelColorPrimary.Text = "主要颜色";
            this.labelColorPrimary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelColorPrimary.Click += new System.EventHandler(this.labelColorPrimary_Click);
            // 
            // groupDir
            // 
            this.groupDir.Controls.Add(this.checkWide);
            this.groupDir.Controls.Add(this.radioRight);
            this.groupDir.Controls.Add(this.radioLeft);
            this.groupDir.Location = new System.Drawing.Point(6, 74);
            this.groupDir.Name = "groupDir";
            this.groupDir.Size = new System.Drawing.Size(188, 42);
            this.groupDir.TabIndex = 3;
            this.groupDir.TabStop = false;
            this.groupDir.Text = "指示方向";
            // 
            // checkWide
            // 
            this.checkWide.AutoSize = true;
            this.checkWide.Location = new System.Drawing.Point(160, 22);
            this.checkWide.Name = "checkWide";
            this.checkWide.Size = new System.Drawing.Size(15, 14);
            this.checkWide.TabIndex = 2;
            this.checkWide.UseVisualStyleBackColor = true;
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Location = new System.Drawing.Point(83, 20);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(71, 16);
            this.radioRight.TabIndex = 1;
            this.radioRight.Text = "指向右侧";
            this.radioRight.UseVisualStyleBackColor = true;
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Checked = true;
            this.radioLeft.Location = new System.Drawing.Point(6, 20);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(71, 16);
            this.radioLeft.TabIndex = 0;
            this.radioLeft.TabStop = true;
            this.radioLeft.Text = "指向左侧";
            this.radioLeft.UseVisualStyleBackColor = true;
            // 
            // groupOutput
            // 
            this.groupOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOutput.Controls.Add(this.panelImage);
            this.groupOutput.Location = new System.Drawing.Point(218, 12);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(554, 414);
            this.groupOutput.TabIndex = 1;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "图像输出";
            // 
            // panelImage
            // 
            this.panelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImage.AutoScroll = true;
            this.panelImage.Controls.Add(this.boxImage);
            this.panelImage.Location = new System.Drawing.Point(6, 20);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(542, 388);
            this.panelImage.TabIndex = 1;
            // 
            // boxImage
            // 
            this.boxImage.Location = new System.Drawing.Point(3, 3);
            this.boxImage.Name = "boxImage";
            this.boxImage.Size = new System.Drawing.Size(50, 50);
            this.boxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boxImage.TabIndex = 0;
            this.boxImage.TabStop = false;
            this.boxImage.DoubleClick += new System.EventHandler(this.boxImage_DoubleClick);
            // 
            // bottomStatus
            // 
            this.bottomStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.proBar,
            this.toolStripStatusLabel2,
            this.labelNST});
            this.bottomStatus.Location = new System.Drawing.Point(0, 429);
            this.bottomStatus.Name = "bottomStatus";
            this.bottomStatus.Size = new System.Drawing.Size(784, 22);
            this.bottomStatus.TabIndex = 2;
            this.bottomStatus.Text = "Bottom Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            // 
            // proBar
            // 
            this.proBar.Maximum = 1;
            this.proBar.Name = "proBar";
            this.proBar.Size = new System.Drawing.Size(64, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(8, 17);
            // 
            // labelNST
            // 
            this.labelNST.Name = "labelNST";
            this.labelNST.Size = new System.Drawing.Size(104, 17);
            this.labelNST.Text = "喵玉轨道 © 2020";
            // 
            // fontLog
            // 
            this.fontLog.AllowVerticalFonts = false;
            this.fontLog.Font = new System.Drawing.Font("黑体", 10F);
            this.fontLog.FontMustExist = true;
            this.fontLog.MaxSize = 10;
            this.fontLog.MinSize = 10;
            this.fontLog.ShowEffects = false;
            // 
            // saveLog
            // 
            this.saveLog.DefaultExt = "png";
            this.saveLog.Filter = "PNG Image|*.png";
            this.saveLog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveLog_FileOk);
            // 
            // openLog
            // 
            this.openLog.DefaultExt = "png";
            this.openLog.Filter = "PNG Image|*.png";
            this.openLog.FileOk += new System.ComponentModel.CancelEventHandler(this.openLog_FileOk);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnGen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.bottomStatus);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 490);
            this.Name = "MainForm";
            this.Text = "StationLabelizer - 车站标生成工具";
            this.groupInfo.ResumeLayout(false);
            this.groupFont.ResumeLayout(false);
            this.tabContent.ResumeLayout(false);
            this.tabName.ResumeLayout(false);
            this.groupNextS.ResumeLayout(false);
            this.groupNextS.PerformLayout();
            this.groupPrevS.ResumeLayout(false);
            this.groupPrevS.PerformLayout();
            this.groupNext.ResumeLayout(false);
            this.groupNext.PerformLayout();
            this.groupPrev.ResumeLayout(false);
            this.groupPrev.PerformLayout();
            this.groupNow.ResumeLayout(false);
            this.groupNow.PerformLayout();
            this.tabDir.ResumeLayout(false);
            this.groupTarget.ResumeLayout(false);
            this.groupTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxTarget)).EndInit();
            this.groupLine.ResumeLayout(false);
            this.groupLine.PerformLayout();
            this.groupColor.ResumeLayout(false);
            this.groupDir.ResumeLayout(false);
            this.groupDir.PerformLayout();
            this.groupOutput.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxImage)).EndInit();
            this.bottomStatus.ResumeLayout(false);
            this.bottomStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.GroupBox groupDir;
        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox boxImage;
        private System.Windows.Forms.StatusStrip bottomStatus;
        private System.Windows.Forms.ToolStripStatusLabel labelNST;
        private System.Windows.Forms.TabControl tabContent;
        private System.Windows.Forms.TabPage tabName;
        private System.Windows.Forms.TabPage tabDir;
        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.Label labelColorAccent;
        private System.Windows.Forms.Label labelColorPrimary;
        private System.Windows.Forms.ColorDialog colorLog;
        private System.Windows.Forms.GroupBox groupFont;
        private System.Windows.Forms.Label labelFontSecondary;
        private System.Windows.Forms.Label labelFontPrimary;
        private System.Windows.Forms.GroupBox groupNext;
        private System.Windows.Forms.TextBox textNextSub;
        private System.Windows.Forms.TextBox textNextMain;
        private System.Windows.Forms.TextBox textNextTop;
        private System.Windows.Forms.GroupBox groupPrev;
        private System.Windows.Forms.TextBox textPrevSub;
        private System.Windows.Forms.TextBox textPrevMain;
        private System.Windows.Forms.TextBox textPrevTop;
        private System.Windows.Forms.GroupBox groupNow;
        private System.Windows.Forms.TextBox textNowSub;
        private System.Windows.Forms.TextBox textNowMain;
        private System.Windows.Forms.FontDialog fontLog;
        private System.Windows.Forms.Label labelColorSecondary;
        private System.Windows.Forms.GroupBox groupTarget;
        private System.Windows.Forms.PictureBox boxTarget;
        private System.Windows.Forms.TextBox textTarget;
        private System.Windows.Forms.TextBox textTargetSub;
        private System.Windows.Forms.GroupBox groupLine;
        private System.Windows.Forms.TextBox textLine;
        private System.Windows.Forms.TextBox textLineSub;
        private System.Windows.Forms.TextBox textHead;
        private System.Windows.Forms.GroupBox groupNextS;
        private System.Windows.Forms.TextBox textNextSubS;
        private System.Windows.Forms.TextBox textNextMainS;
        private System.Windows.Forms.GroupBox groupPrevS;
        private System.Windows.Forms.TextBox textPrevSubS;
        private System.Windows.Forms.TextBox textPrevMainS;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ToolStripProgressBar proBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.SaveFileDialog saveLog;
        private System.Windows.Forms.CheckBox checkWide;
        private System.Windows.Forms.OpenFileDialog openLog;
    }
}

