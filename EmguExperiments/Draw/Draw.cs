﻿using System;
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

namespace EmguExperiments.Draw
{
    public partial class Draw : UserControl
    {
        Image<Bgr, byte> image;

        public Draw()
        {
            InitializeComponent();

            image = new Image<Bgr, byte>(1, 1, new Bgr(255, 255, 255));
            imageBox.Image = image;
        }

        private void newPicture_Click(object sender, EventArgs e)
        {
            using (var dlg = new NewPic())
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                var oldImage = image;
                image = new Image<Bgr, byte>(dlg.TargetWidth, dlg.TargetHeight, new Bgr(dlg.Color));
                imageBox.Image = image;
                oldImage.Dispose();
            }
        }
    }
}
