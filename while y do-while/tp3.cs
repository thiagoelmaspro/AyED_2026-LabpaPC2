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
            int numero;
            int total = 0;

            do
            {
                Console.WriteLine("Ingrese un numero ");
                numero = int.Parse(Console.ReadLine());
                total = total + numero;

            } while (numero != 0);

            Console.WriteLine("Total acumulado : " + total);
        }
    }
}
