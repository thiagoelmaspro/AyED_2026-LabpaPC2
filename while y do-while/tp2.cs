using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            do
            {
                Console.WriteLine("Ingrese una nota del 1 al 10: ");
                nota = int.Parse(Console.ReadLine());

                if (nota < 1 || nota > 10)
                {
                    Console.WriteLine("Error. Nota invalida. ");
                }


            } while (nota < 1 || nota > 10);
            Console.WriteLine("Nota corrercta: " + nota);
            
            
            
        }
    }
}
