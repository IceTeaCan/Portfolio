using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class FaceLikes
    {
        public static string Likes(string[] name)
        {
            string returnable = "";
            switch(name.Length)
            {
                case 0:
                    returnable = "no one likes this";
                    break;
                case 1:
                    returnable = name[0]+" likes this";
                    break;
                case 2:
                    returnable = name[0]+" and "+name[1]+ " like this";
                    break;
                case 3:
                    returnable = name[0] + ", " + name[1] + " and " + name[2] + " like this";
                    break;
                default:
                    returnable = name[0] + ", " + name[1] + " and " + Convert.ToString(name.Length - 2) + " others like this";
                    break;

            }
            return returnable;
            throw new NotImplementedException();
        }
    }
}
