using System;
using System.Collections.Generic;

class Graph
{
    Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

    public void AddEdge(int v, int w)
    {
        if (!adjList.ContainsKey(v))
            adjList[v] = new List<int>();
        adjList[v].Add(w);
    }

    public void PrintGraph()
    {
        foreach (var vertex in adjList)
        {
            Console.Write(vertex.Key + " -> ");
            Console.WriteLine(string.Join(", ", vertex.Value));
        }
    }
}

