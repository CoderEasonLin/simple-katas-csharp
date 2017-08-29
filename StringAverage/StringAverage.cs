using System;

namespace StringAverage
{
    internal class StringAverage
    {
        public static string Avg(string stringOfNumbers)
        {
            if(string.IsNullOrEmpty(stringOfNumbers))
                return "n/a";

            return stringOfNumbers;
        }
    }
}