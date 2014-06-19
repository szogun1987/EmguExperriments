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
    public partial class NewPic : Form
    {
        public NewPic()
        {
            InitializeComponent();
        }

        private void color_Click(object sender, EventArgs e)
        {
            using (var dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                color.BackColor = dlg.Color;
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

        public Color Color
        {
            get
            {
                return color.BackColor;
            }
        }
    }
}
