using System;

namespace SuperFizzBuzz
{
	[Serializable]
	public class InvalidRangeOfNumbersException : Exception
	{

		public InvalidRangeOfNumbersException()
		{
			
		}

		public InvalidRangeOfNumbersException(int num1, int num2) 
			: base($"El número {num1} debe ser mayor a {num2}")
		{
			
		}
	}
}
