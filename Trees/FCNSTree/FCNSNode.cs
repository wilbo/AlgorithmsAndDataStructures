using System;

namespace Trees.FCNSTree
{
	public class FCNSNode<T>
	{
		public T Value;
		public FCNSNode<T> FirstChild;
		public FCNSNode<T> NextSibling;

		public FCNSNode(T value)
		{
			Value = value;
			FirstChild = null;
			NextSibling = null;
		}
		
		public FCNSNode<T> AddChild(T value)
		{
			if (FirstChild == null)
			{
				FirstChild = new FCNSNode<T>(value);
				return FirstChild;
			}
			else
			{
				return FirstChild.AddSibling(value);
			}
			
		}
		
		public FCNSNode<T> AddSibling(T value)
		{
			var current = this;

			while (current.NextSibling != null)
			{
				current = current.NextSibling;
			}
			
			current.NextSibling = new FCNSNode<T>(value);
			return current.NextSibling;
		}

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}