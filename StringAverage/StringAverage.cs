using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace StringAverage
{
    internal class StringAverage
    {
        private static readonly Dictionary<string, int> NumberMapping = new Dictionary<string, int>
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9}
        };

        public static string Avg(string numberString)
        {
            if (string.IsNullOrEmpty(numberString))
                return "n/a";

            var numberStrings = numberString.Split(' ');
            if (!numberStrings.All(t => NumberMapping.ContainsKey(t)))
                return "n/a";

            return ToString(Avg(numberStrings));
        }

        private static int Avg(string[] numberStrings)
        {
            return numberStrings
                       .Select(t => NumberMapping[t])
                       .Sum() / numberStrings.Length;
        }

        private static string ToString(int avg)
        {
            return NumberMapping.First(pair => pair.Value == avg).Key;
        }
    }
}