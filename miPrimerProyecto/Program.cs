using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //prioridad de los operadores aritmeticos.
            //ejercicioobtener la el promedio de una serie de numeros
            int[] serie = new int[] { 5, 4, 6, 8, 9, }; //32
            int suma = 0;
            foreach (int num in serie)
            {
                suma = suma + num;
            }
                Console.WriteLine("la suma es: {0}, el promedio {1}", suma, suma/serie.Length);
            //pausa.
            Console.ReadLine();
        }
    }
}
