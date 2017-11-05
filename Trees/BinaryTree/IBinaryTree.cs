namespace Trees.BinaryTree
{
	public interface IBinaryTree<T>
	{
		BinaryNode<T> Root { get; }
		
		int Size { get; }
		
		int Height { get; }
		
		bool IsEmpty { get; }
		
		void PrintPreOrder();
		
		void PrintInOrder();
		
		void PrintPostOrder();

		void MakeEmpty();

		void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2);
	}
}