using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShittyControls
{
    public class CropperPanel : PictureBox
    {
        private Pen invalidPen;

        public MyRect CropRect { get; set; }

        public CropperPanel() {
            invalidPen = new Pen(Color.Cyan, 2);
        }

        public int ImageTop {get; set;}
        public int ImageLeft {get; set;}
        public int ImageWidth {get; set;}
        public int ImageHeight { get; set; }

        public new Image Image
        {
            get {
                return base.Image;
            }
            set {
                base.Image = value;
                if (value != null) {
                    var cw = this.Width;
                    var ch = this.Height;
                    var iw = Math.Min(cw, ch * value.Width / value.Height);
                    var ih = Math.Min(ch, cw * value.Height / value.Width);
                    var cwiw = (cw - iw) / 2;
                    var chih = (ch - ih) / 2;
                    if (chih > 0) {
                        // image too wide!
                        ImageLeft = 0;
                        ImageTop = chih;
                    }
                    else {
                        // image tpp narrow
                        ImageLeft = cwiw;
                        ImageTop = 0;
                    }
                    ImageWidth = iw;
                    ImageHeight = ih;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe) {
            // get the graphics object to use to draw
            Graphics g = pe.Graphics;

            var img = this.Image;
            if (img != null) {
                var rectDest = new Rectangle {
                    X = ImageLeft,
                    Y = ImageTop,
                    Width = ImageWidth,
                    Height = ImageHeight,
                };
                var rectSrc = new Rectangle {
                    X = 0,
                    Y = 0,
                    Width = img.Width,
                    Height = img.Height,
                };
                g.DrawImage(img, rectDest, rectSrc, GraphicsUnit.Pixel);
            }

            if (CropRect != null) {
                g.DrawRectangle(invalidPen, CropRect.X, CropRect.Y, CropRect.W, CropRect.H);
            }

            //g.DrawLine(invalidPen, 0, 0, Width, Height);
            //g.DrawLine(invalidPen, 0, Height, Width, 0);
        }
    }
}
