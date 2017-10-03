namespace Datastructures.Lists.DoublyLinkedList
{
	public class Node<T>
	{
		public Node<T> Next;
		public Node<T> Prev;
		public T Value;
		
		public Node() { }

		public Node(T value)
		{
			Value = value;
		}

		public Node(T value, Node<T> next, Node<T> prev)
		{
			Value = value;
			Next = next;
			Prev = prev;
		}

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}