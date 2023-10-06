using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Isograms
    {
        public static bool Isogram(string str)
        {
            str = str.ToLower();
            Regex regex = new Regex("");
            string[] chr_wrd = regex.Split(str);// Imnportant to notice that regex ads the designated input "" at the beginning of the array and at the end
            for(
                int x=1;x < str.Length;x++)// .length takes the number of char in "str" but not the number of index in "chr_wrd" so you need to take out of the equation 0 and .length+1 also take in count the last char cannot be compared to nothing so we can skip it 
            {
                for (int i = x+1; i <= str.Length; i++)
                {
                    if (chr_wrd[x] == chr_wrd[i])
                    {
                        return false;
                    }
                }
            }
            // Code on you crazy diamond!
            
            return true;
        }
    }
}
