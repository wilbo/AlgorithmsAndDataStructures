namespace Datastructures.Lists.LinkedList
{
	public class Node<T>
	{
		public Node<T> Next;
		public T Value;

		public Node(T value)
		{
			Value = value;
		}

		public Node(T value, Node<T> next)
		{
			Value = value;
			Next = next;
		}

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}