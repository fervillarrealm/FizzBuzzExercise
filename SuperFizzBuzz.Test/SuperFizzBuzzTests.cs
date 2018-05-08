using NUnit.Framework;

namespace SuperFizzBuzz.Test
{
	[TestFixture]
	public class SuperFizzBuzzTests
	{
		[Test]
		public void Returns_Fizz_If_Divisible_By_3()
		{
			SuperFizzBuzzFactory.NumberAndTokenDictionary.Clear();
			SuperFizzBuzzFactory.NumberAndTokenDictionary.Add(3, "Fizz");

			Assert.That(SuperFizzBuzzFactory.Output(3), Is.EqualTo("Fizz"));
			Assert.That(SuperFizzBuzzFactory.Output(6), Is.EqualTo("Fizz"));
			Assert.That(SuperFizzBuzzFactory.Output(9), Is.EqualTo("Fizz"));
		}

		[Test]
		public void Returns_Buzz_If_Divisible_By_5()
		{
			SuperFizzBuzzFactory.NumberAndTokenDictionary.Clear();
			SuperFizzBuzzFactory.NumberAndTokenDictionary.Add(5, "Buzz");
			
			Assert.That(SuperFizzBuzzFactory.Output(5), Is.EqualTo("Buzz"));
			Assert.That(SuperFizzBuzzFactory.Output(10), Is.EqualTo("Buzz"));
			Assert.That(SuperFizzBuzzFactory.Output(20), Is.EqualTo("Buzz"));
		}

		[Test]
		public void Returns_Buzz_If_Divisible_By_3_And_5()
		{
			SuperFizzBuzzFactory.NumberAndTokenDictionary.Clear();
			SuperFizzBuzzFactory.NumberAndTokenDictionary.Add(3, "Fizz");
			SuperFizzBuzzFactory.NumberAndTokenDictionary.Add(5, "Buzz");

			Assert.That(SuperFizzBuzzFactory.Output(15), Is.EqualTo("FizzBuzz"));
			Assert.That(SuperFizzBuzzFactory.Output(30), Is.EqualTo("FizzBuzz"));
			Assert.That(SuperFizzBuzzFactory.Output(45), Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void Returns_Number_If_Not_Divisible_By_3_Or_5()
		{
			SuperFizzBuzzFactory.NumberAndTokenDictionary.Clear();
			SuperFizzBuzzFactory.NumberAndTokenDictionary.Add(3, "Fizz");
			SuperFizzBuzzFactory.NumberAndTokenDictionary.Add(5, "Buzz");

			Assert.That(SuperFizzBuzzFactory.Output(1), Is.EqualTo("1"));
			Assert.That(SuperFizzBuzzFactory.Output(22), Is.EqualTo("22"));
			Assert.That(SuperFizzBuzzFactory.Output(187), Is.EqualTo("187"));
		}
	}
}
