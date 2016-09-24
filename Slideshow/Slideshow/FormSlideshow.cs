using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Slideshow
{
    public partial class FormSlideshow : Form
    {
        public static List<string> pictures = new List<string>();
        public static int currentImage;
        public static Timer pictureTime = new Timer();

        public FormSlideshow()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            currentImage = 0;
            //filter to only get image files
            foreach (string file in System.IO.Directory.GetFiles(FormMainMenu.path))
            {
                switch (Path.GetExtension(file))
                {
                    case ".jpeg":
                        pictures.Add(file);
                        break;
                    case ".jpg":
                        pictures.Add(file);
                        break;
                    case ".png":
                        pictures.Add(file);
                        break;
                    case ".tiff":
                        pictures.Add(file);
                        break;
                    case ".gif":
                        pictures.Add(file);
                        break;
                    case ".bmp":
                        pictures.Add(file);
                        break;
                    default:
                        break;
                }
            }

            pictureBox.ImageLocation = pictures[currentImage];
            this.Text = System.IO.Path.GetFileName(pictureBox.ImageLocation);
            pictureTime.Interval = (FormMainMenu.time * 1000);
            pictureTime.Tick += new EventHandler(pictureChange);
            pictureTime.Start();
        }

        private void pictureChange(object sender, EventArgs e)
        {
            currentImage += 1;
            if (currentImage == pictures.Count)
            {
                currentImage = 0;
                pictureBox.ImageLocation = pictures[currentImage];
            }
            else
            {
                pictureBox.ImageLocation = pictures[currentImage];
            }

            this.Text = System.IO.Path.GetFileName(pictureBox.ImageLocation);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictures.Clear();
            pictureTime.Stop();
        }
    }
}
