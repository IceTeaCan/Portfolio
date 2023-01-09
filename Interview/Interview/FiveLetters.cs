using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class FiveLetters
    {
        public static string SpinWords(string sentence)
        {
            string sentenceReturn = "";
            char[] charArray;
            string[] words = sentence.Split(' ');
            foreach( var word in words)
            {
                word.Trim();
                if(word.Length>4)
                {
                    charArray = word.ToCharArray();
                    Array.Reverse(charArray);
                    sentenceReturn = sentenceReturn + new string(charArray)+" ";
                }
                else
                {
                    sentenceReturn = sentenceReturn + word + " ";
                }
            }
            return sentenceReturn.TrimEnd();
        }
    }
}
