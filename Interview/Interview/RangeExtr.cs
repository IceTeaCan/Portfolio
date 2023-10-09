using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class RangeExtr
    {
        public static string Extract(int[] args)
        {
            string devolucion = "";
            int flagmem = 0;
            bool flag = false;
            if(args.Length<3)
            {
                devolucion = Convert.ToString(args[0])+","+ Convert.ToString(args[1]);
                return devolucion;
            }
            for(int i=0;i<args.Length;i++)
            {
                if (i + 1 <= args.Length - 1 && args[i] == args[i + 1] - 1 && flag == false)// a lot of conditions due to specific cases where the data need it a different answer, the problem was not the ranges ..... the "," and the "-" where the pain to alocate correctly
                {
                    devolucion += Convert.ToString(args[i]);
                    flagmem = args[i];
                    flag = true;
                }
                else if (i + 1 <= args.Length - 1 && args[i] == args[i + 1] - 1)
                {

                }
                else if (flag == true && i + 1 < args.Length && flagmem != args[i] - 1)
                {
                    devolucion += "-" + Convert.ToString(args[i]) + ",";
                    flag = false;
                }
                else if (flag == true && i + 1 < args.Length && flagmem == args[i] - 1)
                {
                    devolucion += "," + Convert.ToString(args[i]) + ",";
                    flag = false;
                }
                else if (flag == true && i + 1 == args.Length && flagmem != args[i] - 1)
                {
                    devolucion += "-" + Convert.ToString(args[i]);
                }
                else if (flag == true && i == args.Length - 1 && flagmem == args[i] - 1)
                {
                    devolucion += "," + Convert.ToString(args[i]);
                }
                else if(i== args.Length-1)
                {
                    devolucion += Convert.ToString(args[i]);
                }
                else
                {
                    devolucion += Convert.ToString(args[i]) + ",";
                }                
            }

            return devolucion;  //TODO
        }
    }
}
