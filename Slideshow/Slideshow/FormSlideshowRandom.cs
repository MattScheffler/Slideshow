using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Slideshow
{
    public partial class FormSlideshowRandom : Form
    {
        public static List<string> picturesRandom = new List<string>();
        public static Random currentImageRandom = new Random();
        public static Timer pictureTimeRandom = new Timer();

        public FormSlideshowRandom()
        {
            InitializeComponent();
        }

        private void FormSlideshowRandom_Load(object sender, EventArgs e)
        {
            foreach(string file in System.IO.Directory.GetFiles(FormMainMenu.path))
            {
                switch (Path.GetExtension(file))
                {
                    case ".jpeg:":
                        picturesRandom.Add(file);
                        break;
                    case ".jpg":
                        picturesRandom.Add(file);
                        break;
                    case ".png":
                        picturesRandom.Add(file);
                        break;
                    case ".tiff":
                        picturesRandom.Add(file);
                        break;
                    case ".gif":
                        picturesRandom.Add(file);
                        break;
                    case ".bmp":
                        picturesRandom.Add(file);
                        break;
                    default:
                        break;
                }
            }

            pictureBoxRandom.ImageLocation = picturesRandom[currentImageRandom.Next(0, picturesRandom.Count)];
            this.Text = System.IO.Path.GetFileName(pictureBoxRandom.ImageLocation);
            pictureTimeRandom.Interval = (FormMainMenu.time * 1000);
            pictureTimeRandom.Tick += new EventHandler(pictureChangeRandom);
            pictureTimeRandom.Start();
        }

        private void pictureChangeRandom(object sender, EventArgs e)
        {
            pictureBoxRandom.ImageLocation = picturesRandom[currentImageRandom.Next(0, picturesRandom.Count)];
            this.Text = System.IO.Path.GetFileName(pictureBoxRandom.ImageLocation);
        }

        private void FormSlideshowRandom_FormClosed(object sender, FormClosedEventArgs e)
        {
            picturesRandom.Clear();
            pictureTimeRandom.Stop();
        }
    }
}
