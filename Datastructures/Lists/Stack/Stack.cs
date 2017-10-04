using Datastructures.Lists.LinkedList;

namespace Datastructures.Lists.Stack
{
	public class Stack<T> : IStack<T>
	{
		private readonly LinkedList<T> _list;

		public Stack()
		{
			_list = new LinkedList<T>();
		}

		public void Push(T data)
		{
			_list.AddFirst(data);
		}

		public T Pop()
		{
			var first = _list.First;
			_list.RemoveFirst();
			return first;
		}

		public T Top()
		{
			return _list.First;
		}

		public override string ToString()
		{
			return _list.ToString();
		}
	}
}