using System;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class FormSlideshow : Form
    {
        public static string[] pictures;
        public static int currentImage;
        public static Timer pictureTime = new Timer();
        public static bool first;

        public FormSlideshow()
        {
            InitializeComponent();
        }

        //
        private void Form2_Load(object sender, EventArgs e)
        {
            first = true;
            pictures = System.IO.Directory.GetFiles(FormMainMenu.path);
            currentImage = 0;
            pictureBox.ImageLocation = pictures[currentImage];
            pictureTime.Interval = (FormMainMenu.time * 1000);
            pictureTime.Tick += new EventHandler(pictureChange);
            pictureTime.Start();
        }

        private void pictureChange(object sender, EventArgs e)
        {
            //This first condition is only used once when the form is first loaded to
            //avoid showing the first image twice or messing the order up some other way
            if (first)
            {
                currentImage += 2;
                pictureBox.ImageLocation = pictures[1];
                first = false;
            }
            else if (currentImage >= pictures.Length - 1)
            {
                pictureBox.ImageLocation = pictures[currentImage];
                currentImage = 0;
            }
            else
            {
                pictureBox.ImageLocation = pictures[currentImage];
                currentImage += 1;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureTime.Stop();
        }
    }
}
