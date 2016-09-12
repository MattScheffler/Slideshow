using System;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class FormSlideshowRandom : Form
    {
        public static string[] picturesRandom;
        public static Random currentImageRandom = new Random();
        public static Timer pictureTimeRandom = new Timer();
        public static bool firstRandom;

        public FormSlideshowRandom()
        {
            InitializeComponent();
        }

        private void FormSlideshowRandom_Load(object sender, EventArgs e)
        {
            firstRandom = true;
            picturesRandom = System.IO.Directory.GetFiles(FormMainMenu.path);
            pictureBoxRandom.ImageLocation = picturesRandom[currentImageRandom.Next(0, picturesRandom.Length)];
            pictureTimeRandom.Interval = (FormMainMenu.time * 1000);
            pictureTimeRandom.Tick += new EventHandler(pictureChangeRandom);
            pictureTimeRandom.Start();
        }

        private void pictureChangeRandom(object sender, EventArgs e)
        {
            pictureBoxRandom.ImageLocation = picturesRandom[currentImageRandom.Next(0, picturesRandom.Length)];
        }

        private void FormSlideshowRandom_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureTimeRandom.Stop();
        }
    }
}
