namespace Algorithms.HackerRank
{
    public static class CountingValleys
    {
        public static int Execute(int n, string s)
        {
            var valleysCont = 0;
            var currentAltitude = 0;
            foreach (var item in s)
            {
                var previousAltitude = currentAltitude;
                currentAltitude += item == 'U' ? 1 : -1;
                if (previousAltitude == 0 && currentAltitude == -1)
                    valleysCont++;
            }
            return valleysCont;
        }
    }
}
