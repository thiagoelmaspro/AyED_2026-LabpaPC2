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
            int suma = 0;
            Console.WriteLine("Sumar hasta: ");
            int numero = int.Parse(Console.ReadLine());
            SumarHasta(numero, suma);


        }
        static void SumarHasta(int Numero, int Suma)
        {
            for (i = 1; i <= Numero; i++)
            {


                Suma += i;
                Console.WriteLine(i);

            }
            Console.WriteLine("La suma de los numeros es= " + Suma);
        }

    }
}
