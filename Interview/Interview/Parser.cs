using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Parser
    {
        public static int ParseInt(string s)
        {
            int sum = 0, total = 0;
            string[] num_word = s.Split(' ', '.','-');
            foreach(string parnum in num_word)
            {
                switch (parnum)
                {
                    case "one":
                        sum = sum + 1;
                        break;
                    case "two":
                        sum = sum + 2;
                        break;
                    case "three":
                        sum = sum + 3;
                        break;
                    case "four":
                        sum = sum + 4;
                        break;
                    case "five":
                        sum = sum + 5;
                        break;
                    case "six":
                        sum = sum + 6;
                        break;
                    case "seven":
                        sum = sum + 7;
                        break;
                    case "eight":
                        sum = sum + 8;
                        break;
                    case "nine":
                        sum = sum + 9;
                        break;
                    case "ten":
                        sum = sum + 10;
                        break;
                    case "eleven":
                        sum = sum + 11;
                        break;
                    case "twelve":
                        sum = sum + 12;
                        break;
                    case "thirteen":
                        sum = sum + 13;
                        break;
                    case "fourteen":
                        sum = sum + 14;
                        break;
                    case "fifteen":
                        sum = sum + 15;
                        break;
                    case "sixteen":
                        sum = sum + 16;
                        break;
                    case "seventeen":
                        sum = sum + 17;
                        break;
                    case "eighteen":
                        sum = sum + 18;
                        break;
                    case "nineteen":
                        sum = sum + 19;
                        break;
                    case "twenty":
                        sum = sum + 20;
                        break;
                    case "thirty":
                        sum = sum + 30;
                        break;
                    case "forty":
                        sum = sum + 40;
                        break;
                    case "fifty":
                        sum = sum + 50;
                        break;
                    case "sixty":
                        sum = sum + 60;
                        break;
                    case "seventy":
                        sum = sum + 70;
                        break;
                    case "eighty":
                        sum = sum + 80;
                        break;
                    case "ninety":
                        sum = sum + 90;
                        break;
                    case "hundred":
                        sum = sum * 100;
                        break;
                    case "thousand" :
                        sum = sum * 1000;
                        total = total + sum;
                        sum = 0;
                        break;
                    case "million":
                        sum = sum * 1000000;
                        total = total + sum;
                        sum = 0;
                        break;
                    case "and":
                        break;
                    default:

                        break;
                }
            }
            total = total + sum;
            return total;
        }
    }
}
