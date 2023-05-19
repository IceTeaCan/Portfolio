using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class TwoStringsSum
    {
        public static string sumStrings(string a, string b)
        {
            long retorno = Convert.ToInt64(a)+Convert.ToInt64(b);
            return Convert.ToString(retorno);
        }
    }
}