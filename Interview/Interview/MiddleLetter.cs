using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class MiddleLetter
    {
        public static string GetMiddle(string s)
        {
            if(s.Length<2)
            {
                return s;
            }
            else if (s.Length%2==0)
            {
                string let = "";
                int div = s.Length / 2;
                let = s[div-1].ToString() + s[div].ToString();
                return let;
            }
            else
            {
                string let = "";
                int div = (s.Length - 1)/2;
                let = s[div].ToString();
                return let;
            }
        }
    }
}
