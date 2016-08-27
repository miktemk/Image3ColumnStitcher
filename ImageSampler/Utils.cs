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
			return String.Format("{0,2:X2}{1,2:X2}{2,2:X2}", c.R, c.G, c.B);
		}
	}
}
