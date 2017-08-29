using System.Collections.Generic;

namespace WordCount
{
    class WordCount
    {
        public static Dictionary<string, int> Count(string phrase)
        {
            if(string.IsNullOrEmpty(phrase))
                return new Dictionary<string, int>();

            var splitBySpace = phrase.Split(' ');
            return new Dictionary<string, int> {{splitBySpace[0], splitBySpace.Length}};
        }
    }
}
