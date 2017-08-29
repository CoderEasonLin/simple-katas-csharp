using System.Collections.Generic;
using System.Linq;

namespace StringAverage
{
    internal class StringAverage
    {
        public static string Avg(string stringOfNumbers)
        {
            if (string.IsNullOrEmpty(stringOfNumbers))
                return "n/a";

            var numberMapping = new Dictionary<string, int>
            {
                {"one", 1},
                {"two", 2}
            };

            var numberTokens = stringOfNumbers.Split(' ');
            var avg = numberTokens.Select(t => numberMapping[t]).Sum()/numberTokens.Length;
            return numberMapping.First(pair => pair.Value == avg).Key;
        }
    }
}