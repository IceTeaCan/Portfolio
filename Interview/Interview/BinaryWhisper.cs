using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class BinaryWhisper
    {
        public static string MultipleOf3(string binary)
        { // investigate more on regex and how it works (pegular expressions)
            // Regular expression that matches binary inputs that are multiple of 3
            int sum = 0;
            double ind = binary.Length-1;
            string salida;
           foreach (var multiple in binary)
           {
                if (ind>0)
                {
                    sum = sum + (Convert.ToInt32(multiple-'0')*Convert.ToInt32(Math.Pow(2, ind)));
                    ind -= 1;
                    Console.WriteLine(ind);
                    Console.WriteLine(sum);
                }
                else if(multiple.Equals('1'))
                {
                    sum = sum + 1;
                    Console.WriteLine(ind);
                    Console.WriteLine(sum);
                }
           }
           if(sum % 3==0)            
                salida = "Si soy multiplo de 3 att "+sum;
            else
                salida = "No soy multiplo de 3 att " + sum;
            return salida ;
        }
    }
}
