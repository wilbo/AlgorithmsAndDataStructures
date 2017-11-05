namespace Trees.BinaryMinHeap
{
	public class BinaryMinMinHeap : IBinaryMinHeap
	{
		private readonly int[] _array;
		public int CurrentSize;

		public BinaryMinMinHeap()
		{
			_array = new int[33];
			CurrentSize = 0;
		}

		public int Value => _array[1];

		public void Insert(int value)
		{
			var hole = ++CurrentSize;
			_array[0] = value;
			
			while (value < hole)
			{
				_array[hole] = _array[hole / 2];
				hole /= 2;
			}

			_array[hole] = value;
		}

		public int FindMin()
		{
			throw new System.NotImplementedException();
		}

		public int Remove()
		{
			var value = Value;
			
			_array[1] = _array[CurrentSize--];
			PercolateDown(1);
			
			return value;
		}

		public void PercolateDown(int hole)
		{
			var temp = _array[hole];

			while (hole * 2 <= CurrentSize)
			{
				var child = hole * 2;

				if (child != CurrentSize && _array[child + 1] < _array[child])
				{
					child++;
				}

				if (_array[child] < temp)
				{
					_array[hole] = _array[child];
				}
				else
				{
					break;
				}
				
				hole = child;
			}

			_array[hole] = temp;
		}

		public override string ToString()
		{
			var output = "";

			for (var i = 1; i < CurrentSize + 1; i++)
			{
				output += _array[i];
				output += i == CurrentSize ? "" : ", ";
			}

			return output;
		}
	}
}