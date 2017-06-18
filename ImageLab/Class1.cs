using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageLab
{
    class Class1
    {
        public enum colorz{B, G, R};
        public int erosion = 0; 
        public int delation = 255;


        public void make(Bitmap bmp, colorz a)
        {
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
                        byte gray = (byte)(0.11 * p[i] + 0.59 * p[i + 1] + 0.3 * p[i + 2]);
                        switch (a)
                        {
                            case colorz.B:
                                p[i + (int)colorz.B] = gray;
                                p[i + (int)colorz.R] = 0;
                                p[i + (int)colorz.G] = 0;
                                break;
                            case colorz.G:
                                p[i + (int)colorz.G] = gray;
                                p[i + (int)colorz.R] = 0;
                                p[i + (int)colorz.B] = 0;
                                break;
                            case colorz.R:
                                p[i + (int)colorz.R] = gray;
                                p[i + (int)colorz.B] = 0;
                                p[i + (int)colorz.G] = 0;
                                break;
                        }
                    }
                }
            }
            bmp.UnlockBits(bmData);
        }

        public void grayscale(Bitmap bmp)
        {
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
                        byte tone = (byte)(0.114 * p[i] + 0.587 * p[i + 1] + 0.299 * p[i + 2]);

                        p[i] = tone;
                        p[i + 1] = tone;
                        p[i + 2] = tone;
                    }
                }
            }
            bmp.UnlockBits(bmData);
        }

        public void binarize(Bitmap image, int thr)
        {
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = image.Width, height = image.Height;
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
                        if (p[i] <= thr) p[i] = p[i + 1] = p[i + 2] = 0;
                        else p[i] = p[i + 1] = p[i + 2] = (byte)255;  
                    }
                }
            }
            image.UnlockBits(bmData);
        }

        public void YCbCr(Bitmap image, string a)
        {
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = image.Width, height = image.Height;
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
                        byte b = p[i];
                        byte g = p[i + 1];
                        byte r = p[i + 2];

                        switch (a)
                        {
                            case "Y":
                                p[i] = p[i + 1] = p[i + 2] = (byte)(0.1145 * b + 0.5866 * g + 0.2989 * r);
                                break;
                            case "Cb":
                                p[i] = p[i + 1] = p[i + 2] = (byte)(0.500 * b - 0.3312 * g - 0.1688 * r);
                                break;
                            case "Cr":
                                p[i] = p[i + 1] = p[i + 2] = (byte)(-0.0816 * b - 0.4184 * g + 0.500 * r);
                                break;
                        }
                    }
                }
            }
            image.UnlockBits(bmData);
        }

        public void clear_cbcr(Bitmap image)
        {
            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = image.Width, height = image.Height;
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
                        if (p[i] >= 230) p[i] = p[i + 1] = p[i + 2] = 0;
                    }
                }
            }
            image.UnlockBits(bmData);
        }

        public void Capture(Bitmap bmp)
        {
            Bitmap source = (Bitmap)bmp.Clone();

            //κλειδώνουμε και τις 2 εικόνες και έχουμε δύο δείκτες για τις 2 εικόνες.
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmData2 = source.LockBits(new Rectangle(0, 0, source.Width, source.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan2 = bmData2.Scan0;
            unsafe
            {
                byte* p1 = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan2;

                //σάρωση γειτονιάς
                for (int y = 0; y < source.Height; y++)
                {
                    for (int x = 0; x < source.Width; x++)
                    {
                        int counter = 0;
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int ir = y + i;         int jr = x + j;
                                if (ir < 0) ir = 0;     if (jr < 0) jr = 0; //gia oria eikonas panw i aristera
                                if (ir >= source.Height) ir = source.Height - 1; if (jr >= source.Width) jr = source.Width - 1; //de3ia i katw

                                int k = ir * stride + jr * 3;
                                //p1[ir * stride + jr] einai to pixel tis geitonias
                                if ((i == 0 && j == 0) == false) { if (p2[k] == 255) counter++; }
                            }
                            if(counter == 8)
                            {
                                p1[y * stride + x * 3] = 0;
                                p1[y * stride + x * 3 + 1] = 0;
                                p1[y * stride + x * 3 + 2] = 0;
                            }
                        }
                        counter=0;
                    }
                }
                //σάρωση εικόνας
                //if (p2[] == ……)
                //p1[] = ;
            }
            bmp.UnlockBits(bmData);
            source.UnlockBits(bmData2);
            source.Dispose();
        }

        public void ErosionDelation(Bitmap bmp, int aa)
        {
            Bitmap source = (Bitmap)bmp.Clone();

            //κλειδώνουμε και τις 2 εικόνες και έχουμε δύο δείκτες για τις 2 εικόνες.
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmData2 = source.LockBits(new Rectangle(0, 0, source.Width, source.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr Scan2 = bmData2.Scan0;
            unsafe
            {
                byte* p1 = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan2;

                //σάρωση γειτονιάς
                for (int y = 0; y < source.Height; y++)
                {
                    for (int x = 0; x < source.Width; x++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int ir = y + i;         int jr = x + j;
                                if (ir < 0) ir = 0;     if (jr < 0) jr = 0; //gia oria eikonas panw i aristera
                                if (ir >= source.Height) ir = source.Height - 1; if (jr >= source.Width) jr = source.Width - 1; //de3ia i katw

                                int k = ir * stride + jr * 3;
                                //p1[ir * stride + jr] einai to pixel tis geitonias
                                if ((i == 0 && j == 0) == false) 
                                {
                                    if (p2[k] == aa)
                                    {
                                        p1[y * stride + x * 3] = (byte)aa;
                                        p1[y * stride + x * 3 + 1] = (byte)aa;
                                        p1[y * stride + x * 3 + 2] = (byte)aa;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            bmp.UnlockBits(bmData);
            source.UnlockBits(bmData2);
            source.Dispose();
        }

    }
}
