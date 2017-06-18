using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageLab
{
    class MyBlob
    {

        public struct Moments
        {
            public double M00;
            public double M10;
            public double M20;
            public double M01;
            public double M02;
            public double M11;

            public void resetmoments()
            {
                M00 = 0; M01 = 0; M10 = 0; M11 = 0; M20 = 0; M02 = 0;
            }
        }

        public void CalculateMoments(Bitmap bmp, ref Moments moments)
        {
            moments.resetmoments();
            //Κώδικας σάρωσης εικόνας
            int width = bmp.Width;
            int height = bmp.Height;
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, 
                PixelFormat.Format24bppRgb);
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
                        if (p[i] == 255)
                        {
                            moments.M00++;
                            moments.M10 += x;
                            moments.M01 += y;
                            moments.M11 += x * y;
                            moments.M20 += x * x;
                            moments.M02 += y * y;
                        }
                    }
                }
            }
            bmp.UnlockBits(bmData);
        }

        public Point GravityCenter(Moments moments)
        {
            Point point = new Point();
            if (moments.M00 != 0)
            {
                point.X = (int)(moments.M10 / moments.M00);
                point.Y = (int)(moments.M01 / moments.M00);
            }
            return point;
        }

        public double Theta(Moments moments)
        {
            double theta = 0;
            if (moments.M00 != 0)
            {
                Point gc = GravityCenter(moments);
                double m20 = (moments.M20 / moments.M00) - (gc.X * gc.X);
                double m11 = (moments.M11 / moments.M00) - (gc.X * gc.Y);
                double m02 = (moments.M02 / moments.M00) - (gc.Y * gc.Y);
                theta = 0.5 * Math.Atan(2 * m11 / (m20 - m02));
            }
            return theta;
        }


    }
}
