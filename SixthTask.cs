using System;

namespace SixthTask
{
	class Program
	{
		static void Main(string[] args)
		{
			int allImages = 52;
			int inRowImages = 3;

			int filledRows = allImages / inRowImages;
			int extraImages = allImages % inRowImages;

			Console.WriteLine($"Всего рядов: {filledRows}, лишних: {extraImages}");
		}
	}
}
