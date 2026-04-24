using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime una nota de un examen: ");
            double nota = Convert.ToInt32(Console.ReadLine());

            if (nota > 7)
            {
                Console.WriteLine("Promocionado");
            }
            else if (nota > 4)
            {
                Console.WriteLine("A finales");
            }
            else
                Console.WriteLine("Recuperatorio");
        }
    }
}
