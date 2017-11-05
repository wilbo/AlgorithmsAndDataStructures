using System;

namespace Trees.BinarySearchTree
{
	public class BinarySearchTree : IBinarySearchTree
	{
		public BinaryNode Root;

		public BinarySearchTree(int rootValue)
		{
			Root = new BinaryNode(rootValue);
		}

		public void Insert(int value)
		{
			Insert(value, Root);
		}

		private BinaryNode Insert(int value, BinaryNode node)
		{
			if (node == null)
			{
				node = new BinaryNode(value);
			}
			else if (value < node.Value)
			{
				node.LeftChild = Insert(value, node.LeftChild);
			}
			else if (value > node.Value)
			{
				node.RightChild = Insert(value, node.RightChild);
			}
			else
			{
				throw new Exception("Value already inside Tree.");
			}

			return node;
		}
		
		public int Find(int value)
		{
			return Find(value, Root).Value;
		}
		
		private BinaryNode Find(int value, BinaryNode node)
		{
			while( node != null )
			{
				if (value < node.Value)
				{
					node = node.LeftChild;
				}
				else if (value > node.Value)
				{
					node = node.RightChild;
				}
				else
				{
					return node;
				}
			}
			
			return null;
		}

		public int FindMin()
		{
			return FindMin(Root).Value;
		}
		
		private BinaryNode FindMin(BinaryNode node)
		{
			while (node.LeftChild != null)
			{
				node = node.LeftChild;
			}

			return node;
		}

		public int FindMax()
		{
			return FindMax(Root).Value;
		}

		private BinaryNode FindMax(BinaryNode node)
		{
			while (node.RightChild != null)
			{
				node = node.RightChild;
			}

			return node;
		}
		
		public void Remove(int value)
		{
			Remove(value, Root);
		}

		private BinaryNode Remove(int value, BinaryNode node)
		{
			if (node == null)
			{
				throw new Exception("Value not found");
			}

			if (value < node.Value)
			{
				node.LeftChild = Remove(value, node.LeftChild);
			}
			else if (value > node.Value)
			{
				node.RightChild = Remove(value, node.RightChild);
			}
			else if (node.LeftChild != null && node.RightChild != null)
			{
				node.Value = FindMin(node.RightChild).Value;
				node.RightChild = RemoveMin(node.RightChild);
			}
			else
			{
				node = node.LeftChild ?? node.RightChild;
			}

			return node;
		}
		
		public void RemoveMin()
		{
			RemoveMin(Root);
		}

		private BinaryNode RemoveMin(BinaryNode node)
		{
			if (node == null)
			{
				throw new Exception("Value not found");
			} 
			
			if (node.LeftChild != null)
			{
				node.LeftChild = RemoveMin(node.LeftChild);
				return node;
			}
			
			return node.RightChild;
			
		}

		public string InOrder()
		{
			return SimpleTraverse(Root);
		}
		
		private string SimpleTraverse(BinaryNode current)
		{
			return current == null ? "" : SimpleTraverse(current.LeftChild) + " " + current.Value + " " + SimpleTraverse(current.RightChild);
		}
		
		public override string ToString()
		{
			return Root == null ? "Root is null" : PrettyTraverse(Root);
		}
		
		private string PrettyTraverse(BinaryNode current)
		{
			if (current == null)
			{
				return "null";
			}

			var output = "";

			output += current.Value != Root.Value ? "[ " : "";
			output += PrettyTraverse(current.LeftChild) + " " + current.Value + " " + PrettyTraverse(current.RightChild);
			output += current.Value != Root.Value ? " ]" : "";
			
			return output;
		}
		
		
	}
}