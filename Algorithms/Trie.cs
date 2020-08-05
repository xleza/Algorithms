using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public sealed class Trie
    {
        private readonly Node _root;

        public Trie()
        {
            _root = new Node();
        }
        public void Insert(string word)
        {
            var currentNode = _root;
            foreach (var letter in word)
            {
                if (!currentNode.Children.ContainsKey(letter))
                    currentNode.Children.Add(letter, new Node());

                currentNode.IsCompleteWord = false;
                currentNode = currentNode.Children[letter];
            }
        }

        public bool Search(string word)
        {
            var currentNode = _root;
            foreach (var letter in word)
            {
                if (!currentNode.Children.ContainsKey(letter))
                    return false;

                currentNode = currentNode.Children[letter];
            }

            return currentNode.IsCompleteWord;
        }

        public bool StartsWith(string prefix)
        {
            var currentNode = _root;
            foreach (var letter in prefix)
            {
                if (!currentNode.Children.ContainsKey(letter))
                    return false;

                currentNode = currentNode.Children[letter];
            }

            return true;
        }


        private sealed class Node
        {
            public Dictionary<char, Node> Children { get; set; }
            public bool IsCompleteWord { get; set; }

            public Node()
            {
                Children = new Dictionary<char, Node>();
                IsCompleteWord = false;
            }
        }
    }
}
