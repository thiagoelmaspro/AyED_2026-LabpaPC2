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
            Console.WriteLine("Cuanta es la distancia del viaje?: ");
            Double distancia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y cuanto combustible tenes?: ");
            Double combustible = Convert.ToInt32(Console.ReadLine());
            Double combustiblenecesario = distancia * 12;
            Double faltante = combustiblenecesario - combustible;

            if (combustiblenecesario <=combustible)
            {

                Console.WriteLine("Calculos precisos. Saltando al hiperespacio");
            }
            else
            {
                Console.WriteLine("Peligro, combustible insuficiente. faltan " + faltante + " litros " );

            }
       
        }
    }
}
