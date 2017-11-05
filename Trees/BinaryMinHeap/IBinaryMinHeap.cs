namespace Trees.BinaryMinHeap
{
	public interface IBinaryMinHeap
	{		
		void Insert(int value);

		int Value { get; }

		int Remove();

		void PercolateDown(int hole);
	}
}