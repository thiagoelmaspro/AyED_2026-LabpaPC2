using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime la edad de un hermano: ");
            int edad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Decime la edad del otro: ");
            int edad2 = Convert.ToInt32(Console.ReadLine());
            int diferencia = edad1 - edad2;

            if (edad1 > edad2)          
            {
                
                Console.WriteLine("El primer hermano es mayor por " + diferencia);
            }
            else
                Console.WriteLine("El segundo hermano es mas grande por " + diferencia);
        }
    }
}
