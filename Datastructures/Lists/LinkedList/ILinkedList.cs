namespace Datastructures.Lists.LinkedList
{
	public interface ILinkedList<T>
	{
		void AddFirst(T data);

		void Clear();

		void Insert(int index, T data);

		T RemoveFirst();

		T GetFirst();
	}
}