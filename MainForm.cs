using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace TVavtomat
{
    public partial class MainForm : Form
    {
        List<Tuple<int, int, int>> list = new List<Tuple<int, int, int>>();
        SoundPlayer player = new SoundPlayer();
        bool isOn = false;
        int z_0 = 1;
        Image img;

        public MainForm()
        {
            InitializeComponent();
            TVisOFF();
            ResetText();
            buttonReset.Enabled = false;
        }

        private void ButtonTV_Click(object sender, EventArgs e)
        {
            UpdateList(new Tuple<int, int, int>(1, 2, 1));
            isOn = true;
            SetImage("C:\\Users\\anyap\\Desktop\\tv.gif");
            player.Stop();
        }

        private void ButtonInternet_Click(object sender, EventArgs e)
        {
            UpdateList(new Tuple<int, int, int>(2, 3, 4));
            buttonTV.Enabled = true;
            SetImage("C:\\Users\\anyap\\Desktop\\web.png");
            player.Stop();
        }

        private void ButtonMusic_Click(object sender, EventArgs e)
        {
            UpdateList(new Tuple<int, int, int>(3, 4, 3));
            buttonTV.Enabled = true;
            SetImage("C:\\Users\\anyap\\Desktop\\music.jpg");
            
            player.SoundLocation = @"C:\\Users\\anyap\\Downloads\\Bobby Helms - Jingle Bell Rock.wav";
            player.Load();
            player.Play();
        }

        private void ButtonOnOff_Click(object sender, EventArgs e)
        {
            if (!isOn) {
                UpdateList(new Tuple<int, int, int>(1, 2, 1));
                isOn = true;
                TVisON();
                SetImage("C:\\Users\\anyap\\Desktop\\tv.gif");
            } else {
                UpdateList(new Tuple<int, int, int>(4, 1, 2));
                isOn = false;
                TVisOFF();
                pictureBox.Image = null;
                player.Stop();
            }
            
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetText();
            z_0 = list.Last().Item2;
            list.Clear();
            buttonReset.Enabled = false;
        }

        private void TVisON()
        {
            buttonInternet.Enabled = true;
            buttonMusic.Enabled = true;
        }

        private void TVisOFF()
        {
            buttonTV.Enabled = false;
            buttonInternet.Enabled = false;
            buttonMusic.Enabled = false;
        }

        private void ResetText()
        {
            xOutput.Text = "";
            zOutput.Text = "";
            yOutput.Text = "";
            z0.Text = "";
        }

        private void UpdateList(Tuple<int, int, int> current)
        {
            list.Add(current);
            buttonReset.Enabled = true;
            ResetText();
            z0.Text = "z" + z_0;

            foreach (var item in list)
            {
                xOutput.Text = xOutput.Text + "x" + item.Item1 + "  ";
                zOutput.Text = zOutput.Text + "z" + item.Item2 + "  ";
                yOutput.Text = yOutput.Text + "y" + item.Item3 + "  ";
            }
        }

        private void SetImage(String url)
        {
            img = Image.FromFile(url);
            img = ResizeImage(img, 400, 350);
            pictureBox.Image = img;
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
