using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ColorReader
{
    public partial class Form1 : Form
    {
        Color FindColor = Color.Black;
        Color c;
        Color SetColor = Color.Red;
        bool picking = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void picOriginal_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Jpg Files|*.jpg|All Files|*.*";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picOriginal.Image = Image.FromFile(dlgOpen.FileName);
            }
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            btnSetColor.Enabled = false;
            Image i = picOriginal.Image;
            Bitmap bm = new Bitmap(i);

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    c = bm.GetPixel(x, y);

                    if (ColorMatch(c))
                        bm.SetPixel(x, y, SetColor);
                }
            }

            picRender.Image = Image.FromHbitmap(bm.GetHbitmap());
            btnSetColor.Enabled = true;
            //BitmapData bmd = bm.LockBits(new Rectangle(0, 0, 10, 10), System.Drawing.Imaging.ImageLockMode.ReadOnly, bm.PixelFormat);
            //int PixelSize = 4;

            //unsafe
            //{
            //    for (int y = 0; y < bmd.Height; y++)
            //    {
            //        byte* row = (byte*)bmd.Scan0 + (y * bmd.Stride);
            //        for (int x = 0; x < bmd.Width; x++)
            //        {
            //            row[x * PixelSize] = 255;
            //        }
            //    }
            //}            
        }

        private bool ColorMatch(Color c)
        {
            if ((c.R < FindColor.R + num.Value && c.R > FindColor.R - num.Value) &&
                (c.G < FindColor.G + num.Value && c.G > FindColor.G - num.Value) &&
                (c.B < FindColor.B + num.Value && c.B > FindColor.B - num.Value))
                return true;

            return false;
        }

        private void pnlFindColor_DoubleClick(object sender, EventArgs e)
        {
            if (dlgFindColor.ShowDialog() == DialogResult.OK)
            {
                FindColor = dlgFindColor.Color;
                pnlFindColor.BackColor = FindColor;
            }
        }

        private void pnlSetColor_DoubleClick(object sender, EventArgs e)
        {
            if (dlgSetColor.ShowDialog() == DialogResult.OK)
            {
                SetColor = dlgSetColor.Color;
                pnlSetColor.BackColor = SetColor;
            }
        }

        private void btnPicker_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            picking = true;
        }

        private void picOriginal_MouseClick(object sender, MouseEventArgs e)
        {
            if (picking)
            {
                Cursor = Cursors.Default;
                picking = false;

                IntPtr hdcScreen = CreateDC("Display", null, null, IntPtr.Zero);
                int cr = (int)GetPixel(hdcScreen, MousePosition.X, MousePosition.Y);
                Color color = Color.FromArgb((cr & 0x000000FF),
                    (cr & 0x0000FF00) >> 8,
                    (cr & 0x00FF0000) >> 16);
                DeleteDC(hdcScreen);

                FindColor = color;
                pnlFindColor.BackColor = FindColor;
            }
        }

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("gdi32.dll")]
        static extern IntPtr CreateDC(string strDriver,
          string strDevice, string strOutput, IntPtr pData);

        [DllImport("gdi32.dll")]
        static extern bool DeleteDC(IntPtr hdc);
    }
}
