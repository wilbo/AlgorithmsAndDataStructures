using System;
using System.Collections.Generic;
using Graphs.AdjacencyList;
using Wintellect.PowerCollections;

namespace Graphs.Algorithms
{
	public static class Dijkstra
	{
		public static void Calculate(Graph graph, string name)
		{
			if (!graph.VertexMap.ContainsKey(name))
			{
				throw new KeyNotFoundException("Start vertex not found");
			}
			
			graph.ClearAll();
			
			var pq = new OrderedSet<Path>();
			var start = graph.VertexMap[name];
			var nodesSeen = 0;

			pq.Add(new Path(start, 0));
			start.Dist = 0;

			while (pq.Count > 0 && nodesSeen < graph.VertexMap.Count)
			{
				var vrec = pq.RemoveFirst();
				var v = vrec.Destination;
				
				if (v.Scratch != 0)
				{
					continue;
				}

				v.Scratch = 1;
				nodesSeen++;

				foreach (var edge in v.Adjacent)
				{
					var w = edge.Destination;
					var cvw = edge.Cost;

					if (cvw < 0)
					{
						throw new Exception("Graph has negative edges");	
					}

					if (w.Dist > v.Dist + cvw)
					{
						w.Dist = v.Dist + cvw;
						w.Previous = v;
						pq.Add(new Path(w, w.Dist));
					}
				}
			}
		}
	}

	internal class Path : IComparable<Path>
	{
		public Vertex Destination;
		public double Cost;
	
		public Path(Vertex destination, double cost)
		{
			Destination = destination;
			Cost = cost;
		}
	
		public int CompareTo(Path rhs)
		{
			var otherCost = rhs.Cost;
			return Cost < otherCost ? -1 : Cost > otherCost ? 1 : 0;
		}
	}
}