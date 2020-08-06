using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Class for basic string operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if a string is a palindrome
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>True/False depending on if the string is a palindrome</returns>
        public static bool IsPalindrome(string s)
        {
            string reversed;
            var newstr = String.Join("", s.Where(char.IsLetterOrDigit));

            char[] characters = newstr.ToCharArray();

            Array.Reverse(characters);
            reversed = new string(characters);

            bool result = newstr.Equals(reversed, StringComparison.OrdinalIgnoreCase);
            if (result == true)
                return (true);
            else
                return (false);
        }
    }
}
