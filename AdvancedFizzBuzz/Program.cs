using SuperFizzBuzz;
using System;

namespace AdvancedFizzBuzz
{
	public class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the demo for advanced usage of SuperFizzBuzz library!");
			Console.WriteLine("=======================================================================");
			Console.WriteLine("Please enter a range of numbers for iterate\n");

			Console.WriteLine("Enter first number: ");
			int.TryParse(Console.ReadLine(), out int num1);

			Console.WriteLine("\nEnter the second number: ");
			int.TryParse(Console.ReadLine(), out int num2);

			SuperFizzBuzzFactory.AskForNumbersAndTokens();

			for (var i = num1; i < num2; i++)
			{
				var outPut = SuperFizzBuzzFactory.Output(i);
				Console.WriteLine(outPut);
			}

			Console.WriteLine("\n\nPress enter to quit...");
			Console.ReadLine();
		}
	}
}
