using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int suma = 0;
            int cantidad = 0;
            int mayores = 0;
            int menores = 0;

            Console.WriteLine("Ingrese una edad (-1 para terminar): ");
            edad = int.Parse(Console.ReadLine());

            while (edad >= 0)
            {
                suma = suma + edad;
                cantidad++;

                if (edad >= 18)
                {
                    mayores++;
                }
                else
                {
                    menores++;
                }
                Console.Write("Ingrese una edad (-1 para terminar): ");
                edad = int.Parse(Console.ReadLine());

            }
            double promedio = (double)suma / cantidad;

            Console.WriteLine("Promedio " + promedio);
            Console.WriteLine("Mayores de edad " + mayores);
            Console.WriteLine("Menores de edad " + menores);
        }
    }
}
