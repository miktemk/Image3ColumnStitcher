using System;
using System.Collections.Generic;
using System.Linq;

namespace ImageSampler
{
	public class AbstractTool
	{
		protected IProgram program;
		public AbstractTool(IProgram program)
		{
			this.program = program;
		}

		public virtual void OnMouseDown(int x, int y) { }
		public virtual void OnMouseDrag(int x, int y) { }
		public virtual void OnMouseUp(int x, int y) { }
	}
}
