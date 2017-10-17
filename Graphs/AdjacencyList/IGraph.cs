namespace Graphs.AdjacencyList
{
	public interface IGraph
	{
		Vertex GetVertex(string name);
		
		void AddEdge(string source, string dest, double cost);
		
		string ToString();
	}
}