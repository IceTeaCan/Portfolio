using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class StringManipulation
    {
        public static String Accum(string s)//RULES: just the first letter can be uppercased, must be separated by a -, need to augment the quantity of letters by 1 each cicle
        {
            s = s.ToLower();//make all letter lower
            string palabraFinal = "";//acumulator of letter finished
            int flag = 0;
            foreach (char letter in s)
            {
                if (flag == 0)//treat the first letter first because of the repeat, can't be 0
                {
                    string let = letter.ToString();
                    let = let.ToUpper();
                    palabraFinal += let + "-";
                    flag++;
                }
                else //treat all the other letters now that you can use the flag for the repeat
                {
                    string let = letter.ToString();
                    let = let.ToUpper();
                    palabraFinal += let;
                    foreach (char letra in Enumerable.Repeat(letter, flag))//repeat the letter flag times 
                    {
                        palabraFinal += letra;
                    }
                    flag++;
                    if (flag != s.Length)// when flag is == to the s size it means is the last letter
                    {
                        palabraFinal += "-";
                    }
                }
            }
            return palabraFinal;

        }
    }
}
