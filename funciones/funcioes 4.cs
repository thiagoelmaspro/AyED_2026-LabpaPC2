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
            int multiplicacion = 1;
            Console.WriteLine("Dame un numero y los multiplico entre todos: ");
            int numero = int.Parse(Console.ReadLine());
            SumarHasta(numero, multiplicacion);


        }
        static void SumarHasta(int Numero, int Multiplicacion)
        {
            for (i = 1; i <= Numero; i++)
            {


                Multiplicacion *= i;
                Console.WriteLine(i);

            }
            Console.WriteLine("La multiplicacion de los numeros es= " + Multiplicacion);
        }

    }
}
