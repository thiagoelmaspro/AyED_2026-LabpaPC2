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
            int base_ = 2;
            Console.WriteLine("Dame un numero y te digo la potencia: ");
            int exponente = int.Parse(Console.ReadLine());
            SumarHasta(exponente, base_);


        }
        static void SumarHasta(int exponentee, int basee_)
        {
            for (i = 1; i <= basee_; i++)
            {


                exponentee *= i;
                Console.WriteLine(i);

            }
            Console.WriteLine("La potencia seria= " + exponentee);
        }

    }
}
