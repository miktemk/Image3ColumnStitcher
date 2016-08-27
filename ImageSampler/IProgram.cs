using System.Drawing;

namespace ImageSampler
{
	public interface IProgram
	{
		void TempImageTranslate(int x, int y);
		void FinaliseImageTranslate(int x, int y);
		Color GetColorAt(int x, int y);
		void SetText(string s);
	}
}