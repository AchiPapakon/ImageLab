using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageLab
{
    public partial class HistoFrm : Form
    {
        public Bitmap image;
        Bitmap image2;
        Class1 myclass = new Class1();
        public event EventHandler<AdviseParentEventArgs> pateras;

        public HistoFrm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyHistogram histogram = new MyHistogram();
            int[,] hist;
            hist = histogram.CalculateHistogram(image);
            Bitmap histimage;
            histimage = histogram.DrawHistogram(hist, comboBox1.SelectedIndex);
            pictureBox1.Image = histimage;
            pictureBox1.Refresh();
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            image2 = (Bitmap)image.Clone();
            myclass.grayscale(image2);
            MyHistogram histogram = new MyHistogram();
            int[,] hist;
            hist = histogram.CalculateHistogram(image2);
            histogram.Equalization(image2, hist, comboBox1.SelectedIndex, (int)nmrMin.Value, (int)nmrMax.Value);
            pictureBox2.Image = image2;
            pictureBox2.Refresh();
        }

        private void HistoFrm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            image2 = (Bitmap)image.Clone();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            EventHandler<AdviseParentEventArgs> handler = this.pateras;
            if (handler != null)
            {
                handler(this, new AdviseParentEventArgs(image2));
            }
            this.Close();
        }

        //class gia inheritance
        public class AdviseParentEventArgs : EventArgs
        {
            private readonly Bitmap sungi;

            public AdviseParentEventArgs(Bitmap bmp)
            {
                sungi = bmp;
            }

            public Bitmap bmp
            {
                get
                {
                    return sungi;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
