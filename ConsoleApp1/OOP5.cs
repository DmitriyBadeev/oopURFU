using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OOP5
    {
        public static long SolveTask5()
        {
            const int WIDTH_GRID = 20;
            const int HEIGHT_GRID = 20;

            const int WIDTH_GRAPH = WIDTH_GRID + 1;
            const int HEIGHT_GRAPH = HEIGHT_GRID + 1;

            var graph = new Graph(WIDTH_GRAPH, HEIGHT_GRAPH);
            var resultCountPaths = graph.RightBottomCorner.CountPathsToThis;

            return resultCountPaths;
        }

    }

    class Graph
    {
        public Node[,] Nodes { get; }

        public Node RightBottomCorner { get; }

        public Graph(int width, int height)
        {
            Nodes = new Node[width, height];

            for (var i = 0; i < width; i++)
                for (var j = 0; j < height; j++)
                {
                    if (i == 0 && j == 0)
                        Nodes[0,0] = new Node(1);

                    if (i == 0 && j != 0)
                        Nodes[0,j] = new Node(1);

                    if (i != 0 && j == 0)
                        Nodes[i,0] = new Node(1);

                    if (i != 0 && j != 0)
                        Nodes[i,j] = new Node(Nodes[i - 1, j].CountPathsToThis + Nodes[i, j - 1].CountPathsToThis);
                }

            RightBottomCorner = Nodes[width - 1, height - 1];
        }
    }

    class Node
    {
        public long CountPathsToThis { get; }

        public Node(long countPaths)
        {
            CountPathsToThis = countPaths;
        }

        public override string ToString()
        {
            return CountPathsToThis.ToString();
        }
    }
}
