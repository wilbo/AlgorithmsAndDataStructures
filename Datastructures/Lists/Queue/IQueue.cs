namespace Datastructures.Lists.Queue
{
	public interface IQueue<T>
	{
		void Enqueue(T data);

		T Dequeue();

		T Peek();
	}
}