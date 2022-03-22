using System;

namespace FourthTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Как Вас зовут?");
			string name = Console.ReadLine();
			Console.WriteLine("Сколько Вам лет?");
			string age = Console.ReadLine();

			Console.WriteLine($"Вас зовут {name}. Вам {age} лет.");
		}
	}
}
