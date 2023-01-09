using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class FindTheOutlier
    {
        public static int Find(int[] integers)
        {
            int oddCount = 0, oddindex = 0;
            int evenCount = 0, evenindex = 0;
            for (int i =0;i<integers.Length;i++)
            {
                if(integers[i]%2 == 0 || integers[i] == 0)
                {
                    oddindex = i;
                    oddCount++;
                }else 
                {
                    evenindex = i;
                    evenCount++;
                }
            }
            if(evenCount==1) {return integers[evenindex];}
            else {return integers[oddindex];}
        }
    }
}
