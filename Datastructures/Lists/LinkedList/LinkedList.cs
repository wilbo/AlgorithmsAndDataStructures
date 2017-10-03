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
		
		public void Add(T data)
		{
			Count++;
			
			if (Start == null)
			{
				Start = new Node<T>(data);
				return;
			}
			
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

		public void AddFirst(T data)
		{
			Count++;
			
			if (Start == null)
			{
				Start = new Node<T>(data);
				return;
			}
			
			var node = new Node<T>(data, Start);
			node.Next = Start;
			Start = node;
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