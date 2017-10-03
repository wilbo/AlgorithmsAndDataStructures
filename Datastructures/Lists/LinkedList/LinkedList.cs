using System;

namespace Datastructures.Lists.LinkedList
{
	public class LinkedList<T> : ILinkedList<T>
	{
		public Node<T> Start { get; private set; }
		public int Count;
		
		public LinkedList()
		{
			Start = null;
			Count = 0;
		}
		
		public LinkedList(T data)
		{
			Start = new Node<T>(data);
			Count = 1;
		}
		
		public void AddLast(T data)
		{
			if (Start == null)
			{
				Start = new Node<T>(data);
			}
			else
			{
				var current = Start;
	
				while (current != null)
				{
					if (current.Next == null)
					{
						current.Next = new Node<T>(data);
						break;
					}
	
					current = current.Next;
				}
			}
			
			Count++;
		}

		public void AddFirst(T data)
		{
			if (Start == null)
			{
				Start = new Node<T>(data);
			}
			else
			{
				var node = new Node<T>(data, Start);
				node.Next = Start;
				Start = node;	
			}
			
			Count++;			
		}

		public void Clear()
		{
			Start = null;
			Count = 0;
		}

		public void Insert(int index, T data)
		{
			if (index > Count)
			{
				throw new IndexOutOfRangeException();
			}
			
			var node = new Node<T>(data);
			var current = Start;
			var cycle = 1;

			while (current != null)
			{
				if (cycle == index)
				{
					node.Next = current.Next;
					current.Next = node;
					Count++;
					break;
				}

				current = current.Next;
				cycle++;
			}
		}

		public T RemoveFirst()
		{
			var removed = Start;
			Start = Start.Next;
			
			Count--;
			
			return removed.Value;
		}

		public T RemoveLast()
		{
			var current = Start;
			var node = new Node<T>();

			while (current != null)
			{
				if (current.Next == null)
				{
					node = current;
					current = null;
					Count--;
					break;
				}
				
				current = current.Next;
			}

			return node.Value;
		}

		public T GetFirst()
		{
			return Start.Value;
		}

		public override string ToString()
		{
			var output = "";
			var node = Start;

			while (node != null)
			{
				output += node + " -> ";
				node = node.Next;
			}

			return output += "null";
		}
	}
}