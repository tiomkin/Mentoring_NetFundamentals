using System;
using System.Linq;
using ClassLibrary;

namespace Task1_NetCoreConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter your name: ");
			var name = Console.ReadLine();

			while (string.IsNullOrEmpty(name) || name.Any(char.IsDigit))
			{
				Console.WriteLine("Sorry...But I just asked to enter the name..");
				Console.Write("Please enter your name: ");
				name = Console.ReadLine();
			}

			var currentTime = Time.GetCurrentTime();
			Console.WriteLine($"{currentTime} Hello, {name}!");
		}
	}
}
