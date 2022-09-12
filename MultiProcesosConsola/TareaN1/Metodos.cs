using System;

namespace TareaN1
{
    class Metodos
    {
        //variables 
        private double dolar = 602.63, velLuz_km = 299792.46;
        private int ent1 = 0, lustro = 5, distSol_marte = 228526848;

        //constructor 
        static Metodos() { }
        
        // Funciones 
        // Calculo matemático de área de un triángulo 
        public int AreaTriang()
        {
            Console.Write("Digite la base de el tríangulo :");
            int ba = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el largo de el tríangulo :");
            int alt = Convert.ToInt32(Console.ReadLine());
            int res = (ba * alt) / 2;
            return res;
        }

        // Converción monetaria de dos monedas 
        public double ConvDin()
        {
            Console.Write("Digíte la cantidad de dólares a convertir :");
            ent1 = Convert.ToInt32(Console.ReadLine());
            double res = ent1 * dolar;
            return res;
        }

        //Comparación de edades 
        public void Edad()
        {
            Console.Write("Digite una edad :");
            int ed1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite la edad a comparar :");
            int ed2 = Convert.ToInt32(Console.ReadLine());
            if (ed1 == ed2)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        // Uso de el tiempo real para el calculo de datos 
        public int Month()
        {
            Console.Write("Digite el mes de nacimiento :");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite el año de nacimiento :");
            int anio = Convert.ToInt32(Console.ReadLine());
            int n = 0;

            if (mes > 12||anio > DateTime.Now.Year||anio == DateTime.Now.Year && mes > DateTime.Now.Month)
            {
                Console.WriteLine("Este valor no es valido pues la persona no ha nacido todavía o la fecha ingresada no es válida");
            }else if (mes > DateTime.Now.Month)
            {
                do
                {
                    n++;
                    mes--;
                }
                while (mes != DateTime.Now.Month);
            }else if (mes < DateTime.Now.Month)
            {
                do
                {
                    n++;
                    mes++;
                }
                while (mes != DateTime.Now.Month);
            }

            while (DateTime.Now.Year != anio)
            {
                anio++;
                n = n + 12;
            }
            return n;
        }

        // Converción de formatos de medición 
        public double Grado()
        {
            Console.Write("Digite los grados en centígrados a analizar :");
            double grad = double.Parse(Console.ReadLine());
            double res = 1.8 * grad + 32;
            Console.WriteLine("Grados centigrados :{0}",grad);
            return res;
        }

        /*lustro = 5 años 
        1 año = 31.536.000 segundos
        */
        public int Lustro()
        {
            int res = lustro * 31536000;
            return res;
        }

        /*
            Distancia de el sol a marte : 228.526.848 km
            Velocidad de la luz en km : 299792.46 km por segundos  
        */
        public double Marte()
        {
            double res = distSol_marte/velLuz_km;
            return res;
        }

        // Distancia 1 km 
        // Diametro de la rueda 50 cm = 0.005 km 
        public double VuetaLlanta()
        {
            int n = 0;
            double diam = 0.005;

            double res = 2*Math.PI*diam;
            while(res<1)
            {
                n++;
                res += res;
            }
            return n;
        }
         /* 
          edificio 20 metros 
          angulo 22
         */
        public double Sombra()
        {
            double radian = 22*(Math.PI/180);
            double alt = 20;
            double res = alt / Math.Tan(radian);
            return res;
        }

    }
}
