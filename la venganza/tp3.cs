using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        private static int i;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Dame el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Mostrar(numero1, numero2);


        }
        static void Mostrar(int Numero1, int Numero2)
        {
            int pares = 0;
            int impares = 0;
            int suma = 0;

            if ( Numero1 > Numero2)
            {
                int auxiliar = Numero1;
                Numero1 = Numero2;
                Numero2 = auxiliar;

            }
            for (i = Numero1; i <= Numero2; i++)
            {
                Console.WriteLine(i);
                suma += 0;
                if (i % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                suma = suma + i;
            
            }
            Console.WriteLine("La cantidad de numeros pares es: " + pares);
            Console.WriteLine("La cantidad de numeros impares es: " + impares);
            Console.WriteLine("La suma de todos los valores mostrados es de: " + suma);
        }
    }
}
