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
            string filename = @"D:\MONHOC\KI2_NAM3\MachineVision\Project\MP15-Edge_Detection_RGB-main\MP15-Edge_Detection_RGB-main\Csharp\SourceImage\lena_color.jpg";
            OriginalImage = new Bitmap(filename);

            // Display original image and image after edge detection
            pictBox_Original.Image = OriginalImage;
            pictBox_Sobel.Image = DetectEdgeSobel(OriginalImage, 0);
        }

        //  Edge Detection with Sobel method
        public static Bitmap DetectEdgeSobel(Bitmap OriginalImage, int threshold)
        {
            Bitmap sobelImg = new(OriginalImage.Width, OriginalImage.Height);  
            double[,] matrix_X = new double[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            double[,] matrix_Y = new double[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            double D = threshold;
            for (int x = 1; x < OriginalImage.Width - 1; x++)
                for (int y = 1; y < OriginalImage.Height - 1; y++)
                {
                    double gR_X = 0;
                    double gR_Y = 0;
                    double gG_X = 0;
                    double gG_Y = 0;
                    double gB_X = 0;
                    double gB_Y = 0;
                    double F0 = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color pixelColor = OriginalImage.GetPixel(i, j);
                            double R = pixelColor.R;
                            double G = pixelColor.G;
                            double B = pixelColor.B;
                            gR_X += R * matrix_X[i - x + 1, j - y + 1];
                            gR_Y += R * matrix_Y[i - x + 1, j - y + 1];
                            gG_X += G * matrix_X[i - x + 1, j - y + 1];
                            gG_Y += G * matrix_Y[i - x + 1, j - y + 1];
                            gB_X += B * matrix_X[i - x + 1, j - y + 1];
                            gB_Y += B * matrix_Y[i - x + 1, j - y + 1];
                        }

                    double gxx = gR_X * gR_X + gG_X * gG_X + gB_X * gB_X;
                    double gyy = gR_Y * gR_Y + gG_Y * gG_Y + gB_Y * gB_Y;
                    double gxy = gR_X * gR_Y + gG_X * gG_Y + gB_X * gB_Y;

                    double THETA = 0.5 * (Math.Atan2(2 * gxy, (gxx - gyy)));
                    F0 = Math.Sqrt(((gxx + gyy) + (gxx - gyy) * Math.Cos(2 * THETA) + 2 * gxy * Math.Sin(2 * THETA)) * 0.5);
                    if (F0 >= D)
                    {
                        sobelImg.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        sobelImg.SetPixel(x, y, Color.Black);
                    }
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
