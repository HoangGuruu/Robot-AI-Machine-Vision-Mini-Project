using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Display original RGB image
            string ImgPath = @"D:\MONHOC\KI2_NAM3\MachineVision\Project\MP13-Segmentation_RGB-main\MP13-Segmentation_RGB-main\Csharp\Source\lena_color.jpg";
            Bitmap origImg = new Bitmap(ImgPath);
            pictBox_Original.Image = origImg;

            // Display image after segmentation
            pictBox_Segmenttion.Image = Segmentation_RGB(origImg, 80, 400, 150, 500, 45);
        }

        private Bitmap Segmentation_RGB(Bitmap origImg, int x1, int y1, int x2, int y2, double D0)
        {
            Bitmap segmentImg = new Bitmap(origImg.Width, origImg.Height);

            double aR = 0;
            double aG = 0;
            double aB = 0;

            for (int i = x1; i <= x2; i++)
                for (int j = y1; j <= y2; j++)
                {
                    Color color = origImg.GetPixel(i, j);
                    aR += color.R;
                    aG += color.G;
                    aB += color.B;
                }
            double size = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            aR /= size;
            aG /= size;
            aB /= size;

            for (int x = 0; x < origImg.Width; x++)
                for (int y = 0; y < origImg.Height; y++)
                {
                    Color color = origImg.GetPixel(x, y);
                    int zR = color.R;
                    int zG = color.G;
                    int zB = color.B;
                    double D = Math.Sqrt(Math.Pow((zR - aR), 2) + Math.Pow((zG - aG), 2) + Math.Pow((zB - aB), 2));
                    if (D <= D0)
                        segmentImg.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else
                        segmentImg.SetPixel(x, y, Color.FromArgb(zR, zG, zB));
                }
            return segmentImg;
        }
    }
}
