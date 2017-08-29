using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
    class WordCount
    {
        public static Dictionary<string, int> Count(string phrase)
        {
            var result = new Dictionary<string, int>();
            if (string.IsNullOrEmpty(phrase))
                return result;

            var tokens = phrase.Split(' ');
            foreach (var token in tokens)
            {
                if (result.ContainsKey(token))
                    continue;
                result[token] = tokens.Count(t => t == token);
            }
            return result;
        }
    }
}
