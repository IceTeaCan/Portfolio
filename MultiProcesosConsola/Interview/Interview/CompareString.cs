using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class CompareString
    {
        public static bool IsMatch(string s, string p)
        {
            bool flag = false;
            bool flag2 = true;
            for (int i = 0; i < s.Length && s.Length == p.Length&& flag2 == true; i++)
            {
                if (s[i] == p[i] || p[i] == '.' || p[i] == '*')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    flag2 = false;
                    break;
                }
            }
            return flag;
        }
    }
}

