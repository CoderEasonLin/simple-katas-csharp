using System.Collections.Generic;

namespace WordCount
{
    class WordCount
    {
        public static Dictionary<string, int> Count(string phrase)
        {
            if(string.IsNullOrEmpty(phrase))
                return new Dictionary<string, int>();

            return new Dictionary<string, int> {{phrase.Split(' ')[0], phrase.Split(' ').Length}};
        }
    }
}
