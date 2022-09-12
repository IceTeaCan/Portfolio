
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------
  -------------------     Proyecto multiprocesos por consola                                                                                  ---------------------
  -------------------     Autor : Jonathan Salazar Rodríguez                                                                                  ---------------------
  -------------------     Profesor : Claudio Mendez Cardenas                                                                                  ---------------------
  -------------------     Materia : Programación 2                                                       Última modificación : 4/6/2021       ---------------------
  -------------------                                                                                                                         ---------------------
  -----------------------------------------------------------------------------------------------------------------------------------------------------------------*/

using System;

namespace TareaN1
{
    class Menu
    {
        // Funciones de menú principal 
        public static void MenuPrincipal()
        {
            //variables 
            String opc = "";
            Metodos metodo = new Metodos();
            Promedio promedio = new Promedio();
            bool estado = true;
            //menú de opciones 
           while(estado)
            {
                Console.Clear();
                Console.WriteLine("****************Menú Principal****************\nBienvenido usuario en este programa podrá realizar las siguientes tareas :\n1.Calculo de Área de un triángulo\n" +
               "2.Converción de dólares a colones\n3.Comparación de edad ingresada por dos usuarios \n4.Contador de meses transcurridos desde la fecha de nacimiento de un usuario " +
               "\n5.Converción de grados centígrados a grados Fahrenheit\n6.Cantidad de segundos en un lustro\n" +
               "7.Segundos que le toma llegar la luz a marte \n8.Calculo  de vueltas de una llanta en 1Km\n9.Longitud de sombra de un edificio \n10.Promedio de un alumno ");
                Console.WriteLine("Digite el número de la función que decea utilizar:");
                opc = Console.ReadLine();
                switch (opc)
                {
                    case "1":
                        Console.WriteLine("El área de el triangulo es :{0}", metodo.AreaTriang(), "\n");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Cantidad en colones :{0}", metodo.ConvDin(),"\n");
                        Console.ReadLine();
                        break;
                    case "3":
                        metodo.Edad();
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Cantidad de meses desde la fecha :{0}", metodo.Month(), "\n");
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("Grados Farenheight :{0}", metodo.Grado(), "\n");
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("Segundo en un lustro :{0}", metodo.Lustro(), "\n");
                        Console.ReadLine();
                        break;
                    case "7":
                        Console.WriteLine("A la luz le toma :{0} segundos llegar a marte",metodo.Marte(), "\n");
                        Console.ReadLine();
                        break;
                    case "8":
                        Console.WriteLine("Una llanta de 50 cm de diámetro le toma {0} vueltas para recorrer 1Km",metodo.VuetaLlanta(), "\n");
                        Console.ReadLine();
                        break;
                    case "9":
                        Console.WriteLine("La mosbra proyectada por un edificio de 20 metros de alto cuando el sol refleja en el a 22 grados de el mismo es de : {0}",metodo.Sombra(), "\n");
                        Console.ReadLine();
                        break;
                    case "10":
                        promedio.Menu();
                        Console.ReadLine();
                        break;
                    case "11":
                        estado = false;
                        break;
                    default:
                        Console.WriteLine("Esta no es una opción ", "\n");
                        Console.ReadLine();
                        break;
                }

            }
        }
        static void Main(string[] args)
        {
            MenuPrincipal();
        }
    }
}
