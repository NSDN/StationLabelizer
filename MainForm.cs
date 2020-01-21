using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using static StationLabelizer.TextUtil;

namespace StationLabelizer
{
    public partial class MainForm : Form
    {
        private readonly Bitmap defArrow;

        public MainForm()
        {
            InitializeComponent();

            defArrow = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(defArrow))
            {
                ConfigureGraphics(g);

                Point[] points = new Point[]
                {
                    new Point(10, 20), new Point(90, 50),
                    new Point(10, 80), new Point(30, 50)
                };
                g.FillPolygon(Brushes.Black, points);

                g.Save();
            }
            boxTarget.Image = defArrow;
        }

        private Color GetInvertColor(Color color)
        {
            return Color.FromArgb(-16777216 + 0xFFFFFF - (color.ToArgb() & 0xFFFFFF));
        }

        private void labelColorPrimary_Click(object sender, EventArgs e)
        {
            colorLog.ShowDialog();
            labelColorPrimary.ForeColor = colorLog.Color;
            labelColorPrimary.BackColor = GetInvertColor(colorLog.Color);
        }

        private void labelColorSecondary_Click(object sender, EventArgs e)
        {
            colorLog.ShowDialog();
            labelColorSecondary.ForeColor = colorLog.Color;
            labelColorSecondary.BackColor = labelColorPrimary.BackColor;
        }

        private void labelColorAccent_Click(object sender, EventArgs e)
        {
            colorLog.ShowDialog();
            labelColorAccent.BackColor = colorLog.Color;
        }

        private void labelFontPrimary_Click(object sender, EventArgs e)
        {
            fontLog.ShowDialog();
            labelFontPrimary.Font = fontLog.Font;
        }

        private void labelFontSecondary_Click(object sender, EventArgs e)
        {
            fontLog.ShowDialog();
            labelFontSecondary.Font = fontLog.Font;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            btnGen.Enabled = false;
            proBar.Style = ProgressBarStyle.Marquee;

            Bitmap bitmap = new Bitmap(checkWide.Checked ? 1024 : 768, 256);
            Thread thread;

            bool isRight = radioRight.Checked;

            int width = bitmap.Width, heigh = bitmap.Height;

            Color colorPri = labelColorPrimary.ForeColor;
            Color colorSec = labelColorSecondary.ForeColor;
            Color colorAccent = labelColorAccent.BackColor;

            Font fontPri = labelFontPrimary.Font;
            Font fontSec = labelFontSecondary.Font;

            if (tabContent.SelectedIndex == 0)
            {
                string nowMain = textNowMain.Text;
                string nowSub = textNowSub.Text;

                string prevTop = textPrevTop.Text;
                string prevMain = textPrevMain.Text;
                string prevSub = textPrevSub.Text;

                string nextTop = textNextTop.Text;
                string nextMain = textNextMain.Text;
                string nextSub = textNextSub.Text;

                string prevMainS = textPrevMainS.Text;
                string prevSubS = textPrevSubS.Text;

                string nextMainS = textNextMainS.Text;
                string nextSubS = textNextSubS.Text;

                bool hasPrev = prevMain != "";
                bool hasNext = nextMain != "";

                bool hasPrevS = prevMainS != "";
                bool hasNextS = nextMainS != "";

                thread = new Thread(() =>
                {
                    var main = GenPrimaryStationLabel(
                        nowMain, nowSub, colorPri, fontPri, fontSec);

                    var prev = GenSecondaryStationLabel(
                        prevMain, prevSub, prevTop, colorPri, fontPri, fontSec,
                        isRight ? TextAlign.LEFT : TextAlign.RIGHT);

                    var next = GenSecondaryStationLabel(
                        nextMain, nextSub, nextTop, colorPri, fontPri, fontSec,
                        isRight ? TextAlign.RIGHT : TextAlign.LEFT);

                    int h = 72; float thick = 8;

                    if (checkWide.Checked)
                    {
                        var prevS = GenSecondaryStationLabel(
                        prevMainS, prevSubS, "", colorPri, fontPri, fontSec,
                        isRight ? TextAlign.LEFT : TextAlign.RIGHT);

                        var nextS = GenSecondaryStationLabel(
                            nextMainS, nextSubS, "", colorPri, fontPri, fontSec,
                            isRight ? TextAlign.RIGHT : TextAlign.LEFT);

                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            ConfigureGraphics(g);

                            Pen penA = new Pen(colorAccent, thick);
                            Pen penS = new Pen(colorSec, thick);
                            if (hasPrevS)
                            {
                                g.DrawImage(prevS, isRight ? 0 : width - 256, h - 112);
                                g.DrawLine(penS, isRight ? 0 : width / 16 * 13 - thick * 0.3F - width / 16, h + 48, isRight ? width / 16 * 3 + thick * 0.3F + width / 16 : width, h + 48);
                                g.DrawLine(penS, isRight ? width / 16 * 3 + width / 16 : width / 16 * 13 - width / 16, h + 48, isRight ? width / 4 + width / 16 : width / 4 * 3 - width / 16, h + 160);
                            }
                            if (hasNextS)
                            {
                                g.DrawImage(nextS, isRight ? width - 256 : 0, h - 112);
                                g.DrawLine(penA, isRight ? width / 16 * 13 - thick * 0.3F - width / 16 : 0, h + 48, isRight ? width : width / 16 * 3 + thick * 0.3F + width / 16, h + 48);
                                g.DrawLine(penA, isRight ? width / 16 * 13 - width / 16 : width / 16 * 3 + width / 16, h + 48, isRight ? width / 4 * 3 - width / 16 : width / 4 + width / 16, h + 160);
                            }

                            g.Save();
                        }
                    }

                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        ConfigureGraphics(g);

                        if (hasPrev)
                            g.DrawImage(prev, isRight ? 0 : width - 256, h);
                        g.DrawImage(main, (width - 512) / 2, h);
                        if (hasNext)
                            g.DrawImage(next, isRight ? width - 256 : 0, h);

                        Pen penA = new Pen(colorAccent, thick);
                        Pen penS = new Pen(colorSec, thick);
                        if (hasPrev ^ hasNext)
                        {
                            g.DrawLine(hasNext ? penA : penS, 0, h + 160, width, h + 160);
                        }
                        else
                        {
                            g.DrawLine(isRight ? penS : penA, 0, h + 160, width / 2, h + 160);
                            g.DrawLine(isRight ? penA : penS, width / 2, h + 160, width, h + 160);
                        }

                        g.Save();
                    }
                });
            }
            else
            {
                string head = textHead.Text;
                string line = textLine.Text;
                string lineSub = textLineSub.Text;
                string target = textTarget.Text;
                string targetSub = textTargetSub.Text;
                Image targetArrow = boxTarget.Image;

                thread = new Thread(() =>
                {
                    var label = GenLineLabel(
                        head, line, lineSub, colorPri, colorAccent, fontPri, fontSec,
                        isRight ? TextAlign.LEFT : TextAlign.RIGHT);

                    var tar = GenSecondaryStationLabel(
                        target, targetSub, "", colorPri, fontPri, fontSec, 
                        isRight ? TextAlign.RIGHT : TextAlign.LEFT);

                    int h = 72; float thick = 8;

                    if (targetArrow is null)
                    {
                        targetArrow = new Bitmap(100, 100);
                        using (Graphics g = Graphics.FromImage(targetArrow))
                        {
                            ConfigureGraphics(g);

                            Point[] points = new Point[]
                            {
                                new Point(10, 20), new Point(90, 50),
                                new Point(10, 80), new Point(30, 50)
                            };
                            g.FillPolygon(new SolidBrush(colorPri), points);
                            
                            g.Save();
                        }
                    }

                    if (!isRight)
                    {
                        Bitmap tmp = new Bitmap(targetArrow.Width, targetArrow.Height);
                        using (Graphics g = Graphics.FromImage(tmp))
                        {
                            ConfigureGraphics(g);
                            g.TranslateTransform(targetArrow.Width / 2, targetArrow.Height / 2);
                            g.RotateTransform(180);
                            g.TranslateTransform(-targetArrow.Width / 2, -targetArrow.Height / 2);
                            g.DrawImage(targetArrow, 0, 0);
                            g.Save();
                        }
                        targetArrow = tmp;
                    }
                    
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        ConfigureGraphics(g);

                        g.DrawImage(label, isRight ? 8 : width - 256 - 8, h);
                        g.DrawImage(tar, isRight ? width - 256 - 92 : 92, h);

                        Pen penA = new Pen(colorAccent, thick);
                        g.DrawLine(penA, 0, h + 160, width, h + 160);
                        g.DrawImage(targetArrow,
                            new Rectangle(isRight ? width - 84 : 0, h + 80, 80, 80), 
                            new Rectangle(0, 0, targetArrow.Width, targetArrow.Height),
                            GraphicsUnit.Pixel);

                        g.Save();
                    }
                });
                
            }

            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();

            boxImage.Image = bitmap;

            proBar.Style = ProgressBarStyle.Blocks;
            btnGen.Enabled = true;
        }

        private void boxImage_DoubleClick(object sender, EventArgs e)
        {
            if (boxImage.Image != null)
                saveLog.ShowDialog();
        }

        private void saveLog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            boxImage.Image.Save(saveLog.FileName);
        }

        private void boxTarget_DoubleClick(object sender, EventArgs e)
        {
            openLog.ShowDialog();
        }

        private void openLog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Bitmap bmp = new Bitmap(openLog.FileName);
            boxTarget.Image = bmp;
        }
    }
}
