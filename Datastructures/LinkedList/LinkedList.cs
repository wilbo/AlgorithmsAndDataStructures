namespace Datastructures.LinkedList
{
	public class LinkedList<T> : ILinkedList<T>
	{
		public Node<T> Start { get; private set; }

		public LinkedList(T data)
		{
			Start = new Node<T>(data);
		}

		public void AddFirst(T data)
		{
			var node = new Node<T>(data, Start);
			Start = node;
		}

		public void Clear()
		{
			Start = null;
		}

		public void Insert(int index, T data)
		{
			var node = new Node<T>(data);
			var current = Start;
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
			Start = Start.Next;
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