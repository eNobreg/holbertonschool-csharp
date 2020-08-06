using System;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            Dictionary<char, int> newDict = new Dictionary<char, int>();
            int i = 0;

            if (s == null)
                return (-1);

            foreach (char c in s) 
            {
                if (!newDict.ContainsKey(c))
                {
                    newDict.Add(c, 1);
                }
                else
                {
                    newDict[c] += 1;
                }
            }

            foreach (char letter in s)
            {
                if (newDict[letter] == 1)
                {
                    return (i);
                }
                i += 1;
            }
            return (-1);
        }
    }
}
