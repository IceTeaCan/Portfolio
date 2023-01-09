using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class VerifyBraces
    {
        public static bool validBraces(string braces)
        {
            var st = new Stack<char>();
            foreach (var c in braces)
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        st.Push(c);
                        continue;
                    case ')':
                        if (st.Count == 0 || st.Pop() != '(') return false;
                        continue;
                    case ']':
                        if (st.Count == 0 || st.Pop() != '[') return false;
                        continue;
                    case '}':
                        if (st.Count == 0 || st.Pop() != '{') return false;
                        continue;
                }
            Console.WriteLine(st);
            return st.Count == 0;
        }
    }
}
