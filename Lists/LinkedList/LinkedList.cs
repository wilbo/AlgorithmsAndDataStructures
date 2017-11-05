using System;

namespace Lists.LinkedList
{
	public class LinkedList<T> : ILinkedList<T>
	{
		private Node<T> _header;

		public LinkedList()
		{
			Clear();
		}
		
		public int Count
		{
			get
			{
				var current = _header.Next;
				var count = 0;
				
				while (current != null)
				{
					count++;	
					current = current.Next;
				}

				return count;
			}
		}

		public T First
		{
			get
			{
				if (_header.Next == null) throw new NullReferenceException();
				return _header.Next.Value;		
			}
		}

		public T Last
		{
			get
			{
				var current = _header;
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
			var node = new Node<T>(data);
			node.Next = _header.Next;
			_header.Next = node;
		}

		public void AddLast(T data)
		{
			var current = _header;

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

		public void Clear()
		{
			_header = new Node<T>();
		}

		public void Insert(int index, T data)
		{
			if (index > Count)
			{
				throw new IndexOutOfRangeException();
			}

			var node = new Node<T>(data);
			var current = _header.Next;
			var cycle = 1;

			while (current != null)
			{
				if (cycle == index)
				{
					node.Next = current.Next;
					current.Next = node;
					break;
				}

				current = current.Next;
				cycle++;
			}
		}

		public void RemoveFirst()
		{
			if (_header.Next == null)
			{
				throw new NullReferenceException();
			}

			var temp = _header.Next.Next;
			_header.Next = temp;
		}

		public override string ToString()
		{
			var output = "";
			var node = _header.Next;

			while (node != null)
			{
				output += node + ", ";
				node = node.Next;
			}
			
			return output;
		}
	}
}