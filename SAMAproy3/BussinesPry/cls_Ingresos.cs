using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BussinesPry
{
    public class cls_Ingresos
    {
        static string path = Environment.CurrentDirectory + @"..\..\..\..\..\ingresos.txt";

        public static void guardarCon(String ingre)
        {
            DateTime now = DateTime.Now;
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(now.ToLocalTime() + " -- " + ingre);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(now.ToLocalTime() + " -- " + ingre);
                }
            }
        }
    }
}
