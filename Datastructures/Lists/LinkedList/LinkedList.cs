using System;

namespace Datastructures.Lists.LinkedList
{
	public class LinkedList<T> : ILinkedList<T>
	{
		private Node<T> _start;
		public int Count { get; private set;}
		
		public LinkedList()
		{
			_start = null;
			Count = 0;
		}

		public T First => _start.Value;

		public T Last
		{
			get
			{
				var current = _start;
				var last = new Node<T>();
				
				while (current != null)
				{
					if (current.Next == null)
					{
						last = current;
						break;
					}

					current = current.Next;
				}
				
				return last.Value;
			}
		}
		
		public void AddFirst(T data)
		{
			if (_start == null)
			{
				_start = new Node<T>(data);
			}
			else
			{
				var node = new Node<T>(data, _start);
				node.Next = _start;
				_start = node;
			}

			Count++;
		}

		public void AddLast(T data)
		{
			if (_start == null)
			{
				_start = new Node<T>(data);
			}
			else
			{
				var current = _start;

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

		public void Clear()
		{
			_start = null;
			Count = 0;
		}

		public void Insert(int index, T data)
		{
			if (index > Count)
			{
				throw new IndexOutOfRangeException();
			}

			var node = new Node<T>(data);
			var current = _start;
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

		public void RemoveFirst()
		{
			_start = _start.Next;
			Count--;
		}

		public override string ToString()
		{
			var output = "";
			var node = _start;

			while (node != null)
			{
				output += node + " | ";
				node = node.Next;
			}

			return output;
		}
	}
}