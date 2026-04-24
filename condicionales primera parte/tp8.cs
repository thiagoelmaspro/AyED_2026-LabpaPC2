using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime un numero ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 5 == 0)
            {
                Console.WriteLine("Si, es divisible por 5 ");
            }
            else
                Console.WriteLine("No, no es divisible");

        }
    }
}
