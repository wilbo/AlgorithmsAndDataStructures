using Datastructures.Lists.LinkedList;

namespace Datastructures.Lists.Stack
{
	public class Stack<T> : IStack<T>
	{
		private readonly LinkedList<T> _list;

		public Stack(T data)
		{
			_list = new LinkedList<T>(data);
		}

		public void Push(T data)
		{
			_list.AddFirst(data);
		}

		public T Pop()
		{
			var first = _list.GetFirst();
			_list.RemoveFirst();
			return first;
		}

		public T Top()
		{
			return _list.GetFirst();
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