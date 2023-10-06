using System;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace Interview
{
    class CompareString
    {
        public static bool IsMatch(string s, string p)
        { // investigate more on regex and how it works (pegular expressions)

            // Modify the strings to replace "*" with the letter to be compared
            s = Regex.Replace(p, @"\*", p[0].ToString());

            // Define a regular expression pattern with "." matching zero or more characters
            string pattern = "^" + Regex.Escape(p).Replace("\\.", ".*") + "$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Check if string1 matches the pattern
            bool isMatch = regex.IsMatch(s);

            if (isMatch)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        //bool flag = false;
        //bool flag2 = true;
        //for (int i = 0; i < s.Length && s.Length == p.Length&& flag2 == true; i++)
        //{
        //    if (s[i] == p[i] || p[i] == '.' || p[i] == '*')
        //    {
        //        flag = true;
        //    }
        //    else
        //    {
        //        flag = false;
        //        flag2 = false;
        //        break;
        //    }
        //}
        //return flag;
        }
    }
}

