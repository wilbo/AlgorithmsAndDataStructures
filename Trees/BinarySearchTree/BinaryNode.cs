namespace Trees.BinarySearchTree
{
	public class BinaryNode
	{
		public int Value;
		public BinaryNode LeftChild;
		public BinaryNode RightChild;

		public BinaryNode(int value)
		{
			Value = value;
			LeftChild = null;
			RightChild = null;
		}

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}