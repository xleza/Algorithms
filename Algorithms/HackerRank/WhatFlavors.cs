using System;
using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public sealed class WhatFlavors
    {
        public static void Execute(int[] cost, int money)
        {
            var costLookUp = new Dictionary<int, int>();
            foreach (var item in cost)
            {
                if (!costLookUp.ContainsKey(item))
                    costLookUp.Add(item, 0);
                costLookUp[item]++;
            }

            for (var i = 0; i < cost.Length; i++)
            {
                var firstCost = cost[i];
                var secondCost = money - cost[i];

                costLookUp[firstCost]--;

                if (!costLookUp.ContainsKey(secondCost) || costLookUp[secondCost] == 0)
                    continue;

                var firstFlavor = i + 1;
                var secondFlavor = -1;
                for (; i < cost.Length; i++)
                {
                    if (cost[i] == secondCost)
                        secondFlavor = i + 1;
                }

                Console.WriteLine(firstFlavor + " " + secondFlavor);
            }
        }
    }
}
