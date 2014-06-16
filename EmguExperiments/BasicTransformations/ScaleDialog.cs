using Emgu.CV.CvEnum;
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
    public partial class ScaleDialog : Form
    {
        public ScaleDialog(int width, int height)
        {
            InitializeComponent();

            this.width.Value = width;
            this.height.Value = height;

            interpolation.Items.AddRange(new object[] { "AREA", "CUBIC", "LANCZOS", "LINEAR", "Nearest Neighbor" });
            interpolation.SelectedIndex = 0;
        }

        public int TargetWidth
        {
            get
            {
                return Convert.ToInt32(width.Value);
            }
        }

        public int TargetHeight
        {
            get
            {
                return Convert.ToInt32(height.Value);
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

        public bool PreserveScale
        {
            get
            {
                return preserveScale.Checked;
            }
        }
    }
}
