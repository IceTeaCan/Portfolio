using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview // we use linq to convert the tipe of list to long 
{
    public class ArrReverse
    {
        public static long[] Digitize(long n)
        {
            string numbers = Convert.ToString(n);
            List<string> lista = new List<string>();
            foreach(var i in numbers)
            {
                lista.Add(i.ToString());
            }
            long[] array = lista.Select(long.Parse).ToArray();
            Array.Reverse(array);
            return array;
        }
    }
}
