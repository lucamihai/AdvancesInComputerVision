
namespace AdvancesInComputerVision.GUI
{
    partial class MainWindow
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
            this.buttonBeginCropSelection = new System.Windows.Forms.Button();
            this.numericUpDownCropSelectionX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCropSelectionY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCropSelectionSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCropSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlteredImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCropSelectionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCropSelectionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCropSelectionSize)).BeginInit();
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
            this.pictureBoxOriginalImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxOriginalImageMouseDown);
            this.pictureBoxOriginalImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxOriginalImageMouseMove);
            this.pictureBoxOriginalImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxOriginalImageMouseUp);
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
            // buttonBeginCropSelection
            // 
            this.buttonBeginCropSelection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBeginCropSelection.Location = new System.Drawing.Point(517, 533);
            this.buttonBeginCropSelection.Name = "buttonBeginCropSelection";
            this.buttonBeginCropSelection.Size = new System.Drawing.Size(84, 29);
            this.buttonBeginCropSelection.TabIndex = 10;
            this.buttonBeginCropSelection.Text = "Start";
            this.buttonBeginCropSelection.UseVisualStyleBackColor = true;
            this.buttonBeginCropSelection.Click += new System.EventHandler(this.ButtonBeginCropSelectionClick);
            // 
            // numericUpDownCropSelectionX
            // 
            this.numericUpDownCropSelectionX.Location = new System.Drawing.Point(517, 569);
            this.numericUpDownCropSelectionX.Name = "numericUpDownCropSelectionX";
            this.numericUpDownCropSelectionX.Size = new System.Drawing.Size(84, 23);
            this.numericUpDownCropSelectionX.TabIndex = 11;
            this.numericUpDownCropSelectionX.ValueChanged += new System.EventHandler(this.NumericUpDownCropSelectionXValueChanged);
            // 
            // numericUpDownCropSelectionY
            // 
            this.numericUpDownCropSelectionY.Location = new System.Drawing.Point(517, 598);
            this.numericUpDownCropSelectionY.Name = "numericUpDownCropSelectionY";
            this.numericUpDownCropSelectionY.Size = new System.Drawing.Size(84, 23);
            this.numericUpDownCropSelectionY.TabIndex = 12;
            this.numericUpDownCropSelectionY.ValueChanged += new System.EventHandler(this.NumericUpDownCropSelectionYValueChanged);
            // 
            // numericUpDownCropSelectionSize
            // 
            this.numericUpDownCropSelectionSize.Location = new System.Drawing.Point(517, 627);
            this.numericUpDownCropSelectionSize.Name = "numericUpDownCropSelectionSize";
            this.numericUpDownCropSelectionSize.Size = new System.Drawing.Size(84, 23);
            this.numericUpDownCropSelectionSize.TabIndex = 13;
            this.numericUpDownCropSelectionSize.ValueChanged += new System.EventHandler(this.NumericUpDownCropSelectionSizeValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(406, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Crop selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(491, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(491, 602);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(477, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Size";
            // 
            // buttonCropSelection
            // 
            this.buttonCropSelection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCropSelection.Location = new System.Drawing.Point(607, 533);
            this.buttonCropSelection.Name = "buttonCropSelection";
            this.buttonCropSelection.Size = new System.Drawing.Size(84, 29);
            this.buttonCropSelection.TabIndex = 18;
            this.buttonCropSelection.Text = "Crop";
            this.buttonCropSelection.UseVisualStyleBackColor = true;
            this.buttonCropSelection.Click += new System.EventHandler(this.ButtonCropSelectionClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1470, 667);
            this.Controls.Add(this.buttonCropSelection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownCropSelectionSize);
            this.Controls.Add(this.numericUpDownCropSelectionY);
            this.Controls.Add(this.numericUpDownCropSelectionX);
            this.Controls.Add(this.buttonBeginCropSelection);
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
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlteredImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCropSelectionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCropSelectionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCropSelectionSize)).EndInit();
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
        private System.Windows.Forms.Button buttonBeginCropSelection;
        private System.Windows.Forms.NumericUpDown numericUpDownCropSelectionX;
        private System.Windows.Forms.NumericUpDown numericUpDownCropSelectionY;
        private System.Windows.Forms.NumericUpDown numericUpDownCropSelectionSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCropSelection;
    }
}

