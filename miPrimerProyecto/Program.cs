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
            //ejercicio de suma de dos numeros introducidos por el usuario.
            Console.Write("num1: ");
            double num1 = double.Parse(Console.ReadLine()); //"s" -> s

            Console.Write("num2: ");
            double num2 = double.Parse(Console.ReadLine());

            double respuesta = num1 + num2;
            Console.WriteLine("la suma de {0}+{1}={2}", num1, num2, respuesta);

            //Pausa
            Console.ReadLine();
        }
    }
}
