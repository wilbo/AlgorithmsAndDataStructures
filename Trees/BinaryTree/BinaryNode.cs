using System;

namespace Trees.BinaryTree
{
	public class BinaryNode<T>
	{
		public T Value;
		public BinaryNode<T> LeftChild;
		public BinaryNode<T> RightChild;


		public BinaryNode(T value)
		{
			Value = value;
			LeftChild = null;
			RightChild = null;
		}

		public BinaryNode(T value, BinaryNode<T> leftChild, BinaryNode<T> rightChild)
		{
			Value = value;
			LeftChild = leftChild;
			RightChild = rightChild;
		}
		
		public BinaryNode<T> AddLeftChild(T value)
		{
			LeftChild = new BinaryNode<T>(value);
			return LeftChild;
		}
		
		public BinaryNode<T> AddRightChild(T value)
		{
			RightChild = new BinaryNode<T>(value);
			return RightChild;
		}

		public int Size(BinaryNode<T> node)
		{
			if (node == null)
			{
				return 0;
			}
			
			return 1 + Size(node.LeftChild) + Size(node.RightChild);
		}
		
		public int Height(BinaryNode<T> node)
		{
			if (node == null)
			{
				return -1;
			}
			
			return 1 + Math.Max(Height(node.LeftChild), Height(node.RightChild));
		}

		public override string ToString()
		{
			return Value.ToString() + " ";
		}
	}
}