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
		
		public void Enqueue(T data)
		{
			_list.AddLast(data);
		}

		public T Dequeue()
		{
			var first = _list.First;
			_list.RemoveFirst();
			return first;
		}

		public T Peek()
		{
			return _list.First;
		}
		
		public override string ToString()
		{
			return _list.ToString();
		}
	}
}