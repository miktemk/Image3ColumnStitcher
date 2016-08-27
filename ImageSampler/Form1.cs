using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageSampler
{
	public partial class Form1 : Form, IProgram
	{
		private AbstractTool curTool;
		private AbstractTool toolHand, toolPoint, toolRect;
		private Bitmap curImage;

		public Form1()
		{
			InitializeComponent();
			
			// toiollzzzzzzz
			toolHand = new HandTool(this);
			toolPoint = new PointTool(this);
			toolRect = new RectTool(this);
			
			// default tool
			btnPoint.Checked = true;
			curTool = toolPoint;

			// toiollzzzzzzz
			toolHand = new HandTool(this);
			toolPoint = new PointTool(this);
			toolRect = new RectTool(this);

			// drag drop
			pictureBox.AllowDrop = true;
			pictureBox.DragEnter += pictureBox_DragEnter;
			pictureBox.DragDrop += pictureBox_DragDrop;
			// mouse events
			pictureBox.MouseDown += pictureBox_MouseDown;
			pictureBox.MouseUp += pictureBox_MouseUp;
			pictureBox.MouseMove += pictureBox_MouseMove;
			//pictureBox.S
		}

		#region pictureBox

		private bool isMouseDown = false;
		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			isMouseDown = true;
			if (curTool == null)
				return;
			curTool.OnMouseDown(e.X, e.Y);
		}
		private void pictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			isMouseDown = false;
			if (curTool == null)
				return;
			curTool.OnMouseUp(e.X, e.Y);
		}
		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (curTool == null)
				return;
			if (isMouseDown)
				curTool.OnMouseDrag(e.X, e.Y);
		}

		private void pictureBox_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
			{
				e.Effect = DragDropEffects.All;
			}
		}  
		private void pictureBox_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			var file = files.FirstOrDefault();
			if (file == null)
				return;
			curImage = new Bitmap(Image.FromFile(file));
			pictureBox.Image = curImage;
		}
		#endregion

		#region buttons
		private void btnHand_CheckedChanged(object sender, EventArgs e)
		{
			if (btnHand.Checked)
				curTool = toolHand;
		}
		private void btnPoint_CheckedChanged(object sender, EventArgs e)
		{
			if (btnPoint.Checked)
				curTool = toolPoint;
		}
		private void btnRect_CheckedChanged(object sender, EventArgs e)
		{
			if (btnRect.Checked)
				curTool = toolRect;
		}
		#endregion

		#region iProgram members

		private int imgX, imgY;
		public void TempImageTranslate(int x, int y)
		{
			SetText((imgX + x) + " : " + (imgY + y));
		}

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void FinaliseImageTranslate(int x, int y)
		{
			imgX += x;
			imgY += y;
			SetText("finalized" + imgX + " : " + imgY);
		}
		public Color GetColorAt(int x, int y)
		{
			if (curImage == null)
				return Color.Empty;
			if (x >= curImage.Width)
				return Color.Empty;
			if (y >= curImage.Height)
				return Color.Empty;

			return curImage.GetPixel(x, y);
		}
		public void SetText(string s)
		{
			txtBox.Text = s;
		}

		#endregion
	}
}
