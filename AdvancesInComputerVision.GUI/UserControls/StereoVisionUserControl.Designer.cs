
namespace AdvancesInComputerVision.GUI.UserControls
{
    partial class StereoVisionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImageLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxStereoImage = new System.Windows.Forms.PictureBox();
            this.buttonLoadImageLeft = new System.Windows.Forms.Button();
            this.buttonLoadImageRight = new System.Windows.Forms.Button();
            this.buttonStereo = new System.Windows.Forms.Button();
            this.numericUpDownBlocksize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSearchRadius = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStereoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlocksize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSearchRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImageLeft
            // 
            this.pictureBoxImageLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImageLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageLeft.Location = new System.Drawing.Point(131, 64);
            this.pictureBoxImageLeft.Name = "pictureBoxImageLeft";
            this.pictureBoxImageLeft.Size = new System.Drawing.Size(400, 250);
            this.pictureBoxImageLeft.TabIndex = 0;
            this.pictureBoxImageLeft.TabStop = false;
            // 
            // pictureBoxImageRight
            // 
            this.pictureBoxImageRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImageRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageRight.Location = new System.Drawing.Point(131, 344);
            this.pictureBoxImageRight.Name = "pictureBoxImageRight";
            this.pictureBoxImageRight.Size = new System.Drawing.Size(400, 250);
            this.pictureBoxImageRight.TabIndex = 1;
            this.pictureBoxImageRight.TabStop = false;
            // 
            // pictureBoxStereoImage
            // 
            this.pictureBoxStereoImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStereoImage.Location = new System.Drawing.Point(703, 168);
            this.pictureBoxStereoImage.Name = "pictureBoxStereoImage";
            this.pictureBoxStereoImage.Size = new System.Drawing.Size(520, 325);
            this.pictureBoxStereoImage.TabIndex = 2;
            this.pictureBoxStereoImage.TabStop = false;
            // 
            // buttonLoadImageLeft
            // 
            this.buttonLoadImageLeft.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadImageLeft.Location = new System.Drawing.Point(49, 168);
            this.buttonLoadImageLeft.Name = "buttonLoadImageLeft";
            this.buttonLoadImageLeft.Size = new System.Drawing.Size(76, 29);
            this.buttonLoadImageLeft.TabIndex = 5;
            this.buttonLoadImageLeft.Text = "Load";
            this.buttonLoadImageLeft.UseVisualStyleBackColor = true;
            this.buttonLoadImageLeft.Click += new System.EventHandler(this.LoadImageLeft_Click);
            // 
            // buttonLoadImageRight
            // 
            this.buttonLoadImageRight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadImageRight.Location = new System.Drawing.Point(49, 464);
            this.buttonLoadImageRight.Name = "buttonLoadImageRight";
            this.buttonLoadImageRight.Size = new System.Drawing.Size(76, 29);
            this.buttonLoadImageRight.TabIndex = 6;
            this.buttonLoadImageRight.Text = "Load";
            this.buttonLoadImageRight.UseVisualStyleBackColor = true;
            this.buttonLoadImageRight.Click += new System.EventHandler(this.LoadImageRight_Click);
            // 
            // buttonStereo
            // 
            this.buttonStereo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStereo.Location = new System.Drawing.Point(549, 313);
            this.buttonStereo.Name = "buttonStereo";
            this.buttonStereo.Size = new System.Drawing.Size(76, 29);
            this.buttonStereo.TabIndex = 7;
            this.buttonStereo.Text = "Stereo";
            this.buttonStereo.UseVisualStyleBackColor = true;
            this.buttonStereo.Click += new System.EventHandler(this.buttonStereo_Click);
            // 
            // numericUpDownBlocksize
            // 
            this.numericUpDownBlocksize.Location = new System.Drawing.Point(549, 349);
            this.numericUpDownBlocksize.Name = "numericUpDownBlocksize";
            this.numericUpDownBlocksize.Size = new System.Drawing.Size(76, 23);
            this.numericUpDownBlocksize.TabIndex = 8;
            this.numericUpDownBlocksize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDownSearchRadius
            // 
            this.numericUpDownSearchRadius.Location = new System.Drawing.Point(549, 378);
            this.numericUpDownSearchRadius.Name = "numericUpDownSearchRadius";
            this.numericUpDownSearchRadius.Size = new System.Drawing.Size(76, 23);
            this.numericUpDownSearchRadius.TabIndex = 9;
            this.numericUpDownSearchRadius.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // StereoVisionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.numericUpDownSearchRadius);
            this.Controls.Add(this.numericUpDownBlocksize);
            this.Controls.Add(this.buttonStereo);
            this.Controls.Add(this.buttonLoadImageRight);
            this.Controls.Add(this.buttonLoadImageLeft);
            this.Controls.Add(this.pictureBoxStereoImage);
            this.Controls.Add(this.pictureBoxImageRight);
            this.Controls.Add(this.pictureBoxImageLeft);
            this.Name = "StereoVisionUserControl";
            this.Size = new System.Drawing.Size(1485, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStereoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlocksize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSearchRadius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImageLeft;
        private System.Windows.Forms.PictureBox pictureBoxImageRight;
        private System.Windows.Forms.PictureBox pictureBoxStereoImage;
        private System.Windows.Forms.Button buttonLoadImageLeft;
        private System.Windows.Forms.Button buttonLoadImageRight;
        private System.Windows.Forms.Button buttonStereo;
        private System.Windows.Forms.NumericUpDown numericUpDownBlocksize;
        private System.Windows.Forms.NumericUpDown numericUpDownSearchRadius;
    }
}
