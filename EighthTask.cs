using System;

namespace EighthTask
{
	class Program
	{
		static void Main(string[] args)
		{
			int timeOfReceptionInMinutes = 10;
			int minutesInHour = 60;

			Console.WriteLine("Введите количество людей в очереди: ");
			int countOfPeopleInLine = Convert.ToInt32(Console.ReadLine());

			int waitingHours = (countOfPeopleInLine * timeOfReceptionInMinutes) / minutesInHour;
			int waitingMinutes = (countOfPeopleInLine * timeOfReceptionInMinutes) % minutesInHour;

			Console.WriteLine($"В очереди {waitingHours} часа {waitingMinutes} минут.");
		}
	}
}
