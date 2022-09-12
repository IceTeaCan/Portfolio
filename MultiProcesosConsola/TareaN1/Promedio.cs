using System;

namespace TareaN1
{
    class Promedio
    {
        //variables 
        private string alumno;
        private double exam1, exam2, proyecto, tarea, cotidiano, asistencia;
        // variables static porque así se les da un valor por default gracias a el entorno de visual studio 
        private static double promedio1, promedio2,promedio3,promedio4, promedio5, res1, res2, res3, res4, res5, res6;        
        //Función de menú promedios 
        public void Menu()
        {
            bool estado = true;
            Console.Write("************Menú de promedios************\nDigite el nombre de el alumno :");
            alumno = Console.ReadLine();
            do
            {
                estado = MenuAlumno();
            } while (estado);
        }

        public Boolean MenuAlumno()
        {
            Console.Write("Seleccione la materia que decea hacer un registro  :\n Lista de alumnos\n Español\n Matemáticas\n Economía\n Programación\n Inglés\n Se le exige cumplir las normas gramaticales de escritura de cada palabra :");
            String opc = Console.ReadLine();

            switch (opc)
            {
                case "1":
                    break;
                case "Español":
                case "español":
                    Console.WriteLine("Digite la nota de el primer examen :");
                    exam1 = double.Parse(Console.ReadLine());
                    res1 = exam1 * 25 / 100;
                    Console.WriteLine("Digite la nota de el segundo examen :");
                    exam2 = double.Parse(Console.ReadLine());
                    res2 = exam2 * 25 / 100;
                    Console.WriteLine("Digite la nota de el proyecto :");
                    proyecto = double.Parse(Console.ReadLine());
                    res3 = proyecto * 20 / 100;
                    Console.WriteLine("Digite la nota de las tareas :");
                    tarea = double.Parse(Console.ReadLine());
                    res4 = tarea * 10 / 100;
                    Console.WriteLine("Digite la nota de cotidiano :");
                    cotidiano = double.Parse(Console.ReadLine());
                    res5 = cotidiano * 10 / 100;
                    Console.WriteLine("Digite la nota de asistencia :");
                    asistencia = double.Parse(Console.ReadLine());
                    res6 = asistencia * 10 / 100;
                    promedio1 = res1 + res2 + res3 + res4 + res5 + res6;
                    Console.Write("La nota de el alumno {0} es de :{1}", alumno, promedio1);
                    break;
                case "Matemáticas":
                case "matemáticas":
                    Console.WriteLine("Digite la nota de el primer examen :");
                    exam1 = double.Parse(Console.ReadLine());
                    res1 = exam1 * 25 / 100;
                    Console.WriteLine("Digite la nota de el segundo examen :");
                    exam2 = double.Parse(Console.ReadLine());
                    res2 = exam2 * 25 / 100;
                    Console.WriteLine("Digite la nota de el proyecto :");
                    proyecto = double.Parse(Console.ReadLine());
                    res3 = proyecto * 20 / 100;
                    Console.WriteLine("Digite la nota de las tareas :");
                    tarea = double.Parse(Console.ReadLine());
                    res4 = tarea * 10 / 100;
                    Console.WriteLine("Digite la nota de cotidiano :");
                    cotidiano = double.Parse(Console.ReadLine());
                    res5 = cotidiano * 10 / 100;
                    Console.WriteLine("Digite la nota de asistencia :");
                    asistencia = double.Parse(Console.ReadLine());
                    res6 = asistencia * 10 / 100;
                    promedio2 = res1 + res2 + res3 + res4 + res5 + res6;
                    Console.Write("La nota de el alumno {0} es de :{1}", alumno, promedio2);
                    break;
                case "Economía":
                case "economía":
                    Console.WriteLine("Digite la nota de el primer examen :");
                    exam1 = double.Parse(Console.ReadLine());
                    res1 = exam1 * 25 / 100;
                    Console.WriteLine("Digite la nota de el segundo examen :");
                    exam2 = double.Parse(Console.ReadLine());
                    res2 = exam2 * 25 / 100;
                    Console.WriteLine("Digite la nota de el proyecto :");
                    proyecto = double.Parse(Console.ReadLine());
                    res3 = proyecto * 20 / 100;
                    Console.WriteLine("Digite la nota de las tareas :");
                    tarea = double.Parse(Console.ReadLine());
                    res4 = tarea * 10 / 100;
                    Console.WriteLine("Digite la nota de cotidiano :");
                    cotidiano = double.Parse(Console.ReadLine());
                    res5 = cotidiano * 10 / 100;
                    Console.WriteLine("Digite la nota de asistencia :");
                    asistencia = double.Parse(Console.ReadLine());
                    res6 = asistencia * 10 / 100;
                    promedio3 = res1 + res2 + res3 + res4 + res5 + res6;
                    Console.Write("La nota de el alumno {0} es de :{1}", alumno, promedio3);
                    break;
                case "Programación":
                case "programación":
                    Console.WriteLine("Digite la nota de el primer examen :");
                    exam1 = double.Parse(Console.ReadLine());
                    res1 = exam1 * 25 / 100;
                    Console.WriteLine("Digite la nota de el segundo examen :");
                    exam2 = double.Parse(Console.ReadLine());
                    res2 = exam2 * 25 / 100;
                    Console.WriteLine("Digite la nota de el proyecto :");
                    proyecto = double.Parse(Console.ReadLine());
                    res3 = proyecto * 20 / 100;
                    Console.WriteLine("Digite la nota de las tareas :");
                    tarea = double.Parse(Console.ReadLine());
                    res4 = tarea * 10 / 100;
                    Console.WriteLine("Digite la nota de cotidiano :");
                    cotidiano = double.Parse(Console.ReadLine());
                    res5 = cotidiano * 10 / 100;
                    Console.WriteLine("Digite la nota de asistencia :");
                    asistencia = double.Parse(Console.ReadLine());
                    res6 = asistencia * 10 / 100;
                    promedio4 = res1 + res2 + res3 + res4 + res5 + res6;
                    Console.Write("La nota de el alumno {0} es de :{1}", alumno, promedio4);
                    break;
                case "inglés":
                case "Inglés":
                    Console.WriteLine("Digite la nota de el primer examen :");
                    exam1 = double.Parse(Console.ReadLine());
                    res1 = exam1 * 25 / 100;
                    Console.WriteLine("Digite la nota de el segundo examen :");
                    exam2 = double.Parse(Console.ReadLine());
                    res2 = exam2 * 25 / 100;
                    Console.WriteLine("Digite la nota de el proyecto :");
                    proyecto = double.Parse(Console.ReadLine());
                    res3 = proyecto * 20 / 100;
                    Console.WriteLine("Digite la nota de las tareas :");
                    tarea = double.Parse(Console.ReadLine());
                    res4 = tarea * 10 / 100;
                    Console.WriteLine("Digite la nota de cotidiano :");
                    cotidiano = double.Parse(Console.ReadLine());
                    res5 = cotidiano * 10 / 100;
                    Console.WriteLine("Digite la nota de asistencia :");
                    asistencia = double.Parse(Console.ReadLine());
                    res6 = asistencia * 10 / 100;
                    promedio5 = res1 + res2 + res3 + res4 + res5 + res6;
                    Console.Write("La nota de el alumno {0} es de :{1}", alumno, promedio5);
                    break;
                default:
                    Console.WriteLine("El dato ingresado es erróneo, porfavor intente de nuevo");
                    MenuAlumno();
                    break;
            }
            Console.WriteLine("Decea salir ?\n si \n no");
            opc = Console.ReadLine();
            if (opc.Equals("si"))
            {   return false;   }
                
                
            else
            {   return true;    }
                
        }
    }
}
