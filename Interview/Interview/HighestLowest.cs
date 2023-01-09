using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class HighestLowest
    {
        public static string HighAndLow(string numbers)
        {
            string[] numeros = numbers.Split(' ');
            List<Int32> newOrder = new List<Int32>();
            int lowest = 0, highest =0;
            foreach (string num in numeros)
            {
                newOrder.Add(Convert.ToInt32(num));
            }
            if(numeros.Length<=1)
            {
                return numbers+" "+numbers;
            }
            else if (newOrder[0] > newOrder[1])
            {
                highest = newOrder[0];
                lowest = newOrder[1];
            }else
            {
                lowest = newOrder[0];
                highest = newOrder[1];
            }

            foreach(int value in newOrder)
            {
                if(highest<value)
                {
                    highest = value;
                }else if(lowest>value)
                {
                    lowest = value;
                }
            }
            string answer = highest.ToString() + " " + lowest.ToString();
            return answer;
        }
        public static string HighAndLowSimple(string numbers)
        {
            var parsed = numbers.Split().Select(int.Parse);
            return parsed.Max() + " " + parsed.Min();
        }
    }
}
