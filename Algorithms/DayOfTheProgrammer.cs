using System;

namespace Algorithms
{
    public static class DayOfTheProgrammer
    {
        public static string Execute(int year)
        {
            var gregorian = year >= 1918;

            return gregorian ? CalculateByGregorian(year) : CalculateByJulian(year);
        }

        private static string CalculateByGregorian(int year)
        {
            var daysToAdd = year == 1918 ? -13 : 0;
            var isLeap = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
            if (isLeap)
                daysToAdd++;

            return GetFormattedDate(year, 9, 256 - 243 - daysToAdd);
        }

        private static string CalculateByJulian(int year)
        {
            var isLeap = year % 4 == 0;

            return GetFormattedDate(year, 9, 256 - 243 - (isLeap ? 1 : 0));
        }

        private static string GetFormattedDate(int year, int month, int day)
        {
            return $"{AddZeroIfRequired(day)}.{AddZeroIfRequired(month)}.{AddZeroIfRequired(year)}";
        }

        private static string AddZeroIfRequired(int x)
        {
            return x >= 10 ? x.ToString() : $"0{x}";
        }

        private static int GetDaysByMonth(int month, bool isLeap)
        {
            switch (month)
            {
                case 1:
                    return 31;
                case 2:
                    return isLeap ? 29 : 28;
                case 3:
                    return 31;
                case 4:
                    return 30;
                case 5:
                    return 31;
                case 6:
                    return 30;
                case 7:
                case 8:
                    return 31;
                case 9:
                    return 30;
                case 10:
                    return 31;
                default:
                    return 0;
            }
        }
    }
}
