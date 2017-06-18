using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageLab
{
    public partial class Form1 : Form
    {

        Bitmap image;
        Class1 ecro = new Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void ColorComponent(Bitmap bmp, int component)
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
                        p[y * stride + x * 3] = p[y * stride + x * 3 + component];
                        p[y * stride + x * 3 + 1] = p[y * stride + x * 3 + component];
                        p[y * stride + x * 3 + 2] = p[y * stride + x * 3 + component];
                    }
                }
            }
            bmp.UnlockBits(bmData);
            pictureBox1.Refresh();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
                processingToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                experimentalToolStripMenuItem.Enabled = true;
                button1.Enabled = true;
                this.Text = "ImageLab - " + openFileDialog1.FileName;
            }
        }

        private void gDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color original_color, target_color;
            for (int y = 0; y < image.Height; y++)
            {   for (int x = 0; x < image.Width; x++)
                {
                    original_color = image.GetPixel(x, y);
                    target_color = Color.FromArgb(255 - (int)original_color.R, 255 - (int)original_color.G, 255 - (int)original_color.B);
                    image.SetPixel(x, y, target_color);
                }
            }
            pictureBox1.Image = image;            
        }

        private void pointersToolStripMenuItem_Click(object sender, EventArgs e)
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
                        p[y * stride + x * 3] = (byte)(255 - p[y * stride + x * 3]);
                        p[y * stride + x * 3 + 1] = (byte)(255 - p[y * stride + x * 3 + 1]);
                        p[y * stride + x * 3 + 2] = (byte)(255 - p[y * stride + x * 3 + 2]);
                    }
                }
            }
            image.UnlockBits(bmData);
            pictureBox1.Refresh();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorComponent(image, 2);
        }


        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorComponent(image, 1);
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorComponent(image, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Restore to Grayscale")
            {
                image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
                makeGrayscaleToolStripMenuItem_Click(sender, e);
                button1.Text = "Restore to Original";
                button1.Width = 105;
            }
            else
            {
                image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }
        }

        private void makeRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ecro.make(image, Class1.colorz.R);
            pictureBox1.Refresh();
            button1.Text = "Restore to Grayscale";
            button1.Width = 120;
        }

        private void makeGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ecro.make(image, Class1.colorz.G);
            pictureBox1.Refresh();
            button1.Text = "Restore to Grayscale";
            button1.Width = 120;
        }

        private void makeBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ecro.make(image, Class1.colorz.B);
            pictureBox1.Refresh();
            button1.Text = "Restore to Grayscale";
            button1.Width = 120;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mady by Achilleas Papakonstantinou", "About");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;

            // show dialog
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                ImageFormat format;

                // resolve file format
                //switch (System.IO.Path.GetExtension(saveFileDialog1.FileName).ToLower())
                switch(saveFileDialog1.FilterIndex)
                {
                    case 1:
                        format = ImageFormat.Bmp;
                        break;
                    case 2:
                        format = ImageFormat.Jpeg;
                        break;
                    case 3:
                        format = ImageFormat.Gif;
                        break;
                    case 4:
                        format = ImageFormat.Tiff;
                        break;
                    case 5:
                        format = ImageFormat.Png;
                        break;
                    case 6:
                        format = ImageFormat.Icon;
                        break;
                    default:
                        MessageBox.Show(this, "Unsupported image format was specified", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                //saveFileDialog1.FileName = openFileDialog1.FileName + format;

                // save the image
                try
                {
                    image.Save(saveFileDialog1.FileName, format);

                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Failed writing image file", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void thresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 bin = new Form2();
            bin.image = image;
            bin.ShowDialog();
            pictureBox1.Refresh();
        }

        private void makeGrayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ecro.grayscale(image);
            pictureBox1.Refresh();
        }

        public void convertToYCbCrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YCbCr_Form formY = new YCbCr_Form();
            formY.image = image;
            formY.aaa = "Y";
            formY.Text = "Y Component";
            formY.Show();
            formY.pateras += new EventHandler<YCbCr_Form.AdviseParentEventArgs>(transfer_YCbCr);

            YCbCr_Form formCb = new YCbCr_Form();
            formCb.image = image;
            formCb.aaa = "Cb";
            formCb.Text = "Cb Component";
            formCb.Show();
            formCb.pateras += new EventHandler<YCbCr_Form.AdviseParentEventArgs>(transfer_YCbCr);

            YCbCr_Form formCr = new YCbCr_Form();
            formCr.image = image;
            formCr.aaa = "Cr";
            formCr.Text = "Cr Component";
            formCr.Show();
            formCr.pateras += new EventHandler<YCbCr_Form.AdviseParentEventArgs>(transfer_YCbCr);
        }

        public void transfer_YCbCr(object sender, YCbCr_Form.AdviseParentEventArgs e)
        {
            this.pictureBox1.Image = e.bmp;
            this.image = e.bmp;
        }

        private void prosanatolismosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Εμφάνιση επιφάνειας
            MyBlob.Moments moments = new MyBlob.Moments();
            MyBlob blob = new MyBlob();

            blob.CalculateMoments(image, ref moments);
            Point gc = blob.GravityCenter(moments);
            string text = "Area = " + Convert.ToString(moments.M00);
            MessageBox.Show(text);

            //Σχεδίαση Κέντρου Βάρους και Προσανατολισμού
            double theta = blob.Theta(moments);
            Graphics g = Graphics.FromImage(image);
            using (Pen pen = new Pen(Color.Red, 1))
            {
                g.DrawRectangle(pen, gc.X - 2, gc.Y - 2, 4, 4);
                g.DrawLine(pen, gc, new Point((int)(gc.X + 100), (int)(gc.Y + Math.Tan(theta) * 100)));
            }
            g.Dispose();
            pictureBox1.Refresh();
        }

        private void captureToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ecro.Capture(image);
            pictureBox1.Refresh();
        }

        private void erosionepektashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ecro.ErosionDelation(image, ecro.erosion);
            pictureBox1.Refresh();
        }

        private void syriknwshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ecro.ErosionDelation(image, ecro.delation);
            pictureBox1.Refresh();
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(image);
        }

        private void btnpaste_Click(object sender, EventArgs e)
        {
            //image = (Bitmap)Clipboard.GetImage();
            pictureBox1.Image = Clipboard.GetImage();
            pictureBox1.Refresh();
        }

        private void clearCbCrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ecro.clear_cbcr(image);
            pictureBox1.Refresh();
        }

        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoFrm form = new HistoFrm();
            form.image = image;
            form.Show();
            pictureBox1.Refresh();
            form.pateras += new EventHandler<HistoFrm.AdviseParentEventArgs>(transfer_HistoFrm);
        }

        public void transfer_HistoFrm(object sender, HistoFrm.AdviseParentEventArgs e)
        {
            this.pictureBox1.Image = e.bmp;
            this.image = e.bmp;
        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsFilters filters = new clsFilters();
            filters.Min(image);
            pictureBox1.Refresh();
        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsFilters filters = new clsFilters();
            filters.Max(image);
            pictureBox1.Refresh();
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsFilters filters = new clsFilters();
            filters.Mean(image);
            pictureBox1.Refresh();
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsFilters filters = new clsFilters();
            filters.Median(image);
            pictureBox1.Refresh();
        }

    }
}
