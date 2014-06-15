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

        private void openFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Obrazy (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                Image<Bgr, byte> image = new Image<Bgr, byte>(ofd.FileName);
                imageBox.Image = image;
            }
        }

        private void flip_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> image = (Image<Bgr, byte>)imageBox.Image;
            imageBox.Image = image.Flip(Emgu.CV.CvEnum.FLIP.HORIZONTAL);
            image.Dispose();
        }

        private void flipVertical_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> image = (Image<Bgr, byte>)imageBox.Image;
            imageBox.Image = image.Flip(Emgu.CV.CvEnum.FLIP.VERTICAL);
            image.Dispose();
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            using (var dlg = new RotateDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                Image<Bgr, byte> image = (Image<Bgr, byte>)imageBox.Image;
                imageBox.Image = image.Rotate(dlg.Angle, dlg.Center, dlg.Interpolation, dlg.Background,dlg.Crop);
                image.Dispose();
            }
        }

        private void resize_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> image = (Image<Bgr, byte>)imageBox.Image;
            using (var dlg  = new ScaleDialog(image.Width, image.Height))
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                
                imageBox.Image = image.Resize(dlg.Width, dlg.Height, dlg.Interpolation, dlg.PreserveScale);
                image.Dispose();
            }
        }
    }
}
