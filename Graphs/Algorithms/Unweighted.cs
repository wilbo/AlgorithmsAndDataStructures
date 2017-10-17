using System;
using System.Collections.Generic;

namespace Graphs.AdjacencyList
{
	public static class Unweighted
	{
		public static void Calculate(Graph graph, string name)
		{
			graph.ClearAll();

			if (!graph.VertexMap.ContainsKey(name))
			{
				throw new KeyNotFoundException("Start vertex not found");
			}
			
			var start = graph.VertexMap[name];
			var que = new Queue<Vertex>();
			
			que.Enqueue(start);
			start.Dist = 0;

			while (que.Count > 0)
			{
				var v = que.Dequeue();

				foreach (var edge in v.Adjacent)
				{
					var w = edge.Destination;

					if (Math.Abs(w.Dist - double.MaxValue) <= 0)
					{
						w.Dist = v.Dist + 1;
						w.Previous = v;
						que.Enqueue(w);
					}
				}
			}
		}
	}
}