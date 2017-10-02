using System;
using Datastructures.ArrayList;
using Datastructures.LinkedList;
using Datastructures.Stack;

namespace Datastructures
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ArrayList:");
			
			var myArrayList = new ArrayList<int>(10);
			myArrayList.Add(1);
			myArrayList.Add(5);
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
			
			var myList = new LinkedList<int>(1);
			myList.AddFirst(4);
			myList.AddFirst(7);
			myList.AddFirst(19);
			myList.Insert(1, 222);
			myList.Insert(4, 889);
			myList.RemoveFirst();

			Console.WriteLine(myList);
			Console.WriteLine("--------------------------------------------------------------");
			
			Console.WriteLine("");
			Console.WriteLine("Stack:");
			
			var myStack = new Stack<int>(1);
			myStack.Push(2);
			myStack.Push(3);
			myStack.Pop();
			myStack.Push(3);
			myStack.Push(34);
			myStack.Push(10);

			Console.WriteLine("Top of the stack: " + myStack.Top());
			Console.WriteLine(myStack);
			Console.WriteLine("--------------------------------------------------------------");	
			
		}
	}
}