using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class BalancedBrackets
    {
        public static string Execute(string s)
        {
            var bracketsPairs = new Dictionary<char, char>{
                {'(' , ')'},
                {'{' , '}'},
                {'[' , ']'}
            };
            var openBrackets = new Stack<char>();
            foreach (var item in s)
            {
                if (bracketsPairs.ContainsKey(item))
                    openBrackets.Push(item);
                else
                {
                    if (openBrackets.Count == 0)
                        return "NO";
                    var openBracket = openBrackets.Pop();
                    if (bracketsPairs[openBracket] != item)
                        return "NO";
                }
            }
            return openBrackets.Count == 0 ? "YES" : "NO";
        }
    }
}
