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
            Console.WriteLine("Decime el presupuesto disponible: ");
            int presupuesto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Decime el costo: ");
            int costo = Convert.ToInt32(Console.ReadLine());
            int diferencia = presupuesto - costo;

            if (presupuesto > costo)          
            {

                Console.WriteLine("El presupuesto alcanza");
            }
            else
                Console.WriteLine("El costo es mas, faltaria un total de " + diferencia);
        }
    }
}
