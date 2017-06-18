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
    public partial class Form2 : Form
    {
        public Bitmap binaryimage;
        public Bitmap image;
        Class1 ecro=new Class1();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            binaryimage = (Bitmap)image.Clone();
            textBox1.Text = Convert.ToString(trackBar1.Value);
            ecro.binarize(binaryimage, trackBar1.Value);
            pictureBox1.Image=binaryimage;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            binaryimage = (Bitmap)image.Clone();
            textBox1.Text = Convert.ToString(trackBar1.Value);
            ecro.binarize(binaryimage, trackBar1.Value);
            pictureBox1.Image = binaryimage;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            ecro.binarize(image, trackBar1.Value);
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
