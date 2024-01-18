using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview // we use linq to convert the tipe of list to long 
{
    public class ArrReverse
    {
        public static long[] Digitize(long n) // funcion que devuelve un array en formato long
        {
            string numbers = Convert.ToString(n); //toma el numero y lo convierte en una cadena de caracteres
            List<string> lista = new List<string>(); //usamos un formato de lista pues la cantidad de numeros dentro del formato es indefinido
            foreach(var i in numbers) // tomamos el contenido 1 por 1 y lo ingresamos en la lista
            {
                lista.Add(i.ToString());
            }
            long[] array = lista.Select(long.Parse).ToArray(); // creamos un array en el formato que necesitamos sacarlo y con ayuda de la libreria de LINQ seleccionamos el contenido y transformamos el formato a long convirtiendolo en un array para ingresarlo en el array
            Array.Reverse(array); // invertimos el contenido del array 
            return array; //entregamos la solucion de la funcion
        }
    }
}
