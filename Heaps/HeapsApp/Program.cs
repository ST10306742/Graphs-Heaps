using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Min-Heap using PriorityQueue (smaller number = higher priority)
        PriorityQueue<string, int> minHeap = new PriorityQueue<string, int>();

        minHeap.Enqueue("Apple", 5);
        minHeap.Enqueue("Banana", 2);
        minHeap.Enqueue("Cherry", 8);

        while (minHeap.Count > 0)
        {
            var item = minHeap.Dequeue();
            Console.WriteLine(item);
        }
    }
}

/*
    A Heap is a complete binary tree that follows a specific order:
    --> Min-Heap → Parent is smaller than its children.
    --> Max-Heap → Parent is larger than its children.

    https://chatgpt.com/share/69123f3a-7dd4-800b-b0ff-62e23b4d67d8
*/
