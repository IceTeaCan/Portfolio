using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Compare2Arrays
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> array = new List<int>();
            //Your goal in this exercise is to implement a difference function, which subtracts one list from another and returns the result.
            //It should remove all values from list a, which are present in list b keeping their order.
            //If a value is present in b, all of its occurrences must be removed from the other
            if (a.Length == 0 || b.Length == 0)// if the size of a/b is 0 there's nothing to compare to
            {
                return a;
            }
            foreach(int value1 in a)
            {
                foreach (int value2 in b)
                {
                    if (value1 == value2)
                    {
                        break;

                    }
                    else if (value2 == b[b.Length - 1])
                    {
                        array.Add(value1);
                    }
                }
            }
            int[] nuevoA = array.ToArray();
            a = nuevoA;
            Array.Sort(a);
            return a;
            
        }
    }
}
