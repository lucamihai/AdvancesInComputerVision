
namespace AdvancesInComputerVision.GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxOriginalImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlteredImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoadOriginalImage = new System.Windows.Forms.Button();
            this.buttonResetOriginalImage = new System.Windows.Forms.Button();
            this.buttonSetOriginalImage = new System.Windows.Forms.Button();
            this.buttonResetAlteredImage = new System.Windows.Forms.Button();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.buttonGrayscale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlteredImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginalImage
            // 
            this.pictureBoxOriginalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxOriginalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginalImage.Location = new System.Drawing.Point(88, 47);
            this.pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
            this.pictureBoxOriginalImage.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxOriginalImage.TabIndex = 0;
            this.pictureBoxOriginalImage.TabStop = false;
            this.pictureBoxOriginalImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxOriginalImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBoxOriginalImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBoxAlteredImage
            // 
            this.pictureBoxAlteredImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAlteredImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAlteredImage.Location = new System.Drawing.Point(743, 47);
            this.pictureBoxAlteredImage.Name = "pictureBoxAlteredImage";
            this.pictureBoxAlteredImage.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxAlteredImage.TabIndex = 1;
            this.pictureBoxAlteredImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(759, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altered image";
            // 
            // buttonLoadOriginalImage
            // 
            this.buttonLoadOriginalImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadOriginalImage.Location = new System.Drawing.Point(6, 84);
            this.buttonLoadOriginalImage.Name = "buttonLoadOriginalImage";
            this.buttonLoadOriginalImage.Size = new System.Drawing.Size(76, 29);
            this.buttonLoadOriginalImage.TabIndex = 4;
            this.buttonLoadOriginalImage.Text = "Load";
            this.buttonLoadOriginalImage.UseVisualStyleBackColor = true;
            this.buttonLoadOriginalImage.Click += new System.EventHandler(this.ButtonLoadOriginalImageClick);
            // 
            // buttonResetOriginalImage
            // 
            this.buttonResetOriginalImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetOriginalImage.Location = new System.Drawing.Point(6, 163);
            this.buttonResetOriginalImage.Name = "buttonResetOriginalImage";
            this.buttonResetOriginalImage.Size = new System.Drawing.Size(76, 29);
            this.buttonResetOriginalImage.TabIndex = 5;
            this.buttonResetOriginalImage.Text = "Reset";
            this.buttonResetOriginalImage.UseVisualStyleBackColor = true;
            this.buttonResetOriginalImage.Click += new System.EventHandler(this.ButtonResetOriginalImageClick);
            // 
            // buttonSetOriginalImage
            // 
            this.buttonSetOriginalImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSetOriginalImage.Location = new System.Drawing.Point(6, 247);
            this.buttonSetOriginalImage.Name = "buttonSetOriginalImage";
            this.buttonSetOriginalImage.Size = new System.Drawing.Size(76, 29);
            this.buttonSetOriginalImage.TabIndex = 6;
            this.buttonSetOriginalImage.Text = "Set";
            this.buttonSetOriginalImage.UseVisualStyleBackColor = true;
            this.buttonSetOriginalImage.Click += new System.EventHandler(this.ButtonSetOriginalImageClick);
            // 
            // buttonResetAlteredImage
            // 
            this.buttonResetAlteredImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetAlteredImage.Location = new System.Drawing.Point(1389, 163);
            this.buttonResetAlteredImage.Name = "buttonResetAlteredImage";
            this.buttonResetAlteredImage.Size = new System.Drawing.Size(76, 29);
            this.buttonResetAlteredImage.TabIndex = 7;
            this.buttonResetAlteredImage.Text = "Reset";
            this.buttonResetAlteredImage.UseVisualStyleBackColor = true;
            this.buttonResetAlteredImage.Click += new System.EventHandler(this.ButtonResetAlteredImageClick);
            // 
            // buttonCrop
            // 
            this.buttonCrop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCrop.Location = new System.Drawing.Point(88, 533);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(84, 29);
            this.buttonCrop.TabIndex = 8;
            this.buttonCrop.Text = "Crop";
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.ButtonCropClick);
            // 
            // buttonGrayscale
            // 
            this.buttonGrayscale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGrayscale.Location = new System.Drawing.Point(178, 533);
            this.buttonGrayscale.Name = "buttonGrayscale";
            this.buttonGrayscale.Size = new System.Drawing.Size(84, 29);
            this.buttonGrayscale.TabIndex = 9;
            this.buttonGrayscale.Text = "Grayscale";
            this.buttonGrayscale.UseVisualStyleBackColor = true;
            this.buttonGrayscale.Click += new System.EventHandler(this.ButtonGrayscaleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1470, 631);
            this.Controls.Add(this.buttonGrayscale);
            this.Controls.Add(this.buttonCrop);
            this.Controls.Add(this.buttonResetAlteredImage);
            this.Controls.Add(this.buttonSetOriginalImage);
            this.Controls.Add(this.buttonResetOriginalImage);
            this.Controls.Add(this.buttonLoadOriginalImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxAlteredImage);
            this.Controls.Add(this.pictureBoxOriginalImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlteredImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginalImage;
        private System.Windows.Forms.PictureBox pictureBoxAlteredImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoadOriginalImage;
        private System.Windows.Forms.Button buttonResetOriginalImage;
        private System.Windows.Forms.Button buttonSetOriginalImage;
        private System.Windows.Forms.Button buttonResetAlteredImage;
        private System.Windows.Forms.Button buttonCrop;
        private System.Windows.Forms.Button buttonGrayscale;
    }
}

