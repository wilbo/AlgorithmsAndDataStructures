using System;

namespace Trees.FCNSTree
{
	public class FCNSTree<T> : IFCNSTree<T>
	{
		public FCNSNode<T> Root;
		public int Size => SizeRecursive(Root);

		public FCNSTree(T value)
		{
			Root = new FCNSNode<T>(value);
		}

		public void PrintPreOrder()
		{
			PreOrderTravers(Root);
			Console.WriteLine();
		}
		
		private int SizeRecursive(FCNSNode<T> node)
		{
			if (node == null)
			{
				return 0;
			}

			return 1 + SizeRecursive(node.FirstChild) + SizeRecursive(node.NextSibling);
		}

		private void PreOrderTravers(FCNSNode<T> node)
		{
			if (node == null)
			{
				return;
			}

			Console.Write(node.Value + " ");
			PreOrderTravers(node.FirstChild);
			PreOrderTravers(node.NextSibling);
		}
	}
}