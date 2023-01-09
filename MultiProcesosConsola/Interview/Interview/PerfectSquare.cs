using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class PerfectSquare
    {
        static bool flag;
        public static bool IsSquare(int n)
        {
            if(n<0)
            {
                return false;
            }
            for(int i=0; Math.Pow(i,2)<= n; i++)
            {
                if(Math.Pow(i, 2) == n)
                {
                    flag=true;
                }else
                {
                    flag = false;
                }
                
            }
            return flag;
        }
    }
}
