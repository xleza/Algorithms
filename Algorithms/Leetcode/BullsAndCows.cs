using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public static class BullsAndCows
    {
        public static string Execute(string secret, string guess)
        {
            var numberLookUp = new Dictionary<int, int>();
            foreach (var item in secret)
            {
                if (!numberLookUp.ContainsKey(item))
                    numberLookUp.Add(item, 0);

                numberLookUp[item]++;
            }

            var cows = 0;
            var bulls = 0;

            for (var i = 0; i < secret.Length; i++)
            {
                if (secret[i] != guess[i])
                    continue;

                bulls++;

                numberLookUp[guess[i]]--;
            }

            for (var i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                    continue;

                if (!numberLookUp.ContainsKey(guess[i]) || numberLookUp[guess[i]] <= 0)
                    continue;

                cows++;

                numberLookUp[guess[i]]--;
            }

            return $"{bulls}A{cows}B";
        }
    }
}
