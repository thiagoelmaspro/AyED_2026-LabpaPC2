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
            Console.WriteLine("Cuenta Regresiva: ");
            int numero = int.Parse(Console.ReadLine());
            CuentaRegresiva(numero);

        }
        static void CuentaRegresiva(int Numero)
        {
            for (i = Numero; i >= 1; i-- )
            {
                Console.WriteLine("Cuenta regresiva con exito: " + i);
            }
        }
    
    }
}
