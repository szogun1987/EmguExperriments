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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        public int X
        {
            get
            {
                return Convert.ToInt32(x.Value);
            }
        }

        public int Y
        {
            get
            {
                return Convert.ToInt32(y.Value);
            }
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
    }
}
