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
            Console.WriteLine("Dame un numero: ");
            int numero = int.Parse(Console.ReadLine());

            Capicua(numero);
        }

        static void Capicua(int Numero)
        {
            int original = Numero;
            int invertido = 0;
            int digitos = 0;

            while (Numero > 0)
            {
                int resto = Numero % 10;
                invertido = invertido * 10 + resto;
                Numero = Numero / 10;
                digitos++;
            }

            if (original == invertido)
            {
                Console.WriteLine("El numero es capicua");
            }
            else
            {
                Console.WriteLine("El numero no es capicua");
            }

            Console.WriteLine("Cantidad de digitos: " + digitos);
        }
    }
}