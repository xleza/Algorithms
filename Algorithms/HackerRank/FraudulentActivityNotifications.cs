namespace Algorithms.HackerRank
{
    public sealed class FraudulentActivityNotifications
    {
        public static int Execute(int[] expenditure, int d)
        {
            var frequencies = new int[201];

            for (var i = 0; i < d; i++)
                frequencies[expenditure[i]]++;

            var numberOfNotifications = 0;
            for (var i = d; i < expenditure.Length; i++)
            {
                var rangeFrom = i - d;
                var rangeTo = i - 1;

                var median = GetMedian(frequencies, rangeFrom, rangeTo);
                if (expenditure[i] >= median * 2)
                    numberOfNotifications++;

                frequencies[expenditure[rangeFrom]]--;
                frequencies[expenditure[i]]++;
            }

            return numberOfNotifications;
        }

        private static decimal GetMedian(int[] frequencies, int startIndex, int endIndex)
        {
            var elementsCount = endIndex - startIndex + 1;
            var middleElement = (elementsCount + 1) / 2;

            var sum = 0;
            var firstMedian = 0;
            for (var i = 0; i < frequencies.Length; i++)
            {
                sum += frequencies[i];
                if (sum >= middleElement)
                {
                    firstMedian = i;
                    break;
                }
            }

            var odd = elementsCount % 2 != 0;
            if (odd)
                return firstMedian;

            var secondMedian = 0;
            sum = 0;
            for (var i = 0; i < frequencies.Length; i++)
            {
                sum += frequencies[i];
                if (sum >= middleElement + 1)
                {
                    secondMedian = i;
                    break;
                }
            }

            return (firstMedian + secondMedian) / (decimal)2;
        }
    }
}
