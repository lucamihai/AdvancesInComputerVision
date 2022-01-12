
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
            this.panelActiveUserControl = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageCroppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stereoVisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inPaintingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActiveUserControl
            // 
            this.panelActiveUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActiveUserControl.Location = new System.Drawing.Point(0, 25);
            this.panelActiveUserControl.Name = "panelActiveUserControl";
            this.panelActiveUserControl.Size = new System.Drawing.Size(1485, 700);
            this.panelActiveUserControl.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageCroppingToolStripMenuItem,
            this.stereoVisionToolStripMenuItem,
            this.inPaintingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1534, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageCroppingToolStripMenuItem
            // 
            this.imageCroppingToolStripMenuItem.Name = "imageCroppingToolStripMenuItem";
            this.imageCroppingToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.imageCroppingToolStripMenuItem.Text = "Image cropping";
            this.imageCroppingToolStripMenuItem.Click += new System.EventHandler(this.imageCroppingToolStripMenuItem_Click);
            // 
            // stereoVisionToolStripMenuItem
            // 
            this.stereoVisionToolStripMenuItem.Name = "stereoVisionToolStripMenuItem";
            this.stereoVisionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.stereoVisionToolStripMenuItem.Text = "Stereo Vision";
            this.stereoVisionToolStripMenuItem.Click += new System.EventHandler(this.stereoVisionToolStripMenuItem_Click);
            // 
            // inPaintingToolStripMenuItem
            // 
            this.inPaintingToolStripMenuItem.Name = "inPaintingToolStripMenuItem";
            this.inPaintingToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.inPaintingToolStripMenuItem.Text = "InPainting";
            this.inPaintingToolStripMenuItem.Click += new System.EventHandler(this.inPaintingToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1534, 761);
            this.Controls.Add(this.panelActiveUserControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelActiveUserControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageCroppingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stereoVisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inPaintingToolStripMenuItem;
    }
}

