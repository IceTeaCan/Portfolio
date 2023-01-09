using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class NumbersOfLetters
    {
        public static string AlphabetPosition(string text)
        {
            string newWord = "";
            text = text.ToLower();
            foreach (char letter in text)
            {
                int num = Convert.ToInt32(letter);
                num = num - 96;
                if (num >0&& num<27)// in spanish you neet to take in count the ñ and all the letters with tildes
                {
                    newWord += num.ToString() + " ";
                    
                }
            }
            newWord = newWord.TrimEnd();
            return newWord;
        }
    }
}
