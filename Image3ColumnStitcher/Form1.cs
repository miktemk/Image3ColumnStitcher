using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyShittyControls;

namespace ImageSampler
{
	public partial class Form1 : Form, IProgram
	{
        private List<CropSpec> croppings;

		public Form1()
		{
			InitializeComponent();

            // init other shit
            imageCropperCrapper1.initShit(this);
            imageCropperCrapper2.initShit(this);
            imageCropperCrapper3.initShit(this);
            imageCropperCrapper4.initShit(this);

			// toiollzzzzzzz
		}

        private void pictureBox_DragEnter(object sender, DragEventArgs e) {
            SetText("pictureBox_DragEnter");
        }
        private void pictureBox_DragDrop(object sender, DragEventArgs e) {
            SetText("pictureBox_DragDrop");
        }

        #region iProgram members

        public void DragDropped(Image img)
        {
            txtWidth.Text = "" + img.Width;
            txtHeight.Text = "" + img.Height;
            reinitOutputImage();
        }

		public void SetText(string s)
		{
			lblTest.Text = s;
		}
        public void CroppingChanged()
        {
            updateOutputImage();            
        }

        private Bitmap imgOut;

        private void updateOutputImage() {
            if (imgOut == null)
                reinitOutputImage();

            if (imgOut == null)
                return;

            Graphics g = Graphics.FromImage(imgOut);

            var bbbBlack = new SolidBrush(Color.Black);
            g.FillRectangle(bbbBlack, 0, 0, imgOut.Width, imgOut.Height);
            
            if (imageCropperCrapper4.CropSpec.Image != null) {
                // ................ 4 quarters ................
                var pw = imgOut.Width / 2;
                var ph = imgOut.Height / 2;
                if (imageCropperCrapper1.CropSpec.Image != null)
                    g.DrawImage(imageCropperCrapper1.CropSpec.Image
                        , new Rectangle(0, 0, pw, ph)
                        , imageCropperCrapper1.CropRectangle.ChangeRatio(pw, ph), GraphicsUnit.Pixel);
                if (imageCropperCrapper2.CropSpec.Image != null)
                    g.DrawImage(imageCropperCrapper2.CropSpec.Image
                        , new Rectangle(pw, 0, pw, ph)
                        , imageCropperCrapper2.CropRectangle.ChangeRatio(pw, ph), GraphicsUnit.Pixel);
                if (imageCropperCrapper3.CropSpec.Image != null)
                    g.DrawImage(imageCropperCrapper3.CropSpec.Image
                        , new Rectangle(0, ph, pw, ph)
                        , imageCropperCrapper3.CropRectangle.ChangeRatio(pw, ph), GraphicsUnit.Pixel);
                if (imageCropperCrapper4.CropSpec.Image != null)
                    g.DrawImage(imageCropperCrapper4.CropSpec.Image
                        , new Rectangle(pw, ph, pw, ph)
                        , imageCropperCrapper4.CropRectangle.ChangeRatio(pw, ph), GraphicsUnit.Pixel);
            }
            else {
                // .................. 3 columns ..............
                var left = 0;
                if (imageCropperCrapper1.CropSpec.Image != null)
                    left += clampColumn(g, imageCropperCrapper1, left);
                if (imageCropperCrapper2.CropSpec.Image != null)
                    left += clampColumn(g, imageCropperCrapper2, left);
                if (imageCropperCrapper3.CropSpec.Image != null)
                    left += clampColumn(g, imageCropperCrapper3, left);
            }
            
            g.Flush();

            previewPanel.Invalidate();
        }

        private int clampColumn(Graphics g, ImageCropperCrapper imageCropperCrapper, int left) {
            var rectSrc = imageCropperCrapper.CropRectangle;
            if (rectSrc.Width == 0 || rectSrc.Height == 0)
                return 0;
            var stripWidth = imgOut.Height * rectSrc.Width / rectSrc.Height;
            g.DrawImage(imageCropperCrapper.CropSpec.Image,
                new Rectangle {
                    X = left,
                    Y = 0,
                    Width = stripWidth,
                    Height = imgOut.Height
                }, rectSrc, GraphicsUnit.Pixel);
            return stripWidth;
        }
        private void reinitOutputImage() {
            int w = 100, h = 100;
            int.TryParse(txtWidth.Text, out w);
            int.TryParse(txtHeight.Text, out h);
            if (w == 0 || h == 0) {
                MessageBox.Show("dimensions are not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;                
            }
            imgOut = new Bitmap(w, h);
            previewPanel.Image = imgOut;
        }

		#endregion

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Form1_Load_1(object sender, EventArgs e) {

        }

        private void btnSwitchWH_Click(object sender, EventArgs e) {
            var tmp = txtHeight.Text;
            txtHeight.Text = txtWidth.Text;
            txtWidth.Text = tmp;
            imgOut = null;
            updateOutputImage();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            updateOutputImage();
            var fff = new SaveFileDialog() {
                //CheckFileExists = true,
                Filter = "JPG|*.jpg|PNG|*.png",
            };
            var result = fff.ShowDialog();
            if (result != DialogResult.OK)
                return;

            imgOut.Save(fff.FileName);
        }

	}
}
