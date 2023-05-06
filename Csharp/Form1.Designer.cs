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
            this.pictBox_Original = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictBox_Segmenttion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_Segmenttion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBox_Original
            // 
            this.pictBox_Original.Location = new System.Drawing.Point(15, 39);
            this.pictBox_Original.Name = "pictBox_Original";
            this.pictBox_Original.Size = new System.Drawing.Size(512, 512);
            this.pictBox_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox_Original.TabIndex = 0;
            this.pictBox_Original.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "RGB image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Image after segmentation";
            // 
            // pictBox_Segmenttion
            // 
            this.pictBox_Segmenttion.Location = new System.Drawing.Point(542, 39);
            this.pictBox_Segmenttion.Name = "pictBox_Segmenttion";
            this.pictBox_Segmenttion.Size = new System.Drawing.Size(512, 512);
            this.pictBox_Segmenttion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox_Segmenttion.TabIndex = 2;
            this.pictBox_Segmenttion.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictBox_Segmenttion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictBox_Original);
            this.Name = "Form1";
            this.Text = "SEGMENTATION IN RGB VECTOR SPACE";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_Segmenttion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox_Original;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictBox_Segmenttion;
    }
}

