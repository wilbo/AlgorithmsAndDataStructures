using System;

namespace Sorting
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var numbers = new[] {23, 42, 4, 16, 8, 15, 64, 34};

			Console.WriteLine("InsertionSort:");
			PrintNumbers(InsertionSort.Sort(numbers));
		}

		private static void PrintNumbers(int[] numbers)
		{
			var output = "";

			foreach (var t in numbers)
			{
				output += " " + t;
			}
			
			Console.WriteLine(output);
		}
	}
}