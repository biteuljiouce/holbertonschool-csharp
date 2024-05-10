using System;
using System.Collections.Generic;

namespace Text
{

    public class Str
    {
        public static int UniqueChar(string s)
        {
            int index = -1;
            char c = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (c == s[i])
                {
                    index = i - 1;
                    break;
                }
                else
                {
                    c = s[i];
                }
            }
            return index;
        }
    }
}