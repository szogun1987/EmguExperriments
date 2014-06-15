using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguExperiments.BasicTransformations
{
    public partial class RotateDialog : Form
    {
        public RotateDialog()
        {
            InitializeComponent();

            interpolation.Items.AddRange(new object[] { "AREA", "CUBIC", "LANCZOS", "LINEAR", "Nearest Neighbor" });
            interpolation.SelectedIndex = 0;
        }

        public double Angle
        {
            get
            {
                return Convert.ToDouble(angle.Value);
            }
        }

        public PointF Center
        {
            get
            {
                float x = (float)Convert.ToDouble(centerX.Value);
                float y = (float)Convert.ToDouble(centerY.Value);
                return new PointF(x, y);
            }
        }

        public INTER Interpolation
        {
            get
            {
                switch (interpolation.SelectedIndex)
                {
                    case 0:
                        return INTER.CV_INTER_AREA;
                    case 1:
                        return INTER.CV_INTER_CUBIC;
                    case 2:
                        return INTER.CV_INTER_LANCZOS4;
                    case 3:
                        return INTER.CV_INTER_LINEAR;
                    case 4:
                        return INTER.CV_INTER_NN;
                    default:
                        // To nie nastąpi
                        throw new Exception();
                }
            }
        }

        public Bgr Background
        {
            get
            {
                return new Bgr(color.BackColor);
            }
        }

        public bool Crop
        {
            get
            {
                return crop.Checked;
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    color.BackColor = colorDialog.Color;
                }
            }
        }
    }
}
