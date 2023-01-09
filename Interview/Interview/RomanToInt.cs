using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class RomanToInt
    {
        public static int RomToInt(string s)
        {
            int result = 0, flag = 0;
            for (int i = 0; i < s.Length; i++)
            {
                flag++;
                switch (s[i])
                {
                    case 'I':
                        if (flag < s.Length && s[flag] == 'V' || flag < s.Length && s[flag] == 'X')
                        {
                            result -= 1;
                        }
                        else
                        {
                            result += 1;
                        }
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        if (flag < s.Length && s[flag] == 'L' || flag < s.Length && s[flag] == 'C')
                        {
                            result -= 10;
                        }
                        else
                        {
                            result += 10;
                        }
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        if (flag < s.Length && s[flag] == 'D' || flag < s.Length && s[flag] == 'M')
                        {
                            result -= 100;
                        }
                        else
                        {
                            result += 100;
                        }
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                }
            }
            return result;
        }
    }
}
