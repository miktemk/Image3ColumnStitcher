using System;
using System.Drawing;
using System.Text;

namespace MyShittyControls
{
	public class RectTool : AbstractTool
	{
        private CropSpec cropSpec;
        public RectTool(IProgram p, CropSpec cropSpec)
            : base(p)
        {
            this.cropSpec = cropSpec;
        }

		private int x0, y0;
		public override void OnMouseDown(int x, int y)
		{
			x0 = x;
			y0 = y;
            cropSpec.CropRect.SetWithCoord(x, y, x, y);
		}
		public override void OnMouseDrag(int x, int y)
		{
            cropSpec.CropRect.SetWithCoord(x0, y0, x, y);
			program.SetText("rect " + Math.Abs(x - x0) + " x " + Math.Abs(y - y0));
		}
		public override void OnMouseUp(int x, int y)
		{
            cropSpec.CropRect.SetWithCoord(x0, y0, x, y);
            program.SetText(cropSpec.CropRect.ToString());
		}
	}
}