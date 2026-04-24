using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime tu sueldo: ");
            Double sueldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Decime tu tiempo: ");
            Double tiempo = Convert.ToInt32(Console.ReadLine());

            if (tiempo > 10)
            {

                Double aumento = sueldo * 0.20;
                Double sueldooriginal = aumento - sueldo;
                Console.WriteLine("el aumento es de: " + sueldooriginal);

            }
           else if 
            {

                Console.WriteLine("Todavia no puede iniciarlo. ");
            }
        }
    }
}
