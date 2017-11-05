namespace Trees.BinaryHeap
{
	public interface IBinaryHeap
	{		
		void Insert(int value);

		int Value { get; }

		int Remove();

		void PercolateDown(int hole);
	}
}