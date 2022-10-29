using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingHw1
{
    public partial class Form1 : Form
    {
        private Bitmap openImg;
        private Bitmap processImg;
        private Bitmap lastImg;
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openImg = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = openImg;
                pictureBox2.Image = openImg;
                lastImg = openImg;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*jpg";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                processImg.Save(sfd.FileName);
            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = lastImg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap RImage = new Bitmap(openImg.Width, openImg.Height);

            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    Color RGB = openImg.GetPixel(x, y);
                    RImage.SetPixel(x, y, Color.FromArgb(RGB.R, RGB.R, RGB.R));
                }
            }
            pictureBox2.Image = RImage;
            processImg = RImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap GImage = new Bitmap(openImg.Width, openImg.Height);

            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    Color RGB = openImg.GetPixel(x, y);
                    GImage.SetPixel(x, y, Color.FromArgb(RGB.G, RGB.G, RGB.G));
                }
            }
            pictureBox2.Image = GImage;
            processImg = GImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap BImage = new Bitmap(openImg.Width, openImg.Height);

            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    Color RGB = openImg.GetPixel(x, y);
                    BImage.SetPixel(x, y, Color.FromArgb(RGB.B, RGB.B, RGB.B));
                }
            }
            pictureBox2.Image = BImage;
            processImg = BImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap GrayImage = new Bitmap(openImg.Width, openImg.Height);

            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    Color RGB = openImg.GetPixel(x, y);
                    int grayLevel = (RGB.R + RGB.G + RGB.B) / 3;
                    GrayImage.SetPixel(x, y, Color.FromArgb(grayLevel, grayLevel, grayLevel));
                }
            }
            pictureBox2.Image = GrayImage;
            processImg = GrayImage;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap MeanSmoothImage = new Bitmap(openImg.Width, openImg.Height);

            for (int y = 0; y < openImg.Height - 2; y++)
            {
                for (int x = 0; x < openImg.Width - 2; x++)
                {
                    int r_sum = 0, g_sum = 0, b_sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            r_sum += Convert.ToInt32(openImg.GetPixel(x + j, y + i).R);
                            g_sum += Convert.ToInt32(openImg.GetPixel(x + j, y + i).G);
                            b_sum += Convert.ToInt32(openImg.GetPixel(x + j, y + i).B);
                        }
                    }
                    MeanSmoothImage.SetPixel(x, y, Color.FromArgb((int)(r_sum / 9), (int)(g_sum / 9), (int)(b_sum / 9)));
                }
            }
            pictureBox2.Image = MeanSmoothImage;
            processImg = MeanSmoothImage;
            lastImg = MeanSmoothImage;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap MedianSmoothImage = new Bitmap(openImg.Width, openImg.Height);

            for (int y = 0; y < openImg.Height - 2; y++)
            {
                for (int x = 0; x < openImg.Width - 2; x++)
                {
                    int[] r_sum = new int[9];
                    int[] g_sum = new int[9];
                    int[] b_sum = new int[9];
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            r_sum[i * 3 + j] += Convert.ToInt32(openImg.GetPixel(x + j, y + i).R);
                            g_sum[i * 3 + j] += Convert.ToInt32(openImg.GetPixel(x + j, y + i).G);
                            b_sum[i * 3 + j] += Convert.ToInt32(openImg.GetPixel(x + j, y + i).B);
                        }
                    }
                    Array.Sort(r_sum);
                    Array.Sort(g_sum);
                    Array.Sort(b_sum);
                    MedianSmoothImage.SetPixel(x, y, Color.FromArgb(r_sum[3 * 3 / 2], g_sum[3 * 3 / 2], b_sum[3 * 3 / 2]));
                }
            }
            pictureBox2.Image = MedianSmoothImage;
            processImg = MedianSmoothImage;
            lastImg = MedianSmoothImage;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap HistogramEqualizationImage = new Bitmap(openImg.Width, openImg.Height);

            int grayLevel = 256;
            double[] CountingTimes = new double[grayLevel];
            double[] SumCounting = new double[grayLevel];
            double[] Probability = new double[grayLevel];
            int pixelNum = 0;

            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    CountingTimes[openImg.GetPixel(x, y).R]++;
                    pixelNum++;
                }
            }

            for (int i = 0; i < grayLevel; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, CountingTimes[i]);
                if (i == 0)
                {
                    SumCounting[i] = CountingTimes[i];
                    Probability[i] = Math.Round(SumCounting[i] * 255 / pixelNum);
                }
                else
                {
                    SumCounting[i] = SumCounting[i - 1] + CountingTimes[i];
                    Probability[i] = Math.Round(SumCounting[i] * 255 / pixelNum); 
                }
            }

            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    int s = (int)Math.Round(Probability[openImg.GetPixel(x, y).R]);
                    HistogramEqualizationImage.SetPixel(x, y, Color.FromArgb(s, s, s));

                }
            }

            for (int i = 0; i < grayLevel; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, CountingTimes[i]);
                chart2.Series[0].Points.AddXY(Probability[i], CountingTimes[i]);
            }
            pictureBox2.Image = HistogramEqualizationImage;
            processImg = HistogramEqualizationImage;
            lastImg = HistogramEqualizationImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap ThresholdImage = new Bitmap(openImg.Width, openImg.Height);

            for (int y = 0; y < openImg.Height - 2; y++)
            {
                for (int x = 0; x < openImg.Width - 2; x++)
                {
                    Color RGB = openImg.GetPixel(x, y);
                }
            }
            pictureBox2.Image = ThresholdImage;
            processImg = ThresholdImage;
            lastImg = ThresholdImage;
        }
    }
}
