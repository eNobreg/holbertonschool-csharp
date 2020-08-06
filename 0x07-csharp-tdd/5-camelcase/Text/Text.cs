using System;

namespace Text
{
    /// <summary>
    /// String class containing basic operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Detects the # of words in a string based on capital letters
        /// </summary>
        /// <param name="s">String to check</param>
        /// <returns>Word count, or 0</returns>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0 )
                return (0);

            int word_count = 1;

            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                    word_count += 1;
            }
            if (char.IsUpper(s[0]))
                word_count -= 1;
            return (word_count);
        }
    }
}
