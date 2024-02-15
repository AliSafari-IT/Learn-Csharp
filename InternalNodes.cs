using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class InternalNodes
    {
        public static int Count(params int[] tree)
        {
            if (tree == null || tree.Length == 0)
                return 0;

            // Create a dictionary to keep track of child count for each node
            var childCount = new Dictionary<int, int>();

            foreach (int parent in tree)
            {
                if (parent != -1)
                {
                    if (!childCount.ContainsKey(parent))
                        childCount[parent] = 0;

                    childCount[parent]++;
                }
            }

            // Internal nodes are those present in the childCount dictionary
            return childCount.Count;
        }

        public static void Main1(string[] args)
        {
            Console.WriteLine(InternalNodes.Count(1, 3, 1, -1, 3));
        }
    }
}
