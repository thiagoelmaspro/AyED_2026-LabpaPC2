using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, decime cuanto vale esto; ");
            Double monto = Convert.ToInt32(Console.ReadLine());
            Double original = monto;
            Double descuento = monto / 0.15;
            Double total = monto - descuento;
            if (monto > 5000)
            {

                Console.WriteLine("Se aplico el descuento, el total es " + descuento);
               

            }
            else
               
              Console.WriteLine("No se aplicaron descuentos. El precio final es " + original);

        }
    }
}
