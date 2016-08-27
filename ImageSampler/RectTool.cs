using System;
using System.Drawing;
using System.Text;

namespace ImageSampler
{
	public class RectTool : AbstractTool
	{
		public RectTool(IProgram p) : base(p) { }

		private int x0, y0;
		public override void OnMouseDown(int x, int y)
		{
			x0 = x;
			y0 = y;
		}
		public override void OnMouseDrag(int x, int y)
		{
			program.SetText("rect " + Math.Abs(x - x0) + " x " + Math.Abs(y - y0));
		}
		public override void OnMouseUp(int x, int y)
		{
			int x1 = Math.Min(x, x0);
			int y1 = Math.Min(y, y0);
			int w = Math.Abs(x - x0);
			int h = Math.Abs(y - y0);
			if (w == 0)
				w = 1;
			if (h == 0)
				h = 1;

			int totR = 0;
			int totG = 0;
			int totB = 0;

			for (int yy = 0; yy < h; yy++)
			{
				for (int xx = 0; xx < w; xx++)
				{
					Color col = program.GetColorAt(x1 + xx, y1 + yy);
					totR += col.R;
					totG += col.G;
					totB += col.B;
				}
			}

			totR /= h * w;
			totG /= h * w;
			totB /= h * w;
			Color colAvg = Color.FromArgb(0, totR, totG, totB);

			var sb = new StringBuilder();
			sb.Append("average:" + Environment.NewLine);
			sb.Append("r: " + totR + Environment.NewLine);
			sb.Append("g: " + totG + Environment.NewLine);
			sb.Append("b: " + totB + Environment.NewLine);
			sb.Append("hex: " + colAvg.ToHexString() + Environment.NewLine);

			program.SetText(sb.ToString());
		}
	}
}