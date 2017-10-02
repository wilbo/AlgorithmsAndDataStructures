namespace Datastructures.Stack
{
	public interface IStack<T>
	{
		void Push(T data);
		
		T Pop();
		
		T Top();
	}
}