using System;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace StationLabelizer
{
    class TextUtil
    {
        private static readonly bool DEBUG = false;
        private static readonly int BUF_SIZE = 256;

        public enum TextAlign
        {
            LEFT, RIGHT, CENTER
        }

        private class RawBmp
        {
            private int[] data;
            private int width, height;

            public RawBmp(Bitmap bmp)
            {
                width = bmp.Width; height = bmp.Height;
                data = new int[width * height];
                var dat = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                Marshal.Copy(dat.Scan0, data, 0, width * height);
                bmp.UnlockBits(dat);
            }

            public uint this[int u, int v]
            {
                get
                {
                    if (u >= width) return 0;
                    if (v >= height) return 0;
                    return (uint)data[u + v * width];
                }
            }

            public bool Trans(int u, int v)
            {
                return (this[u, v] >> 24) != 0xFF;
            }
        }

        public static void ConfigureGraphics(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
        }

        private static Bitmap GetString(string str, Color color, Font font)
        {
            if (str == "")
                return new Bitmap(1, 1);

            Bitmap bitmap = new Bitmap(1024, 1024);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                ConfigureGraphics(g);

                g.DrawString(str, font, new SolidBrush(color), 64, 64);

                g.Save();
            }

            RawBmp raw = new RawBmp(bitmap);

            int left, right, up, down;
            for (left = 0; left < bitmap.Width; left++)
            {
                int i;
                for (i = 0; i < bitmap.Height; i++)
                    if (!raw.Trans(left, i))
                        break;
                if (i >= bitmap.Height)
                    continue;
                if (!raw.Trans(left, i))
                    break;
            }
            for (right = bitmap.Width - 1; right > 0; right--)
            {
                int i;
                for (i = 0; i < bitmap.Height; i++)
                    if (!raw.Trans(right, i))
                        break;
                if (i >= bitmap.Height)
                    continue;
                if (!raw.Trans(right, i))
                    break;
            }
            for (up = 0; up < bitmap.Height; up++)
            {
                int i;
                for (i = 0; i < bitmap.Width; i++)
                    if (!raw.Trans(i, up))
                        break;
                if (i >= bitmap.Width)
                    continue;
                if (!raw.Trans(i, up))
                    break;
            }
            for (down = bitmap.Height - 1; down > 0; down--)
            {
                int i;
                for (i = 0; i < bitmap.Width; i++)
                    if (!raw.Trans(i, down))
                        break;
                if (i >= bitmap.Width)
                    continue;
                if (!raw.Trans(i, down))
                    break;
            }

            int width = right - left + 1, height = down - up + 1;
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                ConfigureGraphics(g);

                g.DrawImage(
                    bitmap, 
                    new Rectangle(0, 0, width, height),
                    new Rectangle(left, up, width, height),
                    GraphicsUnit.Pixel);

                g.Save();
            }

            return result;
        }

        private static void DrawImage(Graphics g, Image image, int x, int y, TextAlign align)
        {
            switch (align)
            {
                case TextAlign.LEFT:
                    break;
                case TextAlign.RIGHT:
                    x -= image.Width;
                    break;
                case TextAlign.CENTER:
                    x -= (image.Width / 2);
                    break;
            }
            
            g.DrawImage(image, x, y);
        }

        private static Size DrawString(Graphics g, string str, Color color, Font font, int x, int y, TextAlign align)
        {
            var bmp = GetString(str, color, font);
            DrawImage(g, bmp, x, y, align);
            return new Size(bmp.Width, bmp.Height);
        }

        private static void DrawAccentString(Graphics g, string str, Color color, Font font, int x, int y, TextAlign align, int border = 4)
        {
            Font fnt = new Font(font, FontStyle.Bold);
            var bmp = GetString(str, Color.FromArgb(255, 250, 250, 250), fnt);
            int u = 0, v = y, w = bmp.Width, h = bmp.Height;
            switch (align)
            {
                case TextAlign.LEFT:
                    u = x;
                    break;
                case TextAlign.RIGHT:
                    u = x - w;
                    break;
                case TextAlign.CENTER:
                    u = x - (w / 2);
                    break;
            }
            int xOffset = 0;
            if (w < h)
            {
                xOffset = (h - w) / 2;
                w = h;
            }
            g.FillRectangle(new SolidBrush(color), new Rectangle(u - border, v - border, w + border * 2, h + border * 2));
            DrawImage(g, bmp, x + xOffset, y, align);
        }

        public static Bitmap GenPrimaryStationLabel(string main, string sub, Color color, Font pri, Font sec)
        {
            Bitmap bitmap = new Bitmap(BUF_SIZE * 2, BUF_SIZE, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                ConfigureGraphics(g);

                if (DEBUG)
                    g.DrawRectangle(Pens.Black, 0, 0, BUF_SIZE * 2, BUF_SIZE);

                Font fnt = new Font(pri.FontFamily, 48);
                DrawString(g, main, color, fnt, BUF_SIZE, 64, TextAlign.CENTER);
                fnt = new Font(sec.FontFamily, 20);
                DrawString(g, sub, color, fnt, BUF_SIZE, 128, TextAlign.CENTER);

                g.Save();
            }
            return bitmap;
        }

        public static Bitmap GenSecondaryStationLabel(string main, string sub, string top, Color color, Font pri, Font sec, TextAlign align)
        {
            Bitmap bitmap = new Bitmap(BUF_SIZE, BUF_SIZE, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                ConfigureGraphics(g);

                int x = 0;
                switch (align)
                {
                    case TextAlign.LEFT:
                        x = 0;
                        break;
                    case TextAlign.RIGHT:
                        x = BUF_SIZE;
                        break;
                    case TextAlign.CENTER:
                        x = BUF_SIZE / 2;
                        break;
                }

                if (DEBUG)
                    g.DrawRectangle(Pens.Black, 0, 0, BUF_SIZE, BUF_SIZE);

                Font fnt = new Font(sec.FontFamily, 16);
                DrawString(g, top, color, fnt, x, 64, align);
                fnt = new Font(pri.FontFamily, 24);
                DrawString(g, main, color, fnt, x, 92, align);
                fnt = new Font(sec.FontFamily, 16);
                DrawString(g, sub, color, fnt, x, 128, align);

                g.Save();
            }
            return bitmap;
        }

        public static Bitmap GenLineLabel(string head, string main, string sub, Color color, Color accent, Font pri, Font sec, TextAlign align)
        {
            const int BORDER = 4;
            Bitmap bitmap = new Bitmap(BUF_SIZE, BUF_SIZE, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                ConfigureGraphics(g);

                int x = 0;
                switch (align)
                {
                    case TextAlign.LEFT:
                        x = BORDER;
                        break;
                    case TextAlign.RIGHT:
                        x = BUF_SIZE;
                        break;
                    case TextAlign.CENTER:
                        x = BUF_SIZE / 2;
                        break;
                }

                if (DEBUG)
                    g.DrawRectangle(Pens.Black, 0, 0, BUF_SIZE, BUF_SIZE);

                Font fnt = new Font(pri.FontFamily, 24);
                var size = DrawString(g, main, color, fnt, x, 92, align);
                fnt = new Font(sec.FontFamily, 16);
                DrawString(g, sub, color, fnt, x, 128, align);

                switch (align)
                {
                    case TextAlign.LEFT:
                        x = BORDER;
                        break;
                    case TextAlign.RIGHT:
                        x = x - size.Width;
                        break;
                    case TextAlign.CENTER:
                        x = x - (size.Width / 2);
                        break;
                }

                fnt = new Font(pri.FontFamily, 24);
                var str = GetString(head, color, fnt);
                int yOffset = (size.Height - str.Height) / 2;
                DrawAccentString(g, head, accent, fnt, x, 92 + yOffset, TextAlign.LEFT, BORDER);

                g.Save();
            }
            return bitmap;
        }
    }
}
