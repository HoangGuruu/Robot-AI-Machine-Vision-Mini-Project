namespace Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictBox_Original = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictBox_Sobel = new PictureBox();
            vScrollBar_thresholdBinary = new VScrollBar();
            label3 = new Label();
            labelDisplayThreshold = new Label();
            ((System.ComponentModel.ISupportInitialize)pictBox_Original).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBox_Sobel).BeginInit();
            SuspendLayout();
            // 
            // pictBox_Original
            // 
            pictBox_Original.Location = new Point(27, 53);
            pictBox_Original.Margin = new Padding(4, 3, 4, 3);
            pictBox_Original.Name = "pictBox_Original";
            pictBox_Original.Size = new Size(256, 256);
            pictBox_Original.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBox_Original.TabIndex = 0;
            pictBox_Original.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 1;
            label1.Text = "Original image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(410, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 3;
            label2.Text = "After Edge Detection";
            // 
            // pictBox_Sobel
            // 
            pictBox_Sobel.Location = new Point(349, 53);
            pictBox_Sobel.Margin = new Padding(4, 3, 4, 3);
            pictBox_Sobel.Name = "pictBox_Sobel";
            pictBox_Sobel.Size = new Size(256, 256);
            pictBox_Sobel.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBox_Sobel.TabIndex = 2;
            pictBox_Sobel.TabStop = false;
            // 
            // vScrollBar_thresholdBinary
            // 
            vScrollBar_thresholdBinary.AccessibleName = "";
            vScrollBar_thresholdBinary.Location = new Point(686, 53);
            vScrollBar_thresholdBinary.Maximum = 264;
            vScrollBar_thresholdBinary.Name = "vScrollBar_thresholdBinary";
            vScrollBar_thresholdBinary.Size = new Size(15, 256);
            vScrollBar_thresholdBinary.TabIndex = 4;
            vScrollBar_thresholdBinary.Scroll += VScrollBar_thresholdSobel_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(654, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 5;
            label3.Text = "Threshold";
            // 
            // labelDisplayThreshold
            // 
            labelDisplayThreshold.AutoSize = true;
            labelDisplayThreshold.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDisplayThreshold.Location = new Point(726, 53);
            labelDisplayThreshold.Margin = new Padding(4, 0, 4, 0);
            labelDisplayThreshold.Name = "labelDisplayThreshold";
            labelDisplayThreshold.Size = new Size(0, 17);
            labelDisplayThreshold.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 332);
            Controls.Add(labelDisplayThreshold);
            Controls.Add(label3);
            Controls.Add(vScrollBar_thresholdBinary);
            Controls.Add(label2);
            Controls.Add(pictBox_Sobel);
            Controls.Add(label1);
            Controls.Add(pictBox_Original);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Edge Detection with Sobel method";
            ((System.ComponentModel.ISupportInitialize)pictBox_Original).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBox_Sobel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox_Original;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictBox_Sobel;
        private System.Windows.Forms.VScrollBar vScrollBar_thresholdBinary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDisplayThreshold;
    }
}

