using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class HuffmanDecoding
    {
        public class Node
        {

            public char Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }


        public static string Execute(string s, Node root)
        {
            var nodes = new Stack<Node>();
            nodes.Push(root);

            var result = "";
            for (var i = 0; i < s.Length; i++)
            {
                var node = nodes.Pop();
                var nextNode = s[i] == '1' ? node.Right : node.Left;
                if (nextNode.Left == null && nextNode.Right == null)
                {
                    result += nextNode.Data;
                    nodes.Push(root);
                }
                else
                {
                    nodes.Push(nextNode);
                }
            }

            return result;
        }

    }
}
