  /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    -------------------     Proyecto Unix simulación de un solo procesador aplicando HRRN (Planificación a la Tasa de Respuesta más Alta)       ---------------------
    -------------------     Autor : Jonathan Salazar Rodríguez                                                                                  ---------------------
    -------------------     Profesor : Claudio Mendez Cardenas                                                                                  ---------------------
    -------------------     Materia : Sistemas Operativos                                                       Fecha entrega : 27/8/2021       ---------------------
    -------------------                                                                                                                         ---------------------
    -----------------------------------------------------------------------------------------------------------------------------------------------------------------*/

//Highest Response Ratio Next (HRRN)
#include <stdio.h>

// Definición de registro process 
struct process 
{
    char name;      // Nombre
    int at, bt, wt, tt;     // Tiempo de llegada, Tiempo de servicio, ct, Tiempo de espera,Tiempo de ejecución
    bool completed;      // Variable de estado completado
    double ntt;      // Tiempo de ejecución normalizado 
} p[10];

int n;      // Variable de cantidad de procesos a realizar

void AcomPorLlega()   // Acomoda los procesos por tiempo de llegada  
{
    struct process temp;    // Proceso temporal para mover de posición 

    // Selección de acomodado aplicado 
    for (int i = 0; i < n+1; i++)     // i = variable índice de comparación
    {
        for (int j = i + 1; j < n; j++)     // j = recorrido de comparación a i con los demás contenidos para asegurar de no dejar ningún incompleto atrás 
        {
            // Chequeo por tiempo de llegada 
            if (p[i].at >  p[j].at)     // Si un proceso fue ejecutado primero que otra hace la verificación para re-acomodar la lista 
            {

                // Intercambio de columnas de la lista 
                temp = p[i];
                p[i] = p[j];
                p[j] = temp;
            }
        }
    }
}

void PorEjecucion()   // Acomoda los procesos por ejecuciones realizadas 
{
    struct process temp;    // Proceso temporal para mover de posición 

    // Selección de acomodado aplicado 
    for (int i = 0; i < n; i++)     // i = variable índice de comparación
    {
        for (int j = i + 1; j < n; j++)     // j = recorrido de comparación a i con los demás contenidos para asegurar de no dejar ningún incompleto atrás 
        {
            // Chequeo por ejecución completada 
            if (p[i].completed == 0 && p[j].completed == 1)     // Si un proceso fue ejecutado primero que otra hace la verificación para re-acomodar la lista 
            {

                // Intercambio de columnas de la lista 
                temp = p[i];
                p[i] = p[j];
                p[j] = temp;
            }
        }
    }
}

int main()
{
    n = 5;      // Cantidad de procesos simulados 

    //              A  B  C  D  E     Tiempos de llegada predefinidos 
    int arriv[] = { 0, 3, 1, 8, 2 };

    //              A  B  C  D  E     Tiempos de servicio predefinidos 
    int burst[] = { 3, 6, 7, 2, 5 };

    int t = 0;      // Variable de tiempos de procesador 
    
    for (int i = 0, c = 'A'; i < n; i++, c++)       // Rellena el array de procesos con la cantidad deceada de información 
    {
        p[i].name = c;
        p[i].at = arriv[i];
        p[i].bt = burst[i];
        
        p[i].completed = 0;     // Variables de completación de status    Pendiente = 0     Completado = 1
        
    }
    AcomPorLlega();// Acomoda todos por tiempo de llegada para hacer las funciones correctamente 

    printf("\nNombre\tTiempo llegada\tTiempo servicio\t  Tiempo espera");
    printf("\t Tiempo ejecucion\t    Taza respuesta");

    int k = 0;      // Declaración de variables bandera recorrido while
    for (int i = 0; i < n; i++)     // Bucle de trabajo de todos los procesos 
    {
        PorEjecucion();
        if (p[i].completed != 1 && p[i].at != 0)        // Si no esta completado y no es el primer proceso
        {
            k = i;      // Variable bandera de el recorrido while para calcular la prioridad de los multiples procesos disponibles sin afectar el controlador i
            while (p[k].completed != 1 && k < n && p[k].at < t)     // Recorrido de los procesos incompletos para analizar quien tiene el tiempo mas alto y su tiempo de declaración es el correcto
            { 
                //Realiza la formula para conocer quien es el proceso mas alto mas adelante 
                p[k].wt = t - p[k].at;
                p[k].ntt = ((float)p[k].wt + p[k].bt) / p[k].bt; 
                k++;
            }

            k = i;      // Iguala la bandera k a la i, siendo i el proceso que va a ser ejecutado 

            if (p[k + 1].ntt == NULL)       // Analiza si hay un proceso delante de este 
            {
                p[k].wt = t - p[k].at;
                p[k].tt = t + p[k].bt;
                t = p[k].tt;
                p[k].completed = 1;
                printf("\n%c\t\t%d\t\t", p[k].name, p[k].at);
                printf("%d\t\t%d\t\t", p[k].bt, p[k].wt);
                printf("%d\t\t\t%f", p[k].tt, p[k].ntt);
            }

            else if (p[k].completed != 1 && p[k].ntt == p[k + 1].ntt)       // Analiza si no esta completado y los procesos a comparar tienen el mismo nivel de prioridad para pasar al primero en lista 
            {
                p[k].wt = t - p[k].at;
                p[k].tt = t + p[k].bt;
                t = p[k].tt;
                p[k].completed = 1;
                printf("\n%c\t\t%d\t\t", p[k].name, p[k].at);
                printf("%d\t\t%d\t\t", p[k].bt, p[k].wt);
                printf("%d\t\t\t%f", p[k].tt, p[k].ntt);
            }

            if (p[k + 1].ntt != NULL && p[k].ntt > p[k + 1].ntt)        // Compara para saber si el primer proceso tiene mas prioridad que el segundo 
            {
                if (p[k + 2].ntt != NULL && p[k].ntt > p[k + 2].ntt)        // Compara si el primer proceso tiene mas prioridad que el tercer proceso 
                {
                    p[k].wt = t - p[k].at;
                    p[k].tt = t + p[k].bt;
                    t = p[k].tt;
                    p[k].completed = 1;
                    printf("\n%c\t\t%d\t\t", p[k].name, p[k].at);
                    printf("%d\t\t%d\t\t", p[k].bt, p[k].wt);
                    printf("%d\t\t\t%f", p[k].tt, p[k].ntt);
                }
                else if(p[k + 2].ntt != NULL)       // Confirma que el proceso 3 exista para ser guardado como proceso ejecutado 
                {
                    p[k + 2].wt = t - p[k + 2].at;
                    p[k + 2].tt = t + p[k + 2].bt;
                    t = p[k + 2].tt + t;
                    p[k + 2].completed = 1;
                    printf("\n%c\t\t%d\t\t", p[k + 2].name, p[k + 2].at);
                    printf("%d\t\t%d\t\t", p[k + 2].bt, p[k + 2].wt);
                    printf("%d\t\t\t%f", p[k + 2].tt, p[k + 2].ntt);
                }
                else        // Si no se cumple ninguna de las anteriores significa que el proceso 1 es mas largo que el 2, lo pasa a ejecución y el tercero no existe 
                {
                    p[k].wt = t - p[k].at;
                    p[k].tt = t + p[k].bt;
                    t = p[k].tt;
                    p[k].completed = 1;
                    printf("\n%c\t\t%d\t\t", p[k].name, p[k].at);
                    printf("%d\t\t%d\t\t", p[k].bt, p[k].wt);
                    printf("%d\t\t\t%f", p[k].tt, p[k].ntt);
                }
            }
            else if (p[k + 1].ntt != NULL && p[k].ntt < p[k + 1].ntt)       // Verifica que exista un proceso siguente y que sea menor a ese 
            {
                if (p[k + 2].ntt != NULL && p[k + 1].ntt > p[k + 2].ntt)        // Compara si el segundo proceso tiene mas prioridad que el tercer proceso 
                {
                    p[k + 1].wt = t - p[k + 1].at;
                    p[k + 1].tt = t + p[k + 1].bt;
                    t = p[k + 1].tt;
                    p[k + 1].completed = 1;
                    printf("\n%c\t\t%d\t\t", p[k + 1].name, p[k + 1].at);
                    printf("%d\t\t%d\t\t", p[k + 1].bt, p[k + 1].wt);
                    printf("%d\t\t\t%f", p[k + 1].tt, p[k + 1].ntt);
                }
                else if (p[k + 2].ntt != NULL)      // Confirma que el proceso 3 exista para ser guardado como proceso ejecutado 
                {
                    p[k + 2].wt = t - p[k + 2].at;
                    p[k + 2].tt = t + p[k + 2].bt;
                    t = p[k + 2].tt + t;
                    p[k + 2].completed = 1;
                    printf("\n%c\t\t%d\t\t", p[k + 2].name, p[k + 2].at);
                    printf("%d\t\t%d\t\t", p[k + 2].bt, p[k + 2].wt);
                    printf("%d\t\t\t%f", p[k + 2].tt, p[k + 2].ntt);
                }
                else        // Si no se cumple ninguna de las anteriores significa que el proceso 2 es mas largo que el 1, lo pasa a ejecución y el tercero no existe 
                {
                    p[k + 1].wt = t - p[k + 1].at;
                    p[k + 1].tt = t + p[k + 1].bt;
                    t = p[k + 1].tt;
                    p[k + 1].completed = 1;
                    printf("\n%c\t\t%d\t\t", p[k + 1].name, p[k + 1].at);
                    printf("%d\t\t%d\t\t", p[k + 1].bt, p[k + 1].wt);
                    printf("%d\t\t\t%f", p[k + 1].tt, p[k + 1].ntt);
                }
            }
        }
        else        // Este es el primer proceso donde el tiempo de el procesador no ha iniciado por lo que se debe trabajar diferente 
        {
            p[i].wt = p[i].at;
            p[i].tt = p[i].bt;
            p[i].ntt = ((double)p[i].wt + p[i].bt) / p[i].bt;
            t = p[i].tt;
            p[i].completed = 1;
            printf("\n%c\t\t%d\t\t", p[i].name, p[i].at);
            printf("%d\t\t%d\t\t", p[i].bt, p[i].wt);
            printf("%d\t\t\t%f", p[i].tt, p[i].ntt);
        }
    }
}