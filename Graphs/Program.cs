using System;
using Graphs.AdjacencyList;
using Graphs.Algorithms;

namespace Graphs
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			var myGraph = new Graph();
			myGraph.AddEdge("V0", "V3", 1);
			myGraph.AddEdge("V0", "V1", 2);
			myGraph.AddEdge("V1", "V4", 10);
			myGraph.AddEdge("V1", "V3", 3);
			myGraph.AddEdge("V2", "V5", 8);
			myGraph.AddEdge("V2", "V0", 4);
			myGraph.AddEdge("V3", "V4", 2);
			myGraph.AddEdge("V3", "V6", 4);
			myGraph.AddEdge("V3", "V5", 8);
			myGraph.AddEdge("V3", "V2", 2);
			myGraph.AddEdge("V4", "V6", 6);
			myGraph.AddEdge("V6", "V5", 1);		
			
			Console.WriteLine("Unweighted: ");
			Unweighted.Calculate(myGraph, "V1");
			Console.WriteLine(myGraph);

			Console.WriteLine();
			
			Console.WriteLine("Dijkstra: ");
			Dijkstra.Calculate(myGraph, "V1");
			Console.WriteLine(myGraph);
		}
	}
}