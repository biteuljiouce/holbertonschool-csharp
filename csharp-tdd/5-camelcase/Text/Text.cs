using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// analyses string.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts words in camel case string.
        /// </summary>
        /// <remarks>
        /// Each word begins with a capital letter except the first word.
        /// </remarks>
        /// <param name="s">string in camelCase format</param>
        /// <returns>nb of words.</returns>
        public static int CamelCase(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            // validate string, 1st char must be lowcase
            char c = s[0];
            if (!Char.IsLower(c))
            {
                Console.WriteLine("Invalid string : 1st char must be lower case");
                return 0;
            }
            // 1st char is low case, we have at least one word
            int nbOfWord = 1;
            // now we just count how many Upper case letter we have.
            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    nbOfWord++;
                }
            }
            return nbOfWord;
        }
    }
}