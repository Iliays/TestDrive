using System;

namespace FifthTask
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = "Mercury";
			string surname = "Freddie";
			string template;

			Console.WriteLine($"My name is {name}. My surname is {surname}");

			template = name;
			name = surname;
			surname = template;

			Console.WriteLine($"My name is {name}. My surname is {surname}");
		}
	}
}
