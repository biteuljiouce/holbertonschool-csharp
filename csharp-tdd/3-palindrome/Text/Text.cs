using System;
using System.Collections.Generic;

namespace Text
{

    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            s = string.Join("", s.Split(new char[] { ' ', '.', ':', ',', ';', '!', '?', })).ToLower();
            char[] revArray = s.ToCharArray();
            Array.Reverse(revArray);
            string reversed = new string(revArray);

            return reversed == s;
        }
    }
}