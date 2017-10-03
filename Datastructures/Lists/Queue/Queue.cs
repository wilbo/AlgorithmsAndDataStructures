using Datastructures.Lists.LinkedList;

namespace Datastructures.Lists.Queue
{
	public class Queue<T> : IQueue<T>
	{
		private readonly LinkedList<T> _list;
		
		public Queue()
		{
			_list = new LinkedList<T>();
		}

		public Queue(T data)
		{
			_list = new LinkedList<T>(data);
		}
		
		public void Enqueue(T data)
		{
			_list.Add(data);
		}

		public T Dequeue()
		{
			return _list.RemoveFirst();
		}

		public T Peek()
		{
			return _list.Start.Value;
		}
		
		public override string ToString()
		{
			var output = "";
			var current = _list.Start;

			while (current != null)
			{
				output += current + " | ";
				current = current.Next;
			}

			return output;
		}
	}
}