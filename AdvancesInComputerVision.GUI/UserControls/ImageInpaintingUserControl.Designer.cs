
namespace AdvancesInComputerVision.GUI.UserControls
{
    partial class ImageInPaintingUserControl
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
            this.pictureBoxImageBefore = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageAfter = new System.Windows.Forms.PictureBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.buttonInPainting = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCloseShape = new System.Windows.Forms.Button();
            this.buttonHighlightSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImageBefore
            // 
            this.pictureBoxImageBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageBefore.Location = new System.Drawing.Point(32, 77);
            this.pictureBoxImageBefore.Name = "pictureBoxImageBefore";
            this.pictureBoxImageBefore.Size = new System.Drawing.Size(560, 560);
            this.pictureBoxImageBefore.TabIndex = 0;
            this.pictureBoxImageBefore.TabStop = false;
            this.pictureBoxImageBefore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImageBefore_MouseClick);
            // 
            // pictureBoxImageAfter
            // 
            this.pictureBoxImageAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageAfter.Location = new System.Drawing.Point(658, 77);
            this.pictureBoxImageAfter.Name = "pictureBoxImageAfter";
            this.pictureBoxImageAfter.Size = new System.Drawing.Size(560, 560);
            this.pictureBoxImageAfter.TabIndex = 1;
            this.pictureBoxImageAfter.TabStop = false;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadImage.Location = new System.Drawing.Point(32, 42);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(76, 29);
            this.buttonLoadImage.TabIndex = 6;
            this.buttonLoadImage.Text = "Load";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // buttonInPainting
            // 
            this.buttonInPainting.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInPainting.Location = new System.Drawing.Point(658, 42);
            this.buttonInPainting.Name = "buttonInPainting";
            this.buttonInPainting.Size = new System.Drawing.Size(76, 29);
            this.buttonInPainting.TabIndex = 7;
            this.buttonInPainting.Text = "InPainting";
            this.buttonInPainting.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(128, 42);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(76, 29);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCloseShape
            // 
            this.buttonCloseShape.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCloseShape.Location = new System.Drawing.Point(496, 42);
            this.buttonCloseShape.Name = "buttonCloseShape";
            this.buttonCloseShape.Size = new System.Drawing.Size(96, 29);
            this.buttonCloseShape.TabIndex = 9;
            this.buttonCloseShape.Text = "Close Shape";
            this.buttonCloseShape.UseVisualStyleBackColor = true;
            this.buttonCloseShape.Click += new System.EventHandler(this.buttonCloseShape_Click);
            // 
            // buttonHighlightSelection
            // 
            this.buttonHighlightSelection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHighlightSelection.Location = new System.Drawing.Point(414, 42);
            this.buttonHighlightSelection.Name = "buttonHighlightSelection";
            this.buttonHighlightSelection.Size = new System.Drawing.Size(76, 29);
            this.buttonHighlightSelection.TabIndex = 10;
            this.buttonHighlightSelection.Text = "Highlight";
            this.buttonHighlightSelection.UseVisualStyleBackColor = true;
            this.buttonHighlightSelection.Click += new System.EventHandler(this.buttonHighlightSelection_Click);
            // 
            // ImageInPaintingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.buttonHighlightSelection);
            this.Controls.Add(this.buttonCloseShape);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonInPainting);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.pictureBoxImageAfter);
            this.Controls.Add(this.pictureBoxImageBefore);
            this.Name = "ImageInPaintingUserControl";
            this.Size = new System.Drawing.Size(1485, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageAfter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImageBefore;
        private System.Windows.Forms.PictureBox pictureBoxImageAfter;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonInPainting;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCloseShape;
        private System.Windows.Forms.Button buttonHighlightSelection;
    }
}
