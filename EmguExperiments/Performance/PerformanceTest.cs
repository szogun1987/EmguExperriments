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
using System.Drawing.Imaging;

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

            using (var bitmap = new Bitmap(fileName))
            {
                openFile = stopwatch.Elapsed;

                for (int row = 0; row < bitmap.Height; row++)
                {
                    for (int column = 0; column < bitmap.Width; column++)
                    {
                        Color original = bitmap.GetPixel(column, row);
                        
                        byte r = (byte)(255 - original.R);
                        byte g = (byte)(255 - original.G);
                        byte b = (byte)(255 - original.B);

                        Color target = Color.FromArgb(r, g, b);
                        bitmap.SetPixel(column, row, target);
                    }
                }

                operation = stopwatch.Elapsed;
            }
        }

        private void BitmapData(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (var bitmap = new Bitmap(fileName))
            {
                openFile = stopwatch.Elapsed;

                BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);

                try
                {
                    const int RED_PIXEL = 2;
                    const int GREEN_PIXEL = 1;
                    const int BLUE_PIXEL = 0;

                    int stride = bmData.Stride;
                    int bytesPerPixel = (bitmap.PixelFormat == PixelFormat.Format24bppRgb ? 3 : 4);

                    unsafe
                    {
                        byte* pixel = (byte*)(void*)bmData.Scan0;
                        int yMax = bitmap.Height;
                        int xMax = bitmap.Width;

                        for (int y = 0; y < yMax; y++)
                        {
                            int yPos = y * stride;
                            for (int x = 0; x < xMax; x++)
                            {
                                int pos = yPos + (x * bytesPerPixel);

                                pixel[pos + RED_PIXEL] = (byte)(255 - pixel[pos + RED_PIXEL]);
                                pixel[pos + GREEN_PIXEL] = (byte)(255 - pixel[pos + GREEN_PIXEL]);
                                pixel[pos + BLUE_PIXEL] = (byte)(255 - pixel[pos + BLUE_PIXEL]);
                            }

                        }
                    }
                }
                finally
                {
                    bitmap.UnlockBits(bmData);
                }

                operation = stopwatch.Elapsed;
            }
        }

        private void ColorMatrix(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (var bitmap = new Bitmap(fileName))
            {
                openFile = stopwatch.Elapsed;

                using (Bitmap clone = (Bitmap)bitmap.Clone())
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {

                        // negation ColorMatrix
                        ColorMatrix colorMatrix = new ColorMatrix(
                            new float[][]
                        {
                            new float[] {-1, 0, 0, 0, 0},
                            new float[] {0, -1, 0, 0, 0},
                            new float[] {0, 0, -1, 0, 0},
                            new float[] {0, 0, 0, 1, 0},
                            new float[] {0, 0, 0, 0, 1}
                        });

                        ImageAttributes attributes = new ImageAttributes();

                        attributes.SetColorMatrix(colorMatrix);

                        g.DrawImage(clone, new Rectangle(0, 0, clone.Width, clone.Height),
                                    0, 0, clone.Width, clone.Height, GraphicsUnit.Pixel, attributes);
                    }
                }

                operation = stopwatch.Elapsed;
            }
        }

        private void PixelAccess(out TimeSpan openFile, out TimeSpan operation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (var image = new Image<Bgr, byte>(fileName))
            {
                openFile = stopwatch.Elapsed;

                for (int row = 0; row < image.Height; row++)
                {
                    for (int column = 0; column < image.Width; column++)
                    {
                        var pixel = image[row, column];
                        pixel.Blue = (byte)(255 - pixel.Blue);
                        pixel.Green = (byte)(255 - pixel.Green);
                        pixel.Red = (byte)(255 - pixel.Red);
                        image[row, column] = pixel;
                    }
                }

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

                for (int row = 0; row < image.Height; row++)
                {
                    for (int column = 0; column < image.Width; column++)
                    {
                        // 3 kanały Brg
                        for (int i = 0; i < 3; i++)
                        {
                            byte channel = image.Data[row, column, i];
                            channel = (byte)(255 - channel);
                            image.Data[row, column, i] = channel;
                        }
                    }
                }

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

        private void btnCopyResults_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(@"<table class=""table"">
  <thead>
    <tr>
      <th></th>
      <th colspan=""3"">GDI+</th>
      <th colspan=""3"">Emgu CV</th>
    </tr>
    <tr>
      <th>Metoda</th>
      <th>GetPixel/SetPixel</th>
      <th>BitmapData</th>
      <th>ColorMatrix</th>
      <th>Pixel Access</th>
      <th>Pixel Access Fast</th>
      <th>Metoda Not</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th>Otwarcie pliku</th>");
            sb.AppendFormat("<td>{0}</td>", setPixelFileOpen.Text)
              .AppendFormat("<td>{0}</td>", bitmapDataFileOpen.Text)
              .AppendFormat("<td>{0}</td>", colorMatrixFileOpen.Text)
              .AppendFormat("<td>{0}</td>", pixelAccessFileOpen.Text)
              .AppendFormat("<td>{0}</td>", pixelAccessFastFileOpen.Text)
              .AppendFormat("<td>{0}</td>", notFileOpen.Text);
            sb.Append(@"</tr>
    <tr>
      <th>Wygenerowanie negatywu</th>");
            sb.AppendFormat("<td>{0}</td>", setPixelFileOpen.Text)
              .AppendFormat("<td>{0}</td>", bitmapDataFileOpen.Text)
              .AppendFormat("<td>{0}</td>", colorMatrixFileOpen.Text)
              .AppendFormat("<td>{0}</td>", pixelAccessFileOpen.Text)
              .AppendFormat("<td>{0}</td>", pixelAccessFastFileOpen.Text)
              .AppendFormat("<td>{0}</td>", notFileOpen.Text);
            sb.Append(@"</tr>
  </tbody>
</table>");
            Clipboard.SetText(sb.ToString());
        }
    }
}
