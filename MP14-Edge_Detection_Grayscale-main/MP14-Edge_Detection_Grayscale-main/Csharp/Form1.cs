using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Csharp
{
    public partial class Form1 : Form
    {
        readonly Bitmap OriginalImage;

        public Form1()
        {
            InitializeComponent();

            // Take file name to process
            string filename = @"D:\MONHOC\KI2_NAM3\MachineVision\Project\MP14-Edge_Detection_Grayscale-main\MP14-Edge_Detection_Grayscale-main\Csharp\Source\lena_color.jpg";
            OriginalImage = new Bitmap(filename);

            // Display original image and image after edge detection
            pictBox_Original.Image = OriginalImage;
            pictBox_Sobel.Image = DetectEdgeSobel(ConvertToGrayscale(OriginalImage), 0);
        }

        // Convert RGB image to Grayscale image by luminance method
        private static Bitmap ConvertToGrayscale(Bitmap imgPIL)
        {
            Bitmap grayImg = new Bitmap(imgPIL.Width, imgPIL.Height);
            int width = grayImg.Width;
            int height = grayImg.Height;
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    Color pixelColor = imgPIL.GetPixel(x, y);
                    int R = pixelColor.R;
                    int G = pixelColor.G;
                    int B = pixelColor.B;
                    int gray = (int)(0.2126 * R + 0.7152 * G + 0.0722 * B);
                    grayImg.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return grayImg;
        }

        //  Edge Detection with Sobel method
        public static Bitmap DetectEdgeSobel(Bitmap grayImg, int threshold)
        {
            Bitmap sobelImg = new(grayImg.Width, grayImg.Height);
            int width = sobelImg.Width;
            int height = sobelImg.Height;
            int[,] xMatrix = new int[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            int[,] yMatrix = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };

            for (int x = 1; x < width - 1; x++)
                for (int y = 1; y < height - 1; y++)
                {
                    int Gx = 0;
                    int Gy = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color pixelColor = grayImg.GetPixel(i, j);
                            int gray = pixelColor.R;
                            Gx += gray * xMatrix[i - (x - 1), j - (y - 1)];
                            Gy += gray * yMatrix[i - (x - 1), j - (y - 1)];
                        }
                    int M = Math.Abs(Gx) + Math.Abs(Gy);
                    if (M <= threshold)
                        sobelImg.SetPixel(x, y, Color.Black);
                    else
                        sobelImg.SetPixel(x, y, Color.White);
                }
            return sobelImg;
        }

        private void VScrollBar_thresholdSobel_Scroll(object sender, ScrollEventArgs e)
        {
            // Get threshold value from scrollbar value
            byte threshold = (byte)vScrollBar_thresholdBinary.Value;

            // Display threshold value in screen
            labelDisplayThreshold.Text = threshold.ToString();

            // Display Sobel image accroding each threshold
            pictBox_Sobel.Image = DetectEdgeSobel(OriginalImage, threshold);
        }
    }
}
