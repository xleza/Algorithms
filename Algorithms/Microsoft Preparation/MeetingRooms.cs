using System;
using System.Linq;

namespace Algorithms
{
    public static class MeetingRooms
    {
        public static int Execute(int[][] intervals)
        {
            if (intervals.Length == 0)
                return 0;
            var sortedIntervals = intervals.OrderBy(x => x[0]).ToList();
            var busyRooms = new Heap<int[]>(x => x.parent[1] <= x.child[1]);
            var maxBusyRoomsCount = 1;
            foreach (var interval in sortedIntervals)
            {
                if (busyRooms.Count == 0)
                {
                    busyRooms.Insert(interval);
                    continue;
                }

                var earliestRoomToFree = busyRooms.Peek();
                if (earliestRoomToFree[1] <= interval[0])
                    busyRooms.Remove();

                busyRooms.Insert(interval);
                maxBusyRoomsCount = Math.Max(maxBusyRoomsCount, busyRooms.Count);
            }

            return maxBusyRoomsCount;
        }
    }
}
