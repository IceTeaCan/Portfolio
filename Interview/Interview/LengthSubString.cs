using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class LengthSubString //basicly a substring is an acronim of letters or words that repeat themselves in a sting so "abcabbc" the substring is "abc' because after the c the a is repeated 
    {
        public static int LengthOfLongestSubstring(string s)
        {
            List<string> reserva_substr = new List<string>();
            string substring = "";
            int biggest_size = 0;
            for (int i =0; i<s.Length;i++)
            {
                if (Regex.Match(substring, s[i].ToString()).Success)
                {
                    reserva_substr.Add(substring);
                    substring = s[i].ToString();
                }else
                {
                    substring += s[i].ToString();
                }
            }
            reserva_substr.Add(substring);
            if (reserva_substr.Count>1)
            {
                for (int i = 0; i < reserva_substr.Count - 1; i++)
                {
                    if (reserva_substr[i].Length < reserva_substr[i+1].Length)
                    {
                        biggest_size = reserva_substr[i + 1].Length;
                    }
                    else
                    {
                        biggest_size = reserva_substr[i].Length;
                    }
                }
            }else
            {
                biggest_size = substring.Length;
            }
            return biggest_size;
        }
    }
}
