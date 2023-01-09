using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class ArrToPhone
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            string num = "(" + numbers[0] + numbers[1]+ numbers[2] + ") " + numbers[3]+ numbers[4] + numbers[5] + "-" + numbers[6] + numbers[7] + numbers[8] + numbers[9];
            return num;
        }
    }
}
