using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
    internal class WordCount
    {
        public static Dictionary<string, int> Count(string phrase)
        {
            var result = new Dictionary<string, int>();
            if (string.IsNullOrEmpty(phrase))
                return result;

            return phrase.Split(' ').GroupBy(token => token).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}