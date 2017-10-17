using System.Collections.Generic;

namespace Graphs.AdjacencyList
{
	public class Vertex : IVertex
	{
		public string Name;
		public LinkedList<Edge> Adjacent;
		
		public double Dist; // Cost of shortest path colculated by algorithm
		public Vertex Previous; // Previous vertex on shortest path
		public int Scratch; // Extra variable used in algorithm

		public Vertex(string name)
		{
			Name = name;
			Adjacent = new LinkedList<Edge>();
			Reset();
		}

		public void Reset()
		{
			Dist = double.MaxValue; 
			Previous = null;
			Scratch = 0;
		}
		
		public override string ToString()
		{
			var output = Name;

			if (Dist < double.MaxValue)
			{
				output += "(" + Dist + ")";
			}
			
			output += " --> ";

			foreach (var edge in Adjacent)
			{
				output += edge.Destination.Name + "(" + edge.Cost + ") ";
			}

			return output;
		}

	}
}