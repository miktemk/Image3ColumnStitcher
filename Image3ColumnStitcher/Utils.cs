using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageSampler
{
	public static class Utils
	{
		public static string ToHexString(this Color c)
		{
			return String.Format("{0,2:X}{1,2:X}{2,2:X}", c.R, c.G, c.B);
		}
        public static Rectangle ChangeRatio(this Rectangle rect, int frameW, int frameH) {
            if (rect.Width == 0 || rect.Height == 0)
                return rect;
            //var cw = Math.Min(rect.Width, frameW * rect.Height / rect.Width);
            //var ch = Math.Min(rect.Height, frameH * rect.Width / rect.Height);
            var cw = Math.Min(rect.Width, frameW * rect.Height / frameH);
            var ch = Math.Min(rect.Height, frameH * rect.Width / frameW);
            if (cw < rect.Width) {
                // too wide
                return new Rectangle {
                    X = rect.X + (rect.Width-cw)/2,
                    Y = rect.Y,
                    Width = cw,
                    Height = rect.Height,
                };
            }
            else {
                // too narrow
                return new Rectangle {
                    X = rect.X,
                    Y = rect.Y + (rect.Height-ch)/2,
                    Width = rect.Width,
                    Height = ch,
                };
            }
        }
	}
}
