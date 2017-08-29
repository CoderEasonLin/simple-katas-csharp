using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
    internal class WordCount
    {
        public static Dictionary<string, int> Count(string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
                return new Dictionary<string, int>();

            return phrase.Split(' ')
                    .GroupBy(token => token)
                    .ToDictionary(group => group.Key, group => group.Count());
        }
    }
}