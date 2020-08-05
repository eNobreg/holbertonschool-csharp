using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>
    /// A basic class containing various basic list operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the max value in a list
        /// </summary>
        /// <param name="nums">The list to find the max of</param>
        /// <returns>The max of the list</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null)
            {
                return (0);
            }
            if (nums.Count == 0)
            {
                return (0);
            }
            return (nums.Max());
        }
    }
}
