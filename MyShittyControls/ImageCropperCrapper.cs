using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShittyControls
{
    public partial class ImageCropperCrapper: UserControl
    {
        private IProgram prog;
        private AbstractTool curTool;
        private Image curImage;

        public CropSpec CropSpec { get; set; }
        
        public ImageCropperCrapper()
        {
            InitializeComponent();

            curImage = null;

            // drag drop
            pictureBox.AllowDrop = true;
            pictureBox.DragEnter += pictureBox_DragEnter;
            pictureBox.DragDrop += pictureBox_DragDrop;
            // mouse events
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseUp += pictureBox_MouseUp;
            pictureBox.MouseMove += pictureBox_MouseMove;
        }

        public void initShit(IProgram prog)
        {
            this.prog = prog;
            CropSpec = new MyShittyControls.CropSpec();
            curTool = new RectTool(prog, CropSpec);
            pictureBox.CropRect = CropSpec.CropRect;
        }

        //public Image Image {
        //    get { return pictureBox.Image; }
        //}

        public Rectangle CropRectangle {
            get {
                var img = CropSpec.Image;
                return new Rectangle {
                    X = (CropSpec.CropRect.X - pictureBox.ImageLeft) * CropSpec.Image.Width / pictureBox.ImageWidth,
                    Y = (CropSpec.CropRect.Y - pictureBox.ImageTop) * CropSpec.Image.Height / pictureBox.ImageHeight,
                    Width = CropSpec.CropRect.W * CropSpec.Image.Width / pictureBox.ImageWidth,
                    Height = CropSpec.CropRect.H * CropSpec.Image.Height / pictureBox.ImageHeight,
                };
            }
        }

        #region pictureBox

        private bool isMouseDown = false;
        private void pictureBox_MouseDown(object sender, MouseEventArgs e) {
            isMouseDown = true;
            if (curTool == null)
                return;
            curTool.OnMouseDown(e.X, e.Y);
            pictureBox.Invalidate();
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e) {
            isMouseDown = false;
            if (curTool == null)
                return;
            curTool.OnMouseUp(e.X, e.Y);
            pictureBox.Invalidate();
            prog.CroppingChanged();
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e) {
            if (curTool == null)
                return;
            if (isMouseDown) {
                curTool.OnMouseDrag(e.X, e.Y);
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true) {
                e.Effect = DragDropEffects.All;
            }
        }
        private void pictureBox_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var file = files.FirstOrDefault();
            if (file == null)
                return;
            var curImage = new Bitmap(Image.FromFile(file));
            setImage(curImage);
            prog.DragDropped(curImage);
        }
        private void setImage(Image img) {
            curImage = img;
            if (pictureBox.Image != null) {
                pictureBox.Image.Dispose();
            }
            pictureBox.Image = curImage;
            CropSpec.Image = img;
        }
        #endregion

        private void btnTillTop_Click(object sender, EventArgs e) {
            var bottom = pictureBox.CropRect.Y + pictureBox.CropRect.H;
            pictureBox.CropRect.Y = pictureBox.ImageTop;
            pictureBox.CropRect.H = bottom - pictureBox.CropRect.Y;
            pictureBox.Invalidate();
            prog.CroppingChanged();
        }
        private void btnTillBottom_Click(object sender, EventArgs e) {
            var bottom = pictureBox.ImageTop + pictureBox.ImageHeight;
            //pictureBox.CropRect.Y = pictureBox.ImageTop;
            pictureBox.CropRect.H = bottom - pictureBox.CropRect.Y;
            pictureBox.Invalidate();
            prog.CroppingChanged();
        }
        private void btnTillLeft_Click(object sender, EventArgs e) {
            var right = pictureBox.CropRect.X + pictureBox.CropRect.W;
            pictureBox.CropRect.X = pictureBox.ImageLeft;
            pictureBox.CropRect.W = right - pictureBox.CropRect.X;
            pictureBox.Invalidate();
            prog.CroppingChanged();
        }
        private void btnTillRight_Click(object sender, EventArgs e) {
            var right = pictureBox.ImageLeft + pictureBox.ImageWidth;
            //pictureBox.CropRect.X = pictureBox.ImageLeft;
            pictureBox.CropRect.W = right - pictureBox.CropRect.X;
            pictureBox.Invalidate();
            prog.CroppingChanged();
        }

        private void btnAll_Click(object sender, EventArgs e) {
            var bottom = pictureBox.CropRect.Y + pictureBox.CropRect.H;
            pictureBox.CropRect.Y = pictureBox.ImageTop;
            pictureBox.CropRect.H = bottom - pictureBox.CropRect.Y;
            bottom = pictureBox.ImageTop + pictureBox.ImageHeight;
            //pictureBox.CropRect.Y = pictureBox.ImageTop;
            pictureBox.CropRect.H = bottom - pictureBox.CropRect.Y;
            var right = pictureBox.CropRect.X + pictureBox.CropRect.W;
            pictureBox.CropRect.X = pictureBox.ImageLeft;
            pictureBox.CropRect.W = right - pictureBox.CropRect.X;
            right = pictureBox.ImageLeft + pictureBox.ImageWidth;
            //pictureBox.CropRect.X = pictureBox.ImageLeft;
            pictureBox.CropRect.W = right - pictureBox.CropRect.X;

            pictureBox.Invalidate();
            prog.CroppingChanged();
        }
    }
}
