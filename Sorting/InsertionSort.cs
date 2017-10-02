namespace Sorting
{
	public static class InsertionSort
	{
		public static int[] Sort(int[] numbers)
		{			
			for (var i = 0; i < numbers.Length - 1; i++) {
				for (var j = i + 1; j > 0; j--) {
					if (numbers[j] >= numbers[j - 1])
					{
						break;
					}

					Swap(numbers, j, j - 1);
				}
			}
			
			return numbers;
		}

		private static void Swap(int[] array, int i, int j)
		{
			var temp = array[i];
			array[i] = array[j];
			array[j] = temp;
		}
	}
}