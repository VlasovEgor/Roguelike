using System.Collections.Generic;
using System.Linq;
using UnityEngine;



public class Graph : MonoBehaviour
{
    public class NodeInfo
    {
        public Vector2Int Position;
        public List<Vector2Int> Dirs;

        public NodeInfo(Vector2Int pos, List<Vector2Int> dirs)
        {
            Position = pos;
            Dirs = dirs;
        }
    }

    public List<NodeInfo> Generate(int count)
    {
        var nodes = CreateGraph(count);
        var start = nodes.Keys.First();

        var visited = new HashSet<Vector2Int>();
        var queue = new Queue<Vector2Int>();

        queue.Enqueue(start);
        visited.Add(start);

        var result = new List<NodeInfo>();

        while(queue.Count!=0)
        {
            var node = queue.Dequeue();
            var dirs = new List<Vector2Int>();

            foreach (var item in nodes[node])
            {
                if(!visited.Contains(item))
                {
                    queue.Enqueue(item);
                    visited.Add(item);
                }

                dirs.Add(item - node);
            }

            result.Add(new NodeInfo(node, dirs));
        }


        return result;
    }


    private Dictionary<Vector2Int, HashSet<Vector2Int>> CreateGraph(int count)
    {
        var node1 = new Vector2Int(0, 0);

        var nodes = new Dictionary<Vector2Int, HashSet<Vector2Int>>();
        nodes.Add(node1, new HashSet<Vector2Int>());

        var dxdy = new Vector2Int[]
        {
            new Vector2Int(0,1),
            new Vector2Int(1,0),
            new Vector2Int(0,-1),
            new Vector2Int(-1,0)
        };

        var probs = new Vector2Int[]
       {
            new Vector2Int(0,25),
            new Vector2Int(25,50),
            new Vector2Int(50,75),
            new Vector2Int(75,100)
       };

        for (int i = 0; i < count - 1; i++)
        {
            bool next = false;

            while (!next)
            {
                var node2 = node1 + dxdy[GetIndexProb(probs)];

                if (!nodes.ContainsKey(node2))
                {
                    next = true;

                    nodes.Add(node2, new HashSet<Vector2Int>());
                }
               
                nodes[node1].Add(node2);
                nodes[node2].Add(node1);

                node1 = node2;
            }

           
        }
        return nodes;
    }

    private int GetIndexProb(Vector2Int[] probs)
    {
        int value = Random.Range(0, 101);
        for (int i = 0; i < probs.Length; i++)
        {
            if(value >= probs[i].x && value< probs[i].y)
            {
                return i;
            }
        }
        return 0;
    }
}