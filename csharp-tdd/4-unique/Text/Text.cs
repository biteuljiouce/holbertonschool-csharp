using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Manipulates string.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// returns the index of the first non-repeating character of a string.
        /// </summary>
        /// <param name="s">string to analyze.</param>
        /// <returns>index of the 1st non repeating char.</returns>
        public static int UniqueChar(string s)
        {
            if (s == null)
            {
                return -1;
            }

            if (s.Length == 1)
            {
                return 0;
            }

            for (var i = 0; i < s.Length; i++)
            {
                // If current character does not appear elsewhere in string
                if (s.Substring(i + 1).Contains(s[i].ToString()) == false &&
                    s.Substring(0, i).Contains(s[i].ToString()) == false)
                {
                    return i;
                }
            }
            return -1;

        }
    }
}