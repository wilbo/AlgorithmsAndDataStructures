namespace Trees.BinarySearchTree
{
	public interface IBinarySearchTree
	{		
		void Insert(int value);
		
		void Remove(int value);
		
		void RemoveMin();

		int Find(int value);
		
		int FindMin();

		int FindMax();
		
		string InOrder();
		
		string ToString();
		
	}
}