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
            Console.WriteLine("Ingrese la cantidad de droides");
            int droines = Convert.ToInt32(Console.ReadLine());
            int total = droines * 2000;
            Double descuento = total * 0.20;
            Double preciofinal = total - descuento;

            if ( droines>= 3 )           
            {
                Console.WriteLine("El precio original es : " + total);
                Console.WriteLine("El ahorro es de : " + descuento);
                Console.WriteLine("El precio final es de : " + preciofinal);
            }
            else
            {
                Console.WriteLine("No hay descuento, el precio a pagar es : " + total);

            }

        
        }
    }
}
