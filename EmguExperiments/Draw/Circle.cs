using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguExperiments.Draw
{
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        public int CenterX
        {
            get
            {
                return Convert.ToInt32(centerX.Value);
            }
        }

        public int CenterY
        {
            get
            {
                return Convert.ToInt32(centerY.Value);
            }
        }

        public int Radius
        {
            get
            {
                return Convert.ToInt32(radius.Value);
            }
        }
    }
}
