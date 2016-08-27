using System;
using System.Drawing;
using System.Text;

namespace ImageSampler
{
	public class PointTool : AbstractTool
	{

		public PointTool(IProgram p) : base(p) { }
		
		public override void OnMouseUp(int x, int y)
		{
			Color col = program.GetColorAt(x, y);

			var sb = new StringBuilder();
			sb.Append("r: " + col.R + Environment.NewLine);
			sb.Append("g: " + col.G + Environment.NewLine);
			sb.Append("b: " + col.B + Environment.NewLine);
			sb.Append("hex: " + col.ToHexString() + Environment.NewLine);

			program.SetText(sb.ToString());
		}
	}
}