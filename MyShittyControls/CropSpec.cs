using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyShittyControls {
    
    public class CropSpec {
        public Image Image { get; set; }
        public MyRect CropRect { get; set; }
        public string Filename { get; set; }

        public CropSpec() {
            CropRect = new MyRect();
        }

        public void setImage(Image img, string filename) {
            Image = img;
            Filename = filename;
        }
    }

    public class MyRect {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        public void SetWithCoord(int x1, int y1, int x2, int y2) {
            X = Math.Min(x1, x2);
            Y = Math.Min(y1, y2);
            W = Math.Abs(x1 - x2) + 1; ///// +1???
            H = Math.Abs(y1 - y2) + 1;
        }

        public override string ToString() {
            return String.Format("Rect({0},{1},{2},{3})", X, Y, W, H);
        }
    }
}
