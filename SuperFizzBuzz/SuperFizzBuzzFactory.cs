using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SuperFizzBuzz
{
	public static class SuperFizzBuzzFactory
	{
		public static Dictionary<int, string> NumberAndTokenDictionary = new Dictionary<int, string>();

		/// <summary>
		/// return token or string if specified number is multiple by
		/// </summary>
		/// <param name="number">integer to evaluate division by</param>
		/// <returns>string or given token</returns>
		public static string Output(int number)
	    {
		    var result = NumberAndTokenDictionary.Where(numbers => number % numbers.Key == 0).Aggregate("", (current, numbers) => current + numbers.Value);

		    return result == "" ? number.ToString() : result;
	    }

		/// <summary>
		/// Start of application 
		/// ask for first pair of number and token, then ask if want to add more
		/// </summary>
		public static void AskForNumbersAndTokens()
		{
			do
			{
				AddNumberAndTokenToDictionary();
			} while (WantToAddAnotherNumberAndToken());

			ShowCountDown();
		}


		public static void AddBasicConfiguration()
		{
			NumberAndTokenDictionary.Add(3, "Fizz");
			NumberAndTokenDictionary.Add(5, "Buzz");
			ShowCountDown();
		}

		#region Private Methods

		private static bool WantToAddAnotherNumberAndToken()
		{
			ConsoleKey response;
			do
			{
				Console.Write("\nDo you want to add another number and token? [y/n] ");
				response = Console.ReadKey(false).Key;
				if (response != ConsoleKey.Enter)
					Console.WriteLine();

			} while (response != ConsoleKey.Y && response != ConsoleKey.N);

			return response == ConsoleKey.Y;
		}

		private static void AddNumberAndTokenToDictionary()
		{
			Console.WriteLine("\nAdd a number to evaluate division by: ");
			int.TryParse(Console.ReadLine(), out int number);

			Console.WriteLine("\nAdd a token for that number: ");
			var token = Console.ReadLine();

			NumberAndTokenDictionary.Add(number, token);
		}

		private static void ShowCountDown()
		{
			for (var a = 3; a >= 0; a--)
			{
				Console.Write("Generating result in {0}", a);
				Thread.Sleep(1000);
			}
		} 

		#endregion
	}
}
