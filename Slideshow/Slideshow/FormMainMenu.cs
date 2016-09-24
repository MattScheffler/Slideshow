using System;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class FormMainMenu : Form
    {
        //values for the path to the pictures folder and the time between pictures
        //these need to be accessed by the other forms
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

        private void secondsSelector_ValueChanged(object sender, EventArgs e)
        {
            time = (int)secondsSelector.Value;
        }

        //The slideshow forms are not dialog boxes so multiple shows can be active if desired
        private void buttonStartNormal_Click(object sender, EventArgs e)
        {
            path = textBoxPathDisplay.Text;
            FormSlideshow slideshow = new FormSlideshow();
            slideshow.Show();
        }

        private void buttonStartRandom_Click(object sender, EventArgs e)
        {
            path = textBoxPathDisplay.Text;
            FormSlideshowRandom slideshowRandom = new FormSlideshowRandom();
            slideshowRandom.Show();
        }
    }
}
