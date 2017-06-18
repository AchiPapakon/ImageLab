using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageLab
{
    class clsFilters
    {
        public void Min(Bitmap bmp)
        {
            Bitmap source = (Bitmap)bmp.Clone();
            List<int> rlist = new List<int>();
            List<int> glist = new List<int>();
            List<int> blist = new List<int>();

            BitmapData bmData2 = source.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan2 = bmData2.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan2;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int ir = y + i;
                                int jr = x + j;
                                if (ir < 0) ir = 0;
                                if (jr < 0) jr = 0;
                                if (ir >= height) ir = height - 1;
                                if (jr >= width) jr = width - 1;

                                blist.Add((int)p2[ir * stride + jr * 3]);
                                glist.Add((int)p2[ir * stride + jr * 3 + 1]);
                                rlist.Add((int)p2[ir * stride + jr * 3 + 2]);
                            }
                        }
                        p[y * stride + x * 3] = (byte)blist.Min();
                        p[y * stride + x * 3 + 1] = (byte)glist.Min();
                        p[y * stride + x * 3 + 2] = (byte)rlist.Min();
                        rlist.Clear();
                        glist.Clear();
                        blist.Clear();
                    }
                }
            }
            bmp.UnlockBits(bmData);
            source.UnlockBits(bmData2);
            source.Dispose();
        }

        public void Max(Bitmap bmp)
        {
            Bitmap source = (Bitmap)bmp.Clone();
            List<int> rlist = new List<int>();
            List<int> glist = new List<int>();
            List<int> blist = new List<int>();

            BitmapData bmData2 = source.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan2 = bmData2.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan2;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int ir = y + i;
                                int jr = x + j;
                                if (ir < 0) ir = 0;
                                if (jr < 0) jr = 0;
                                if (ir >= height) ir = height - 1;
                                if (jr >= width) jr = width - 1;

                                blist.Add((int)p2[ir * stride + jr * 3]);
                                glist.Add((int)p2[ir * stride + jr * 3 + 1]);
                                rlist.Add((int)p2[ir * stride + jr * 3 + 2]);
                            }
                        }
                        p[y * stride + x * 3] = (byte)blist.Max();
                        p[y * stride + x * 3 + 1] = (byte)glist.Max();
                        p[y * stride + x * 3 + 2] = (byte)rlist.Max();
                        rlist.Clear();
                        glist.Clear();
                        blist.Clear();
                    }
                }
            }
            bmp.UnlockBits(bmData);
            source.UnlockBits(bmData2);
            source.Dispose();
        }

        public void Mean(Bitmap bmp)
        {
            Bitmap source = (Bitmap)bmp.Clone();
            List<int> rlist = new List<int>();
            List<int> glist = new List<int>();
            List<int> blist = new List<int>();

            BitmapData bmData2 = source.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan2 = bmData2.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan2;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int ir = y + i;
                                int jr = x + j;
                                if (ir < 0) ir = 0;
                                if (jr < 0) jr = 0;
                                if (ir >= height) ir = height - 1;
                                if (jr >= width) jr = width - 1;

                                blist.Add((int)p2[ir * stride + jr * 3]);
                                glist.Add((int)p2[ir * stride + jr * 3 + 1]);
                                rlist.Add((int)p2[ir * stride + jr * 3 + 2]);
                            }
                        }
                        p[y * stride + x * 3] = (byte)(blist.Sum() / blist.Count());
                        p[y * stride + x * 3 + 1] = (byte)(glist.Sum() / glist.Count());
                        p[y * stride + x * 3 + 2] = (byte)(rlist.Sum() / rlist.Count());
                        rlist.Clear();
                        glist.Clear();
                        blist.Clear();
                    }
                }
            }
            bmp.UnlockBits(bmData);
            source.UnlockBits(bmData2);
            source.Dispose();
        }

        public void Median(Bitmap bmp)
        {
            Bitmap source = (Bitmap)bmp.Clone();
            List<int> rlist = new List<int>();
            List<int> glist = new List<int>();
            List<int> blist = new List<int>();

            BitmapData bmData2 = source.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan2 = bmData2.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan2;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int ir = y + i;
                                int jr = x + j;
                                if (ir < 0) ir = 0;
                                if (jr < 0) jr = 0;
                                if (ir >= height) ir = height - 1;
                                if (jr >= width) jr = width - 1;

                                blist.Add((int)p2[ir * stride + jr * 3]);
                                glist.Add((int)p2[ir * stride + jr * 3 + 1]);
                                rlist.Add((int)p2[ir * stride + jr * 3 + 2]);
                            }
                        }
                        rlist.Sort();
                        glist.Sort();
                        blist.Sort();
                        p[y * stride + x * 3] = (byte)blist[4];
                        p[y * stride + x * 3 + 1] = (byte)glist[4];
                        p[y * stride + x * 3 + 2] = (byte)rlist[4];
                        rlist.Clear();
                        glist.Clear();
                        blist.Clear();
                    }
                }
            }
            bmp.UnlockBits(bmData);
            source.UnlockBits(bmData2);
            source.Dispose();
        }
    }
}
