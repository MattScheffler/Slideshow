using System;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class FormMainMenu : Form
    {
        //values for the path to the pictures folder and the time between pictures
        public static string path;
        public static int time = 1;

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonPathSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                textBoxPathDisplay.Text = folderBrowserDialog.SelectedPath + '\\';
            }
        }

        private void textBoxPathDisplay_TextChanged(object sender, EventArgs e)
        {
            path = textBoxPathDisplay.Text;
        }

        private void secondsSelector_ValueChanged(object sender, EventArgs e)
        {
            time = (int)secondsSelector.Value;
        }

        private void buttonStartNormal_Click(object sender, EventArgs e)
        {
            FormSlideshow slideshow = new FormSlideshow();
            slideshow.Show();
        }

        private void buttonStartRandom_Click(object sender, EventArgs e)
        {
            FormSlideshowRandom slideshowRandom = new FormSlideshowRandom();
            slideshowRandom.Show();
        }
    }
}
