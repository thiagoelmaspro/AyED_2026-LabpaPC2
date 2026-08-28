using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Console.WriteLine("Contar Hasta: ");
            int numero = int.Parse(Console.ReadLine());
            ContarHasta(numero);

        }
        static void ContarHasta(int Numero)
        {
            for (i = 1; i <= Numero; i++)
            {
                Console.WriteLine("Excelente, Contando hasta: " + i);
            }
        }

    }
}
