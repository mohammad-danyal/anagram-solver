using System;

namespace AnagramSolverAPI.Extensions
{
    public static class StringExtensions
    {
        public static string SortAlphabetically(this string str)
        {
            char[] ch2 = str.ToCharArray();

            Array.Sort(ch2);

            var val2 = new string(ch2);

            return val2;
        }
    }
}
