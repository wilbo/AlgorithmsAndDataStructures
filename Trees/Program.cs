using System;
using Trees.BinarySearchTree;
using Trees.FCNSTree;
using Trees.BinaryTree;

namespace Trees
{
	internal class Program
	{
		public static void Main(string[] args)
		{			
			// First Child / Next Sibling Tree
			
			// Structure:
			//
			// 			A
			//		  / | \ \
			// 	  	 B	C  D E
			//	    / \	   | | \
			//	   F   G   H I	J
			//					|
			//					K
			//	
		
			var myFCNSTree = new FCNSTree<char>('A');
			myFCNSTree.Root.AddChild('B').AddChild('F').AddSibling('G');
			myFCNSTree.Root.AddChild('C');
			myFCNSTree.Root.AddChild('D').AddChild('H');
			myFCNSTree.Root.AddChild('E').AddChild('I').AddSibling('J').AddChild('K');
			myFCNSTree.PrintPreOrder(); // A B F G C D H E I J K
			Console.WriteLine(myFCNSTree.Root); // A
			Console.WriteLine(myFCNSTree.Root.FirstChild); // B
			Console.WriteLine(myFCNSTree.Root.FirstChild.NextSibling.NextSibling.FirstChild); // H
			
			
			// Binary Tree
			
			// Structure:
			//
			//		4
			//	   / \ 
			//	  2	  6
			//   / \
			//	1	3
			//

			var myBinaryTree = new BinaryTree<int>(4);
			myBinaryTree.Root.AddLeftChild(2);
			myBinaryTree.Root.AddRightChild(6);
			myBinaryTree.Root.LeftChild.AddLeftChild(1);
			myBinaryTree.Root.LeftChild.AddRightChild(3);
			
			myBinaryTree.PrintPreOrder(); 	// 4 2 1 3 6
			myBinaryTree.PrintInOrder(); 	// 1 2 3 4 6
			myBinaryTree.PrintPostOrder(); 	// 1 3 2 6 4

			Console.WriteLine("Size: " + myBinaryTree.Size);
			Console.WriteLine("Height: " + myBinaryTree.Height);
			
			var newTree = new BinaryTree<int>(4);
			newTree.Root.AddLeftChild(2);
			newTree.Root.AddRightChild(6);
			
			myBinaryTree.Merge(12, myBinaryTree, newTree);
			Console.WriteLine(myBinaryTree);
			
			
			// Binary Search Tree
			//
			// Structure:
			//
			//		6
			//	   / \ 
			//	  4	  7
			//   / \
			//	2	5
			//
			
			var myBinarySearchTree = new BinarySearchTree.BinarySearchTree(6);
			myBinarySearchTree.Insert(4);
			myBinarySearchTree.Insert(7);
			myBinarySearchTree.Insert(2);
			myBinarySearchTree.Insert(5);
			
			Console.WriteLine("InOrder: " + myBinarySearchTree.InOrder());

			Console.WriteLine("RemoveMin");
			myBinarySearchTree.Remove(2);

			Console.WriteLine("InOrder: " + myBinarySearchTree.InOrder());
			
			Console.WriteLine("FindMin: " + myBinarySearchTree.FindMin());
			Console.WriteLine("FindMax: " + myBinarySearchTree.FindMax());
			
			Console.WriteLine("PrettyPrint: " + myBinarySearchTree);
		}
	}
}