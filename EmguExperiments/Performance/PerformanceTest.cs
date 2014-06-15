using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguExperiments.Performance
{
    public partial class PerformanceTest : UserControl
    {
        private string fileName;

        public PerformanceTest()
        {
            InitializeComponent();
        }

        private void pickFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Pliki graficzne (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";
                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                fileNameLabel.Text = fileName = ofd.FileName;
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            TimeSpan openFile;
            TimeSpan operation;

            SetPixel(out openFile, out operation);
            setPixelFileOpen.Text = openFile.ToString("mm\\:ss\\.fff");
            setPixelOp.Text = operation.ToString("mm\\:ss\\.fff");

            BitmapData(out openFile, out operation);
            bitmapDataFileOpen.Text = openFile.ToString("mm\\:ss\\.fff");
            bitmapDataOp.Text = operation.ToString("mm\\:ss\\.fff");

            ColorMatrix(out openFile, out operation);
            colorMatrixFileOpen.Text = openFile.ToString("mm\\:ss\\.fff");
            colorMatrixOp.Text = operation.ToString("mm\\:ss\\.fff");

            PixelAccess(out openFile, out operation);
            pixelAccessFileOpen.Text = openFile.ToString("mm\\:ss\\.fff");
            pixelAccessOp.Text = operation.ToString("mm\\:ss\\.fff");

            PixelAccessFast(out openFile, out operation);
            pixelAccessFastFileOpen.Text = openFile.ToString("mm\\:ss\\.fff");
            pixelAccessFastOp.Text = operation.ToString("mm\\:ss\\.fff");

            NotMethod(out openFile, out operation);
            notFileOpen.Text = openFile.ToString("mm\\:ss\\.fff");
            notOp.Text = operation.ToString("mm\\:ss\\.fff");
        }

        private void SetPixel(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // TODO: Open file

            openFile = stopwatch.Elapsed;

            // TODO: Operation

            operation = stopwatch.Elapsed;
        }

        private void BitmapData(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // TODO: Open file

            openFile = stopwatch.Elapsed;

            // TODO: Operation

            operation = stopwatch.Elapsed;
        }

        private void ColorMatrix(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // TODO: Open file

            openFile = stopwatch.Elapsed;

            // TODO: Operation

            operation = stopwatch.Elapsed;
        }

        private void PixelAccess(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (var image = new Image<Bgr, byte>(fileName))
            {
                openFile = stopwatch.Elapsed;

                // TODO: Operation

                operation = stopwatch.Elapsed;
            }
        }

        private void PixelAccessFast(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (var image = new Image<Bgr, byte>(fileName))
            {
                openFile = stopwatch.Elapsed;

                // TODO: Operation

                operation = stopwatch.Elapsed;
            }
        }

        private void NotMethod(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (var image = new Image<Bgr, byte>(fileName))
            {
                openFile = stopwatch.Elapsed;

                image._Not();

                operation = stopwatch.Elapsed;
            }
        }
    }
}
