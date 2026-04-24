using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime la temperatura ");
            float temperatura = Convert.ToInt32(Console.ReadLine());
            if (temperatura < 0)
            {
                Console.WriteLine("Peligro de congelamiento ");

            }
            else if (temperatura <= 15)
            {
                Console.WriteLine("Mucho frio ");

            }
            else
                Console.WriteLine("Clima agradable ");
        }
    }
}
