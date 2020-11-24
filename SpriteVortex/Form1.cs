using BumpKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteVortex
{
    public partial class Form1 : Form
    {
        int selectedIndex;
        bool animation = false;
        PictureBox selectedBox;
        Bitmap originalImage;
        List<Bitmap> slicedImages;
        string fileName;

        public Form1()
        {
            InitializeComponent();
            UseImmersiveDarkMode(Handle, true);
        }

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        private static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
            int useImmersiveDarkMode = enabled ? 1 : 0;
            return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
        }


        private void btn_Browse_Click(object sender, EventArgs e)
        {
            StopAnimation();

            if (sheetDialog.ShowDialog() == DialogResult.OK)
            {
                if (imageSliderPanel.Controls.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure? Any unsaved sprites will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        OpenNewSheet();
                    }
                }

                else
                {
                    OpenNewSheet();
                }
            }
        }

        private void OpenNewSheet()
        {
            slicedImages.Clear();
            imageSliderPanel.Controls.Clear();
            displayBox.Image = displayBox.InitialImage;
            renameBox.Enabled = false;
            renameBox.Text = "[Image Name]";
            saveAllButton.Enabled = false;
            saveButton.Enabled = false;
            forwardButton.Enabled = false;
            backwardButton.Enabled = false;
            playPauseButton.Enabled = false;
            playPauseButton.Text = "Play";
            stopButton.Enabled = false;
            radio30.Enabled = false;
            radio60.Enabled = false;
            txt_horizontalImages.Text = txt_verticalImages.Text = "0";
            fileName = sheetDialog.FileName.Substring(sheetDialog.FileName.LastIndexOf('\\') + 1);
            originalImage = (Bitmap)Image.FromFile(sheetDialog.FileName);
            sheetBox.Image = (Bitmap)originalImage.Clone();
            UpdateInfoPanel(sheetDialog.FileName);
            txt_horizontalImages.Text = txt_verticalImages.Text = "1";
            btn_Slice.Enabled = txt_horizontalImages.Enabled = txt_verticalImages.Enabled = true;
        }

        public List<Bitmap> Slice()
        {
            Rectangle section;
            List<Bitmap> slicedImages = new List<Bitmap>();
            int horizontalImages = Convert.ToInt32(txt_horizontalImages.Text);
            int verticalImages = Convert.ToInt32(txt_verticalImages.Text);

            for (int j = 0; j < verticalImages; j++)
            {
                for (int i = 0; i < horizontalImages; i++)
                {
                    section = new Rectangle(new Point(0 + originalImage.Width * i / horizontalImages, 0 + originalImage.Height * j / verticalImages), new Size(originalImage.Width / horizontalImages, originalImage.Height / verticalImages));
                    var bitmap = new Bitmap(section.Width, section.Height);
                    using (var g = Graphics.FromImage(bitmap))
                    {
                        g.DrawImage((Bitmap)originalImage.Clone(), 0, 0, section, GraphicsUnit.Pixel);
                        if (!IsTransparent(bitmap)) slicedImages.Add(bitmap);
                    }
                }
            }

            return slicedImages;
        }

        private void UpdateInfoPanel(string fileName)
        {
            FileInfo info = new FileInfo(fileName);
            long size = info.Length / 1024;
            infoLabel.Text = sheetDialog.FileName.Substring(sheetDialog.FileName.LastIndexOf('\\') + 1) + " | " + sheetBox.Image.Width + "x" + sheetBox.Image.Height + "px | ";
            infoLabel.Text += (size >= 1024) ? size / 1024 + "MB" : size + "KB";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            slicedImages = new List<Bitmap>();
            imageSliderPanel.Controls.Clear();
        }

        private void txt_horizontalImages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_horizontalImages_TextChanged(object sender, EventArgs e)
        {
            DrawRectangle();
        }

        private void txt_verticalImages_TextChanged(object sender, EventArgs e)
        {
            DrawRectangle();
        }

        private void DrawRectangle()
        {
            Rectangle section;
            sheetBox.Image = (Bitmap)originalImage.Clone();

            if (txt_horizontalImages.Text != "0" && txt_verticalImages.Text != "0" && txt_verticalImages.TextLength > 0 && txt_horizontalImages.TextLength > 0)
            {
                int horizontalImages = Convert.ToInt32(txt_horizontalImages.Text);
                int verticalImages = Convert.ToInt32(txt_verticalImages.Text);

                for (int i = 0; i < horizontalImages; i++)
                {
                    for (int j = 0; j < verticalImages; j++)
                    {
                        section = new Rectangle(new Point(0 + sheetBox.Image.Width * i / horizontalImages, 0 + sheetBox.Image.Height * j / verticalImages), new Size(sheetBox.Image.Width / horizontalImages, sheetBox.Image.Height / verticalImages));
                        using (Graphics g = Graphics.FromImage(sheetBox.Image))
                        {
                            g.DrawRectangle(new Pen(Color.FromArgb(114, 137, 218), 2), section);
                        }
                    }
                }

                btn_Slice.Enabled = true;
            }
            else
            {
                btn_Slice.Enabled = false;
            }

            sheetBox.Refresh();
        }

        private void btn_Slice_Click(object sender, EventArgs e)
        {
            StopAnimation();

            imageSliderPanel.Controls.Clear();
            slicedImages.Clear();
            slicedImages = Slice();
            for (int i = 0; i < slicedImages.Count; i++)
            {
                PictureBox spriteBox = new PictureBox();
                spriteBox.Size = new Size(100, 100);
                spriteBox.Location = new Point((10 * (i + 1)) + (100 * i), 10);
                spriteBox.SizeMode = PictureBoxSizeMode.Zoom;
                spriteBox.Image = slicedImages[i];
                spriteBox.Tag = fileName.Substring(0, fileName.IndexOf('.')) + "_" + (i + 1);
                spriteBox.Click += SpriteBox_Click;
                imageSliderPanel.Controls.Add(spriteBox);
            }
            foreach (PictureBox box in imageSliderPanel.Controls)
            {
                if (box.Tag.ToString() == fileName.Substring(0, fileName.IndexOf('.')) + "_" + 1)
                {
                    box.BorderStyle = BorderStyle.FixedSingle;
                    selectedBox = box;
                    selectedIndex = 0;
                    break;
                }
            }
            displayBox.Image = selectedBox.Image;
            renameBox.Enabled = true;
            renameBox.Text = selectedBox.Tag.ToString();
            saveButton.Enabled = true;
            saveAllButton.Enabled = true;
            forwardButton.Enabled = true;
            backwardButton.Enabled = true;
            playPauseButton.Enabled = true;
            radio30.Enabled = true;
            radio60.Enabled = true;
        }

        private void SpriteBox_Click(object sender, EventArgs e)
        {
            StopAnimation();

            var spriteBox = sender as PictureBox;
            foreach (PictureBox box in imageSliderPanel.Controls)
            {
                if (box.BorderStyle == BorderStyle.FixedSingle)
                {
                    box.BorderStyle = BorderStyle.None;
                    break;
                }
            }
            spriteBox.BorderStyle = BorderStyle.FixedSingle;
            selectedBox = spriteBox;
            selectedIndex = imageSliderPanel.Controls.IndexOf(selectedBox);
            displayBox.Image = selectedBox.Image;
            renameBox.Text = selectedBox.Tag.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StopAnimation();

            SaveFileDialog saveSpriteDialog = new SaveFileDialog();
            saveSpriteDialog.Title = "Save Sprite As";
            saveSpriteDialog.CheckPathExists = true;
            saveSpriteDialog.DefaultExt = "png";
            saveSpriteDialog.Filter = "Bitmap Image|*.bmp|JPEG Image|*.jpeg|Png Image|*.png";
            saveSpriteDialog.FilterIndex = 3;
            saveSpriteDialog.RestoreDirectory = true;
            saveSpriteDialog.FileName = renameBox.Text;
            if (saveSpriteDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveSpriteDialog.FilterIndex == 1)
                {
                    displayBox.Image.Save(saveSpriteDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                else if (saveSpriteDialog.FilterIndex == 2)
                {
                    displayBox.Image.Save(saveSpriteDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (saveSpriteDialog.FilterIndex == 3)
                {
                    displayBox.Image.Save(saveSpriteDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void saveAllButton_Click(object sender, EventArgs e)
        {
            StopAnimation();

            SaveFileDialog saveSpriteDialog = new SaveFileDialog();
            saveSpriteDialog.Title = "Save All Sprites As";
            saveSpriteDialog.CheckPathExists = true;
            saveSpriteDialog.DefaultExt = "png";
            saveSpriteDialog.Filter = "Bitmap Image|*.bmp|GIF Image|*.gif|JPEG Image|*.jpeg|Png Image|*.png";
            saveSpriteDialog.FilterIndex = 4;
            saveSpriteDialog.RestoreDirectory = true;
            saveSpriteDialog.FileName = fileName.Substring(0, fileName.IndexOf('.'));
            if (saveSpriteDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = Path.GetDirectoryName(saveSpriteDialog.FileName);

                if (saveSpriteDialog.FilterIndex == 2)
                {
                    using (var gif = File.OpenWrite(savePath + "\\" + fileName.Substring(0, fileName.IndexOf('.')) + ".gif"))
                    {
                        var encoder = new GifEncoder(gif);                      
                        for (int i = 0; i < imageSliderPanel.Controls.Count; i++)
                        {
                            var spriteBox = imageSliderPanel.Controls[i] as PictureBox;
                            var frame = spriteBox.Image;
                            encoder.AddFrame(frame);
                        }
                    }                                    
                }
                else 
                {
                    for (int i = 0; i < imageSliderPanel.Controls.Count; i++)
                    {
                        var spriteBox = imageSliderPanel.Controls[i] as PictureBox;

                        if (saveSpriteDialog.FilterIndex == 1)
                        {
                            spriteBox.Image.Save(savePath + "\\" + fileName.Substring(0, fileName.IndexOf('.')) + "_" + (i + 1) + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                        else if (saveSpriteDialog.FilterIndex == 3)
                        {
                            spriteBox.Image.Save(savePath + "\\" + fileName.Substring(0, fileName.IndexOf('.')) + "_" + (i + 1) + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        else if (saveSpriteDialog.FilterIndex == 4)
                        {
                            spriteBox.Image.Save(savePath + "\\" + fileName.Substring(0, fileName.IndexOf('.')) + "_" + (i + 1) + ".png", System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
            }
        }

        private void StopAnimation()
        {
            if (animation)
            {
                animation = false;
                playPauseButton.Text = "Play";
                stopButton.Enabled = false;
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            StopAnimation();

            foreach (PictureBox box in imageSliderPanel.Controls)
            {
                if (box.BorderStyle == BorderStyle.FixedSingle)
                {
                    box.BorderStyle = BorderStyle.None;
                    break;
                }
            }

            if (selectedIndex + 1 < imageSliderPanel.Controls.Count)
            {
                selectedIndex++;
            }
            else 
            {
                selectedIndex = 0;
            }

            var selectedBox = imageSliderPanel.Controls[selectedIndex] as PictureBox;
            selectedBox.BorderStyle = BorderStyle.FixedSingle;
            displayBox.Image = selectedBox.Image;
            renameBox.Text = selectedBox.Tag.ToString();
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {
            StopAnimation();

            foreach (PictureBox box in imageSliderPanel.Controls)
            {
                if (box.BorderStyle == BorderStyle.FixedSingle)
                {
                    box.BorderStyle = BorderStyle.None;
                    break;
                }
            }

            if (selectedIndex - 1 >= 0)
            {
                selectedIndex--;
            }
            else
            {
                selectedIndex = imageSliderPanel.Controls.Count - 1;
            }

            var selectedBox = imageSliderPanel.Controls[selectedIndex] as PictureBox;
            selectedBox.BorderStyle = BorderStyle.FixedSingle;
            displayBox.Image = selectedBox.Image;
            renameBox.Text = selectedBox.Tag.ToString();
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if (animation)
            {
                animation = false;
                playPauseButton.Text = "Play";
                stopButton.Enabled = false;
            }
            else 
            {
                animation = true;
                playPauseButton.Text = "Pause";
                stopButton.Enabled = true;
                animationTimer.Enabled = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            animation = false;
            playPauseButton.Text = "Play";

            foreach (PictureBox box in imageSliderPanel.Controls)
            {
                if (box.BorderStyle == BorderStyle.FixedSingle)
                {
                    box.BorderStyle = BorderStyle.None;
                    break;
                }
            }

            var selectedBox = imageSliderPanel.Controls[0] as PictureBox;
            selectedBox.BorderStyle = BorderStyle.FixedSingle;
            displayBox.Image = selectedBox.Image;
            renameBox.Text = selectedBox.Tag.ToString();

            stopButton.Enabled = false;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (animation)
            {
                foreach (PictureBox box in imageSliderPanel.Controls)
                {
                    if (box.BorderStyle == BorderStyle.FixedSingle)
                    {
                        box.BorderStyle = BorderStyle.None;
                        break;
                    }
                }

                if (selectedIndex + 1 < imageSliderPanel.Controls.Count)
                {
                    selectedIndex++;
                }
                else
                {
                    selectedIndex = 0;
                }

                var selectedBox = imageSliderPanel.Controls[selectedIndex] as PictureBox;
                selectedBox.BorderStyle = BorderStyle.FixedSingle;
                displayBox.Image = selectedBox.Image;
                renameBox.Text = selectedBox.Tag.ToString();
            }
            else 
            {
                animationTimer.Enabled = false;
            }

        }

        private void radio60_CheckedChanged(object sender, EventArgs e)
        {
            if (radio60.Checked)
            {
                animationTimer.Interval = 1000 / 60;
            }
            else 
            {
                animationTimer.Interval = 1000 / 30;
            }
        }

        bool IsTransparent(Bitmap image)
        {
            bool fullTransparent = true;

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    if (image.GetPixel(x, y).A > 0)
                    {
                        fullTransparent = false;
                        break;
                    }
                }
            }
            return fullTransparent;
        }
    }
}
