namespace Datastructures.Lists.LinkedList
{
	public interface ILinkedList<T>
	{
		T First { get; }

		T Last { get; }
		
		void AddFirst(T data);
		
		void AddLast(T data);

		void Clear();

		void Insert(int index, T data);

		void RemoveFirst();
	}
}