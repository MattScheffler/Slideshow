namespace Slideshow
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPathDisplay = new System.Windows.Forms.TextBox();
            this.buttonPathSelect = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.secondsSelector = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartNormal = new System.Windows.Forms.Button();
            this.buttonStartRandom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSelector)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPathDisplay);
            this.groupBox1.Controls.Add(this.buttonPathSelect);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select path";
            // 
            // textBoxPathDisplay
            // 
            this.textBoxPathDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPathDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathDisplay.Location = new System.Drawing.Point(98, 38);
            this.textBoxPathDisplay.Name = "textBoxPathDisplay";
            this.textBoxPathDisplay.Size = new System.Drawing.Size(579, 22);
            this.textBoxPathDisplay.TabIndex = 1;
            this.textBoxPathDisplay.TextChanged += new System.EventHandler(this.textBoxPathDisplay_TextChanged);
            // 
            // buttonPathSelect
            // 
            this.buttonPathSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPathSelect.Location = new System.Drawing.Point(17, 37);
            this.buttonPathSelect.Name = "buttonPathSelect";
            this.buttonPathSelect.Size = new System.Drawing.Size(71, 23);
            this.buttonPathSelect.TabIndex = 0;
            this.buttonPathSelect.Text = "Browse...";
            this.buttonPathSelect.UseVisualStyleBackColor = true;
            this.buttonPathSelect.Click += new System.EventHandler(this.buttonPathSelect_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // secondsSelector
            // 
            this.secondsSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsSelector.Location = new System.Drawing.Point(28, 44);
            this.secondsSelector.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.secondsSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondsSelector.Name = "secondsSelector";
            this.secondsSelector.Size = new System.Drawing.Size(51, 22);
            this.secondsSelector.TabIndex = 1;
            this.secondsSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondsSelector.ValueChanged += new System.EventHandler(this.secondsSelector_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.secondsSelector);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(268, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time between images";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seconds";
            // 
            // buttonStartNormal
            // 
            this.buttonStartNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartNormal.Location = new System.Drawing.Point(182, 274);
            this.buttonStartNormal.Name = "buttonStartNormal";
            this.buttonStartNormal.Size = new System.Drawing.Size(172, 68);
            this.buttonStartNormal.TabIndex = 3;
            this.buttonStartNormal.Text = "Regular Slideshow";
            this.buttonStartNormal.UseVisualStyleBackColor = true;
            this.buttonStartNormal.Click += new System.EventHandler(this.buttonStartNormal_Click);
            // 
            // buttonStartRandom
            // 
            this.buttonStartRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartRandom.Location = new System.Drawing.Point(377, 274);
            this.buttonStartRandom.Name = "buttonStartRandom";
            this.buttonStartRandom.Size = new System.Drawing.Size(172, 68);
            this.buttonStartRandom.TabIndex = 4;
            this.buttonStartRandom.Text = "Random Slideshow";
            this.buttonStartRandom.UseVisualStyleBackColor = true;
            this.buttonStartRandom.Click += new System.EventHandler(this.buttonStartRandom_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(734, 362);
            this.Controls.Add(this.buttonStartRandom);
            this.Controls.Add(this.buttonStartNormal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slideshow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSelector)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPathSelect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.NumericUpDown secondsSelector;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartNormal;
        private System.Windows.Forms.TextBox textBoxPathDisplay;
        private System.Windows.Forms.Button buttonStartRandom;
    }
}

