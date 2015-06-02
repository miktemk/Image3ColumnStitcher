namespace MyShittyControls
{
	internal class HandTool : AbstractTool
	{
		public HandTool(IProgram p) : base(p) { }

		private int x0, y0;

		public override void OnMouseDown(int x, int y)
		{
			x0 = x;
			y0 = y;
		}
		public override void OnMouseDrag(int x, int y)
		{
			//program.TempImageTranslate(x - x0, y - y0);
		}
		public override void OnMouseUp(int x, int y)
		{
			//program.FinaliseImageTranslate(x - x0, y - y0);
		}
	}
}