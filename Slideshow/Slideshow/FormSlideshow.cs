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
        public static bool first;

        public FormSlideshow()
        {
            InitializeComponent();
        }

        //
        private void Form2_Load(object sender, EventArgs e)
        {
            currentImage = 0;
            first = true;
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
            else if (currentImage >= pictures.Count - 1)
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
            FormMainMenu.path = String.Empty;
            pictures.Clear();
            pictureTime.Stop();
        }
    }
}
