using System.Collections.Generic;

namespace Algorithms
{
    public static class PlaneSeatReservation
    {
        private static readonly Dictionary<char, int> LetterToNumberMapper =
            new Dictionary<char, int>
            {
            {'A',1},
            {'B',2},
            {'C',3},
            {'D',4},
            {'E',5},
            {'F',6},
            {'G',7},
            {'H',8},
            {'J',9},
            {'K',10},
        };

        public static int Execute(int rows, string reservedSeats)
        {
            var reservedRows = new Dictionary<int, HashSet<int>>();
            if (!string.IsNullOrWhiteSpace(reservedSeats))
            {
                foreach (var reservedSeat in reservedSeats.Split(" "))
                {
                    var row = int.Parse(reservedSeat[0].ToString());
                    var seat = LetterToNumberMapper[reservedSeat[reservedSeat.Length - 1]];
                    if (!reservedRows.ContainsKey(row))
                        reservedRows[row] = new HashSet<int>();

                    reservedRows[row].Add(seat);
                }
            }

            var groups = (rows - reservedRows.Count) * 2;

            foreach (var reservedRow in reservedRows)
            {
                var row = reservedRow.Key;
                var seats = reservedRow.Value;

                if (IsEmptyFrom(2, seats))
                {
                    groups++;
                    ReserveFrom(2, seats);
                }
                if (IsEmptyFrom(4, seats))
                {
                    groups++;
                    ReserveFrom(4, seats);
                }
                if (IsEmptyFrom(6, seats))
                {
                    groups++;
                    ReserveFrom(6, seats);
                }
            }

            return groups;
        }

        private static bool IsEmptyFrom(int start, HashSet<int> seats)
        {
            return !seats.Contains(start) && !seats.Contains(start + 1) && !seats.Contains(start + 2) && !seats.Contains(start + 3);
        }

        private static void ReserveFrom(int start, HashSet<int> seats)
        {
            seats.Add(start);
            seats.Add(start + 1);
            seats.Add(start + 2);
            seats.Add(start + 3);
        }
    }
}
