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
    public partial class YCbCr_Form : Form
    {
        Class1 ecro = new Class1();
        public Bitmap image;
        public Bitmap tempimage;
        public string aaa;
        public event EventHandler<AdviseParentEventArgs> pateras;

        public YCbCr_Form()
        {
            InitializeComponent();
        }

        private void YCbCr_Form_Load(object sender, EventArgs e)
        {
            tempimage = (Bitmap)image.Clone();
            ecro.YCbCr(tempimage, aaa);
            pictureBox1.Image = tempimage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventHandler<AdviseParentEventArgs> handler = this.pateras;
            if (handler != null)
            {
                handler(this, new AdviseParentEventArgs(tempimage));
            }
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

    }
}
