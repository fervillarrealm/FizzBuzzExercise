using SuperFizzBuzz;
using System;

namespace BasicFizzBuzz
{
	public class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the demo for basic usage of SuperFizzBuzz library!");
			Console.WriteLine("=======================================================================");
			//	Adding default values
			SuperFizzBuzzFactory.AddBasicConfiguration();
			
			for (var i = 1; i < 100; i++)
			{
				var outPut = SuperFizzBuzzFactory.Output(i);
				Console.WriteLine(outPut);
			}

			Console.WriteLine("Press enter to quit...");
			Console.ReadLine();
		}
	}
}
