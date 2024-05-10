using System;
using System.Collections.Generic;

namespace MyMath
{

    /// <summary>
    /// Math operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        ///  returns the max integer in a list of integers.
        /// </summary>
        /// <param name="nums">list of integer</param>
        /// <returns>max of the list</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return 0;
            int max = nums[0];
            foreach (int i in nums)
            {
                if (i >= max)
                {
                    max = i;
                }
            }
            return max;
        }
    }
}