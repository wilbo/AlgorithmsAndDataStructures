namespace Datastructures.LinkedList
{
	public interface ILinkedList<T>
	{
		void AddFirst(T data);
		
		void Clear();
		
		void Insert(int index, T data);
		
		void RemoveFirst();
		
		T GetFirst();
	}
}