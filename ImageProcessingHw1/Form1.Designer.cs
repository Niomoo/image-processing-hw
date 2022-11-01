namespace ImageProcessingHw1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. RGB Extraction and Transformation";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(155, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Grayscale";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "B channel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "G channel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "R channel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(28, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 63);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Smooth Filter";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(155, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 30);
            this.button7.TabIndex = 1;
            this.button7.Text = "Median Filter";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(17, 21);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 30);
            this.button8.TabIndex = 0;
            this.button8.Text = "Mean Filter";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(28, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 63);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Histogram Equalization";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(256, 30);
            this.button6.TabIndex = 0;
            this.button6.Text = "Histogram Equalization";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Location = new System.Drawing.Point(28, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 72);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4. Thresholding";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(17, 21);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(155, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 30);
            this.button5.TabIndex = 0;
            this.button5.Text = "Start";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Location = new System.Drawing.Point(28, 346);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 63);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "5. Sobel Edge Detection";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(191, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 30);
            this.button11.TabIndex = 2;
            this.button11.Text = "Combined";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(104, 21);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 30);
            this.button9.TabIndex = 1;
            this.button9.Text = "Horizontal";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(17, 21);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 30);
            this.button10.TabIndex = 0;
            this.button10.Text = "Vertical";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.trackBar2);
            this.groupBox6.Controls.Add(this.button12);
            this.groupBox6.Location = new System.Drawing.Point(28, 415);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(286, 72);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "6. Edge Overlapping";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(17, 21);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.Value = 1;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(155, 25);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(118, 30);
            this.button12.TabIndex = 0;
            this.button12.Text = "Edge Overlapping";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button13);
            this.groupBox7.Location = new System.Drawing.Point(28, 493);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(286, 63);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "7. Connected Component";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(17, 21);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(256, 30);
            this.button13.TabIndex = 0;
            this.button13.Text = "Connected Component";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button14);
            this.groupBox8.Location = new System.Drawing.Point(28, 562);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(286, 63);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "8. Image Registration";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(17, 21);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(256, 30);
            this.button14.TabIndex = 0;
            this.button14.Text = "Image Registration";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Source Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(330, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(330, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(327, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Process Image";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button15);
            this.groupBox9.Controls.Add(this.button16);
            this.groupBox9.Controls.Add(this.button17);
            this.groupBox9.Location = new System.Drawing.Point(330, 562);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(314, 63);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Controls";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(212, 21);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(82, 30);
            this.button15.TabIndex = 2;
            this.button15.Text = "Undo";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(115, 21);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(82, 30);
            this.button16.TabIndex = 1;
            this.button16.Text = "Save";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(17, 21);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(82, 30);
            this.button17.TabIndex = 0;
            this.button17.Text = "Load";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(684, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Before";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(684, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "After";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(687, 28);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(314, 240);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(687, 304);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(314, 240);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Number of connected region: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(687, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(335, 240);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(684, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Registered Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 638);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
    }
}

