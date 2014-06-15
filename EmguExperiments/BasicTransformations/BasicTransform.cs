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
    }
}
