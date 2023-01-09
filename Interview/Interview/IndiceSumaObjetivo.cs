using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class IndiceSumaObjetivo
    {
        public static Int32[] array = new int[] { 8, 31, 45, 2, 1, 7, 10, 4 };//you can only use 1 iteration 
        public static Int32[] arrayRes = new int[8];
        static int objetivo = 11;
        static int valor1, valor2, indiceMain = 0;
        static bool flag = false;

        public static void Busqueda()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int valorsuma = 0;
                if (indiceMain!=array.Length-1&&flag==false&&indiceMain!=i&&objetivo>array[indiceMain])//-1 because of how arrays index works,flag checks if there's already an answer, if objetivo<=the number to work the sum will be higher allways so let's save time
                {
                    valor1 = array[indiceMain];
                    valor2 = array[i];
                    valorsuma = valor1 + valor2;
                    if (valorsuma.Equals(objetivo))
                    {
                        arrayRes[0] = indiceMain;
                        arrayRes[1] = i;
                        flag = true;
                    }
                }
            }
            if(flag==false)
            {
                indiceMain++;
                Busqueda();
            }
        }
    }
}
