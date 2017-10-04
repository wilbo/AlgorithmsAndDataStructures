using System;
using System.Globalization;
using Datastructures.Lists.ArrayList;
using Datastructures.Lists.LinkedList;
using Datastructures.Lists.Queue;
using Datastructures.Lists.Stack;

namespace Datastructures
{
	internal class Program
	{
		private static void Main(string[] args)
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
			var myList = new LinkedList<int>();
			myList.AddFirst(4);
			myList.Clear();
			myList.AddFirst(7);
			myList.AddLast(19);
			myList.AddLast(55);
			myList.AddLast(3);
			myList.Insert(1, 222);
			myList.Insert(4, 889);
			myList.RemoveFirst();
			Console.WriteLine(myList + " count: " + myList.Count);
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