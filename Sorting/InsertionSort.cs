namespace Sorting
{
	public static class InsertionSort
	{
		
		// Reference: https://en.wikipedia.org/wiki/Insertion_sort
		
		public static int[] Sort(int[] list)
		{
			// Start from index 1 because index 0 is considered sorted 
			for (var i = 1; i < list.Length; i++)
			{
				// The value 'n' to be lowered in the list
				var n = list[i];

				// Number before 'n' in list is greater than 'n'
				while (i - 1 >= 0 && list[i - 1] > n)
				{
					// Lift the larger number up
					list[i] = list[i - 1];

					// Reiterate lower in the list (if while statement complies)
					i--;
				}

				// put 'n' on its sorted position
				list[i] = n;
			}

			return list;
		}
	}
}