using System;
using Lists.ArrayList;
using Lists.LinkedList;
using Lists.Queue;
using Lists.Stack;

namespace Lists
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("ArrayList:");
			var myArrayList = new ArrayList<int>(10);
			myArrayList.Add(1);
			myArrayList.Add(2);
			myArrayList.Clear();
			myArrayList.Add(1);
			myArrayList.Add(2);
			myArrayList.Add(8);
			myArrayList.Add(2);
			myArrayList.Add(7);
			myArrayList.Add(432);
			Console.WriteLine("Occurences of 2 = " + myArrayList.CountOccurences(2));
			Console.WriteLine(myArrayList);
			Console.WriteLine("--------------------------------------------------------------");

			Console.WriteLine("");
			Console.WriteLine("LinkedList:");
			var myLinkedList = new LinkedList<int>();
			myLinkedList.AddFirst(4);
			myLinkedList.Clear();
			myLinkedList.AddFirst(7);
			myLinkedList.AddLast(19);
			myLinkedList.AddLast(55);
			myLinkedList.AddLast(3);
			myLinkedList.Insert(1, 222);
			myLinkedList.Insert(4, 889);
			myLinkedList.RemoveFirst();
			Console.WriteLine("Last value: " + myLinkedList.Last);
			Console.WriteLine("Count: " + myLinkedList.Count);
			Console.WriteLine(myLinkedList);
			Console.WriteLine("--------------------------------------------------------------");
			
			Console.WriteLine("");
			Console.WriteLine("Stack:");
			var myStack = new Stack<int>();
			myStack.Push(2);
			myStack.Push(3);
			myStack.Pop();
			myStack.Push(3);
			myStack.Push(34);
			myStack.Push(10);
			Console.WriteLine("Top of the stack: " + myStack.Top());
			Console.WriteLine(myStack);
			Console.WriteLine("--------------------------------------------------------------");	
			
			Console.WriteLine("");
			Console.WriteLine("Queue:");
			var myQueue = new Queue<int>();
			myQueue.Enqueue(4);
			myQueue.Enqueue(8);
			myQueue.Enqueue(3);
			myQueue.Enqueue(11);
			Console.WriteLine("Queued: 4, 8, 3, 11");
			Console.WriteLine("Dequeued: " + myQueue.Dequeue());
			Console.WriteLine("Dequeued: " + myQueue.Dequeue());
			Console.WriteLine(myQueue);
			Console.WriteLine("--------------------------------------------------------------");
		}
	}
}