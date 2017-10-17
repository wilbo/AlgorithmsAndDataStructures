using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Xsl.Runtime;
using Wintellect.PowerCollections;

namespace Graphs.AdjacencyList
{
	public class Graph : IGraph
	{
		public Dictionary<string, Vertex> VertexMap { get; }

		public Graph()
		{
			VertexMap = new Dictionary<string, Vertex>();;
		}

		public Vertex GetVertex(string name)
		{			
			if (VertexMap.ContainsKey(name))
			{
				return VertexMap[name];
			}
	
			var vertex = new Vertex(name);
			VertexMap.Add(name, vertex);
			return vertex;
		}

		public void AddEdge(string source, string dest, double cost)
		{
			var from = GetVertex(source);
			var to = GetVertex(dest);
			from.Adjacent.AddFirst(new Edge(to, cost));
		}

		public void ClearAll()
		{
			foreach (var vertex in VertexMap.Values)
			{
				vertex.Reset();
			}
		}
		
		public override string ToString()
		{
			var output = "";
			
			foreach (var vertex in VertexMap.Values)
			{
				output += vertex + "\n";
			}

			return output;
		}
	}
}