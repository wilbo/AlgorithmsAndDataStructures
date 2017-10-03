using System;

namespace Datastructures.Lists.ArrayList
{
	public class ArrayList<T> : IArrayList<T>
	{
		private readonly int _allocationSize;
		private T[] _array;
		public int Count;

		public ArrayList()
		{
			_allocationSize = 10;
			_array = new T[_allocationSize];
		}

		public ArrayList(int allocationSize)
		{
			_allocationSize = allocationSize;
			_array = new T[allocationSize];
		}

		public void Add(T data)
		{
			if (Count > _array.Length) throw new IndexOutOfRangeException();

			_array[Count] = data;
			Count++;
		}

		public T Get(int index)
		{
			if (index > Count - 1) throw new IndexOutOfRangeException();

			return _array[index];
		}

		public void Set(int index, T data)
		{
			if (index > Count - 1) throw new IndexOutOfRangeException();

			_array[index] = data;
		}

		public void Clear()
		{
			_array = new T[_allocationSize];
			Count = 0;
		}

		// Extra bonus method!
		public int CountOccurences(T data)
		{
			var result = 0;

			for (var i = 0; i < Count; i++)
				if (_array[i].Equals(data)) result++;

			return result;
		}

		public override string ToString()
		{
			var result = "[";

			for (var i = 0; i < Count; i++)
				if (i == 0) result += _array[i];
				else result += ", " + _array[i];

			return result + "] Count: " + Count;
		}
	}
}