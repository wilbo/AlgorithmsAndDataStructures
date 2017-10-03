namespace Datastructures.Lists.ArrayList
{
	public interface IArrayList<T>
	{
		void Add(T data);

		T Get(int index);

		void Set(int index, T data);

		void Clear();

		int CountOccurences(T data);
	}
}