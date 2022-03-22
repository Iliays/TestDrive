using System;

namespace SeventhTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите количество золота: ");
			int gold = Convert.ToInt32(Console.ReadLine());

			int crystalPrice = 5;

			Console.WriteLine("Сколько кристалов хотите купить? ");
			int countCrystalToBuy = Convert.ToInt32(Console.ReadLine());

			gold -= countCrystalToBuy * crystalPrice;

			Console.WriteLine($"Оставшееся золото: {gold}, кристаллы: {countCrystalToBuy}");
		}
	}
}
