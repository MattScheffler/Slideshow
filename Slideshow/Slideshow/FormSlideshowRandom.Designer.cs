namespace Slideshow
{
    partial class FormSlideshowRandom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSlideshowRandom));
            this.pictureBoxRandom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRandom
            // 
            this.pictureBoxRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRandom.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxRandom.Name = "pictureBoxRandom";
            this.pictureBoxRandom.Size = new System.Drawing.Size(982, 549);
            this.pictureBoxRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRandom.TabIndex = 0;
            this.pictureBoxRandom.TabStop = false;
            // 
            // FormSlideshowRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 550);
            this.Controls.Add(this.pictureBoxRandom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSlideshowRandom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Slideshow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSlideshowRandom_FormClosed);
            this.Load += new System.EventHandler(this.FormSlideshowRandom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRandom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRandom;
    }
}