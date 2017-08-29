using System;
using System.Collections.Generic;
using System.Linq;

namespace StringAverage
{
    internal class StringAverage
    {
        private static readonly Dictionary<string, int> NumberMapping = new Dictionary<string, int>
        {
            {"one", 1},
            {"two", 2}
        };

        public static string Avg(string stringOfNumbers)
        {
            if (string.IsNullOrEmpty(stringOfNumbers))
                return "n/a";

            var numbers = stringOfNumbers.Split(' ').Select(t => NumberMapping[t]);
            return NumberMapping.First(pair => pair.Value == numbers.Sum()/numbers.Count()).Key;
        }
    }
}