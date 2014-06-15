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
            setPixelFileOpen.Text = openFile.ToString();
            setPixelOp.Text = operation.ToString();

            BitmapData(out openFile, out operation);
            bitmapDataFileOpen.Text = openFile.ToString();
            bitmapDataOp.Text = operation.ToString();

            ColorMatrix(out openFile, out operation);
            colorMatrixFileOpen.Text = openFile.ToString();
            colorMatrixOp.Text = operation.ToString();

            PixelAccess(out openFile, out operation);
            pixelAccessFileOpen.Text = openFile.ToString();
            pixelAccessOp.Text = operation.ToString();

            PixelAccessFast(out openFile, out operation);
            pixelAccessFastFileOpen.Text = openFile.ToString();
            pixelAccessFastOp.Text = operation.ToString();

            NotMethod(out openFile, out operation);
            notFileOpen.Text = openFile.ToString();
            notOp.Text = operation.ToString();
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

            // TODO: Open file

            openFile = stopwatch.Elapsed;

            // TODO: Operation

            operation = stopwatch.Elapsed;
        }

        private void PixelAccessFast(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // TODO: Open file

            openFile = stopwatch.Elapsed;

            // TODO: Operation

            operation = stopwatch.Elapsed;
        }

        private void NotMethod(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // TODO: Open file

            openFile = stopwatch.Elapsed;

            // TODO: Operation

            operation = stopwatch.Elapsed;
        }
    }
}
