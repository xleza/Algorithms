using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public sealed class DayOfWeekKDaysLater
    {
        public static string Execute(string s, int k)
        {
            var days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            var dayNumber = Array.IndexOf(days, s);
            return days[(dayNumber + k) % 7];
        }
    }
}
