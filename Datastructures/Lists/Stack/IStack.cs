namespace Datastructures.Lists.Stack
{
	public interface IStack<T>
	{
		void Push(T data);

		T Pop();

		T Top();
	}
}