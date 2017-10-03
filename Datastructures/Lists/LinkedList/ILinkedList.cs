namespace Datastructures.Lists.LinkedList
{
	public interface ILinkedList<T>
	{
		void AddFirst(T data);
		
		void AddLast(T data);

		void Clear();

		void Insert(int index, T data);

		T RemoveFirst();
		
		T RemoveLast();

		T GetFirst();
	}
}