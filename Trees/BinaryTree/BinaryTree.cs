using System;

namespace Trees.BinaryTree
{
	public class BinaryTree<T> : IBinaryTree<T>
	{
		public BinaryNode<T> Root { get; private set; }

		public BinaryTree(T value)
		{
			Root = new BinaryNode<T>(value);
		}
		
		public int Size => Root.Size(Root);
		public int Height => Root.Height(Root);
		public bool IsEmpty => Root == null;

		public void PrintPreOrder()
		{
			Console.Write("PreOrder: ");
			PreOrderHelper(Root);
			Console.WriteLine();
		}

		public void PrintInOrder()
		{
			Console.Write("InOrder: ");
			InOrderHelper(Root);
			Console.WriteLine();
		}

		public void PrintPostOrder()
		{
			Console.Write("PostOrder: ");
			PostOrderHelper(Root);
			Console.WriteLine();
		}

		public void MakeEmpty()
		{
			Root = null;
		}

		public void Merge(T rootValue, BinaryTree<T> tree1, BinaryTree<T> tree2)
		{
			if (tree1.Root == tree2.Root && tree1.Root != null)
			{
				throw new ArgumentException();
			}
			
			// Allocate new Root
			Root = new BinaryNode<T>(rootValue, tree1.Root, tree2.Root);

			// Ensure that every node is in one tree
			if (this != tree1)
				tree1.Root = null;

			if (this != tree2)
				tree2.Root = null;	
		}

		public override string ToString()
		{
			return Traverse(Root);
		}
		
		private string Traverse(BinaryNode<T> node)
		{
			if (node == null)
			{
				return "null";
			}

			return "[ " + Traverse(node.LeftChild) + " " + node.Value + " " + Traverse(node.RightChild) + " ]";
		}

		private void PreOrderHelper(BinaryNode<T> node)
		{
			Console.Write(node);
			if (node.LeftChild != null)
				PreOrderHelper(node.LeftChild);
			if (node.RightChild != null)
				PreOrderHelper(node.RightChild);
		}

		private void InOrderHelper(BinaryNode<T> node)
		{
			if (node.LeftChild != null)
				InOrderHelper(node.LeftChild);
			Console.Write(node);
			if (node.RightChild != null)
				InOrderHelper(node.RightChild);
		}

		private void PostOrderHelper(BinaryNode<T> node)
		{
			if (node.LeftChild != null)
				PostOrderHelper(node.LeftChild);
			if (node.RightChild != null)
				PostOrderHelper(node.RightChild);
			Console.Write(node);
		}
	}
}