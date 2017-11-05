using System;
using System.Collections.Generic;

namespace BigOExamples
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Big-O Examples:");
		}

		// Source: https://rob-bell.net/2009/06/a-beginners-guide-to-big-o-notation/
		// Wikipedia: https://en.wikipedia.org/wiki/Big_O_notation
		// Logarithms: https://en.wikipedia.org/wiki/Logarithm


		// O(1) or O(C)
		// Describes an algorithm that will always execute in the same time (or space) regardless of the size of the 
		// input data set.

		private static bool IsFirstElementNull(List<string>[] elements)
		{
			return elements[0] == null;
		}


		// O(N)
		// Describes an algorithm whose performance will grow linearly and in direct proportion to the size of the
		// input data set. 

		private static bool ContainsValue(List<string> elements, string value)
		{
			foreach (var element in elements)
				if (element == value) return true;

			return false;
		}


		// O(N^2)
		// Describes an algorithm whose performance is directly proportional to the square of the size of the input
		// data set. Deeper nested iterations will result in O(N3), O(N4) etc.

		private static bool ContainsDuplicates(List<string> elements)
		{
			for (var outer = 0; outer < elements.Count; outer++)
			{
				for (var inner = 0; inner < elements.Count; inner++)
				{
					// Don't compare with self
					if (outer == inner) continue;
					
					if (elements[outer] == elements[inner]) return true;
				}		
			}

			return false;
		}
	
		
		// O(2^N)
		// Describes an algorithm whose growth doubles with each additon to the input data set. 

		private static int Fibonacci(int number)
		{
			if (number <= 1) return number;

			return Fibonacci(number - 2) + Fibonacci(number - 1);
		}


		// O(log N)
		// As we double i every iteration, it bassically halves the dataset that will produce a growth curve that peaks
		// at the beginning and slowly flattens out as the size of the data sets increase.

		private static int TotalOi(int n)
		{
			int output;

			for (var i = 1; i < n; i = i * 2) // <----- i = i * 2
				output += i;

			return output;
		}

		// O(N log N)
		// ....

		private static void OnLogN()
		{
			throw new NotImplementedException();
		}
	}
}