using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;

namespace EmguExperiments.BasicTransformations
{
    public partial class BasicTransform : UserControl
    {
        public BasicTransform()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image<Bgr, byte> image = new Image<Bgr, byte>(ofd.FileName);
                    imageBox1.Image = image;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> image = imageBox1.Image as Image<Bgr, byte>;
            image._SmoothGaussian(5);
            imageBox1.Image = image;
        }
    }
}
