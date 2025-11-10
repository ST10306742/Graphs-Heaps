public class Program
{
    static void Main()
    {
        Graph g = new Graph();
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);

        g.PrintGraph();
    }
}

/*
    A Graph is a collection of:
    * Nodes (vertices) → points in the graph
    * Edges → connections between nodes

    Types of Graphs
    Undirected Graph  ->   Connections go both ways (A ↔ B)
    Directed Graph    ->   One-way connections (A → B)
    Weighted Graph    ->   Edges have costs (e.g., distances, times)
*/