namespace Algorithms
{
    public static class Extensions
    {
        public static string ToBinary(this int self)
        {
            var result = "";

            while (self > 0)
            {
                var even = self % 2 == 0;

                result = even ? "0" + result : "1" + result;
                self /= 2;
            }

            return result;
        }
    }
}
