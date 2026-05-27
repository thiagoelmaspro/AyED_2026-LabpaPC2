using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura;

            Console.Write("Ingrese la temperatura inicial: ");
            temperatura = int.Parse(Console.ReadLine());

            do
            {
                temperatura = temperatura - 2;
                Console.WriteLine("Enfriando... Temperatura actual: " + temperatura + "°C");

            } while (temperatura > 24);

            Console.WriteLine("Temperatura ideal alcanzada");

        }
    }
}
