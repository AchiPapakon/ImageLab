using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageLab
{
    class MyHistogram
    {
        public int[,] CalculateHistogram(Bitmap bmp)
        {
            int[,] hist = new int[3, 256];
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int i = y * stride + x * 3;
                        hist[0, (int)p[i]]++;
                        hist[1, (int)p[i + 1]]++;
                        hist[2, (int)p[i + 2]]++;
                    }
                }
            }
            bmp.UnlockBits(bmData);
            return hist;
        }

        public Bitmap DrawHistogram(int[,] hist, int color)
        {
            Bitmap histimage = new Bitmap(256, 256);
            int maxvalue = 0;
            for (int i = 0; i < 256; i++)
            {
                if (hist[color, i] > maxvalue) maxvalue = hist[color, i];
            }

            double maxfactor = maxvalue / 255.0;
            int bottom = histimage.Height - 1;
            Graphics g = Graphics.FromImage(histimage);

            using (Pen pen = new Pen(Color.White, 1))
            {
                for (int i = 0; i < 256; i++)
                {
                    g.DrawLine(pen, i, (int)(bottom - hist[color, i] / maxfactor), i, 0);
                }
            }

            using (Pen pen = new Pen(Color.Blue, 1))
            {
                for (int i = 0; i < 256; i++)
                {
                    g.DrawLine(pen, i, bottom, i, (int)(bottom - hist[color, i] / maxfactor));
                }
            }

            g.Dispose();
            return histimage;
        }

        public void Equalization(Bitmap bmp, int[,] hist, int color, int cdfmin, int L)
        {
            //cdfmin = elaxisth fwteinothta (=1)//  L = max fwteinothta(=255)

            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height;
            float MxN = height * width;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int i = y * stride + x * 3;
                        float cdf = 0; int k = p[i];
                        
                        for (int j = 0; j <= k; j++)    //for shmainei {cdfx(i)=SIGMA apo j=0 mexri j=i(px(j)}
                        {
                            cdf += (float)hist[color, j] / MxN;

                            p[i] = p[i + 1] = p[i + 2] = (byte)(Math.Round((cdf - cdfmin / MxN) * (L - 1)));
                        }
                    }
                }
            }
            bmp.UnlockBits(bmData);
        }

    }
}
