using System;

namespace Sorting
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = new int[] {23, 42, 4, 16, 8, 15};

			Console.WriteLine("InsertionSort:");
			PrintNumbers(InsertionSort.Sort(numbers));

		}

		public static void PrintNumbers(int[] numbers)
		{
			var output = "";

			for (var i = 0; i < numbers.Length; i++)
			{
				output += " " + numbers[i];
			}

			Console.WriteLine(output);
		}
	}
}