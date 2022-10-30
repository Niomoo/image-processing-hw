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
        private Bitmap connectedImg;
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            label4.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;
            label5.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openImg = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = openImg;
                pictureBox2.Image = openImg;
                processImg = openImg;
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
            processImg = lastImg;
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
            lastImg = processImg;
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lastImg = processImg;
            Bitmap MedianSmoothImage = new Bitmap(processImg.Width, processImg.Height);

            for (int y = 0; y < processImg.Height - 2; y++)
            {
                for (int x = 0; x < processImg.Width - 2; x++)
                {
                    int[] r_sum = new int[9];
                    int[] g_sum = new int[9];
                    int[] b_sum = new int[9];
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            r_sum[i * 3 + j] += Convert.ToInt32(processImg.GetPixel(x + j, y + i).R);
                            g_sum[i * 3 + j] += Convert.ToInt32(processImg.GetPixel(x + j, y + i).G);
                            b_sum[i * 3 + j] += Convert.ToInt32(processImg.GetPixel(x + j, y + i).B);
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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lastImg = processImg;
            Bitmap HistogramEqualizationImage = new Bitmap(processImg.Width, processImg.Height);

            label3.Visible = true;
            label4.Visible = true;
            chart1.Visible = true;
            chart2.Visible = true;

            int grayLevel = 256;
            double[] CountingTimes = new double[grayLevel];
            double[] SumCounting = new double[grayLevel];
            double[] Probability = new double[grayLevel];
            int pixelNum = 0;

            for (int y = 0; y < processImg.Height; y++)
            {
                for (int x = 0; x < processImg.Width; x++)
                {
                    CountingTimes[processImg.GetPixel(x, y).R]++;
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

            for (int y = 0; y < processImg.Height; y++)
            {
                for (int x = 0; x < processImg.Width; x++)
                {
                    int s = (int)Math.Round(Probability[processImg.GetPixel(x, y).R]);
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lastImg = processImg;
            Bitmap ThresholdImage = new Bitmap(openImg.Width, openImg.Height);

            int threshold = trackBar1.Value;
            for (int y = 0; y < openImg.Height - 2; y++)
            {
                for (int x = 0; x < openImg.Width - 2; x++)
                {
                    Color RGB = openImg.GetPixel(x, y);
                    if (RGB.R < threshold)
                    {
                        ThresholdImage.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        ThresholdImage.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            pictureBox2.Image = ThresholdImage;
            processImg = ThresholdImage;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lastImg = processImg;
            Bitmap SobelVerticalImage = new Bitmap(processImg.Width, processImg.Height);

            int[] filter = new int[] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
            for (int y = 0; y < processImg.Height - 2; y++)
            {
                for (int x = 0; x < processImg.Width - 2; x++)
                {
                    int r_sum = 0, g_sum = 0, b_sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            r_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).R * filter[i * 3 + j]);
                            g_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).G * filter[i * 3 + j]);
                            b_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).B * filter[i * 3 + j]);
                        }
                    }
                    if (r_sum > 255) r_sum = 255;
                    else if(r_sum < 0) r_sum = 0;
                    if (g_sum > 255) g_sum = 255;
                    else if (g_sum < 0) g_sum = 0;
                    if (b_sum > 255) b_sum = 255;
                    else if (b_sum < 0) b_sum = 0;

                    SobelVerticalImage.SetPixel(x, y, Color.FromArgb(r_sum, g_sum, b_sum));
                }
            }
            pictureBox2.Image = SobelVerticalImage;
            processImg = SobelVerticalImage;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lastImg = processImg;
            Bitmap SobelHorizontalImage = new Bitmap(processImg.Width, processImg.Height);

            int[] filter = new int[] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };
            for (int y = 0; y < processImg.Height - 2; y++)
            {
                for (int x = 0; x < processImg.Width - 2; x++)
                {
                    int r_sum = 0, g_sum = 0, b_sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            r_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).R * filter[i * 3 + j]);
                            g_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).G * filter[i * 3 + j]);
                            b_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).B * filter[i * 3 + j]);
                        }
                    }
                    if (r_sum > 255) r_sum = 255;
                    else if (r_sum < 0) r_sum = 0;
                    if (g_sum > 255) g_sum = 255;
                    else if (g_sum < 0) g_sum = 0;
                    if (b_sum > 255) b_sum = 255;
                    else if (b_sum < 0) b_sum = 0;

                    SobelHorizontalImage.SetPixel(x, y, Color.FromArgb(r_sum, g_sum, b_sum));
                }
            }
            pictureBox2.Image = SobelHorizontalImage;
            processImg = SobelHorizontalImage;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lastImg = processImg;
            Bitmap SobelCombinedImage = new Bitmap(processImg.Width, processImg.Height);

            int[] v_filter = new int[] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
            int[] h_filter = new int[] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };
            for (int y = 0; y < processImg.Height - 2; y++)
            {
                for (int x = 0; x < processImg.Width - 2; x++)
                {
                    int r_sum = 0, g_sum = 0, b_sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            r_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).R * v_filter[i * 3 + j]);
                            g_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).G * v_filter[i * 3 + j]);
                            b_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).B * v_filter[i * 3 + j]);
                            
                            r_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).R * h_filter[i * 3 + j]);
                            g_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).G * h_filter[i * 3 + j]);
                            b_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).B * h_filter[i * 3 + j]);
                        }
                    }
                    if (r_sum > 255) r_sum = 255;
                    else if (r_sum < 0) r_sum = 0;
                    if (g_sum > 255) g_sum = 255;
                    else if (g_sum < 0) g_sum = 0;
                    if (b_sum > 255) b_sum = 255;
                    else if (b_sum < 0) b_sum = 0;

                    SobelCombinedImage.SetPixel(x, y, Color.FromArgb(r_sum, g_sum, b_sum));
                }
            }
            pictureBox2.Image = SobelCombinedImage;
            processImg = SobelCombinedImage;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lastImg = processImg;
            Bitmap ThresholdOverlapImage = new Bitmap(processImg.Width, processImg.Height);

            int threshold = trackBar2.Value;
            int[] v_filter = new int[] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
            int[] h_filter = new int[] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };

            for (int y = 0; y < processImg.Height - 2; y++)
            {
                for (int x = 0; x < processImg.Width - 2; x++)
                {
                    Color RGB = processImg.GetPixel(x, y);
                    int r_sum = 0, g_sum = 0, b_sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            r_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).R * v_filter[i * 3 + j]);
                            g_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).G * v_filter[i * 3 + j]);
                            b_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).B * v_filter[i * 3 + j]);

                            r_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).R * h_filter[i * 3 + j]);
                            g_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).G * h_filter[i * 3 + j]);
                            b_sum += Convert.ToInt32(processImg.GetPixel(x + j, y + i).B * h_filter[i * 3 + j]);
                        }
                    }
                    if (r_sum > 255) r_sum = 255;
                    else if (r_sum < 0) r_sum = 0;
                    if (g_sum > 255) g_sum = 255;
                    else if (g_sum < 0) g_sum = 0;
                    if (b_sum > 255) b_sum = 255;
                    else if (b_sum < 0) b_sum = 0;

                    if (r_sum < threshold)
                    {
                        ThresholdOverlapImage.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        ThresholdOverlapImage.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    if (ThresholdOverlapImage.GetPixel(x, y).R == 255)
                    {
                        ThresholdOverlapImage.SetPixel(x, y, Color.FromArgb(0, 255, 0));
                    }
                }
            }
            pictureBox2.Image = ThresholdOverlapImage;
            processImg = ThresholdOverlapImage;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            connectedImg = new Bitmap(openImg.Width, openImg.Height);
            connectedImg = openImg.Clone(new Rectangle(0, 0, openImg.Width, openImg.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            int count = 0;
            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    if (connectedImg.GetPixel(x, y).R == 0)
                    {
                        findConnected(y, x);
                        count++;
                    }
                }
            }
            label5.Text = "Number of connected component: " + count.ToString();
            label5.Visible = true;
            pictureBox2.Image = connectedImg;
            processImg = connectedImg;
        }
        private void findConnected(int i, int j)
        {
            if (connectedImg.GetPixel(j, i).R == 255) { return; }
            else if (connectedImg.GetPixel(j, i).R == 0)
            {
                Random r = new Random();
                connectedImg.SetPixel(j, i, Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));

                if (i > 0 && j > 0) { findConnected(i - 1, j - 1); }                                   // 左上
                if (i > 0) { findConnected(i - 1, j); }                                                // 上
                if (i > 0 && j < openImg.Width - 1) { findConnected(i - 1, j + 1); }                   // 右上
                if (j > 0) { findConnected(i, j - 1); }                                                // 左
                if (j < openImg.Width - 1) { findConnected(i, j + 1); }                                // 右
                if (i < openImg.Height - 1 && j > 0) { findConnected(i + 1, j - 1); }                  // 左下
                if (i < openImg.Height - 1) { findConnected(i + 1, j); }                               // 下
                if (i < openImg.Height - 1 && j < openImg.Width - 1) { findConnected(i + 1, j + 1); }  // 右下
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lastImg = processImg;
            Bitmap RegistrationImage = new Bitmap(openImg.Width, openImg.Height);

            for (int y = 0; y < openImg.Height - 2; y++)
            {
                for (int x = 0; x < openImg.Width - 2; x++)
                {
                    Color RGB = openImg.GetPixel(x, y);
                }
            }
            pictureBox2.Image = RegistrationImage;
            processImg = RegistrationImage;
        }
    }
}
