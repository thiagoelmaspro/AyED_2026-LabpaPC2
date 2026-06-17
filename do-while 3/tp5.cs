using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int creditos = 100;
            int apuesta = 1;
            int dado1;
            int dado2;
            int suma;

            do
            {
                Console.WriteLine("Creditos disponibles: " + creditos);
                Console.Write("ingrese una apuesta(0 para terminar) ");
                apuesta = int.Parse(Console.ReadLine());

                if (apuesta <= 0 || apuesta > creditos)
                {
                    Console.WriteLine("ERROR");
                    break;

                }
                else if ( apuesta > 0 || apuesta < creditos)
                {
                    Console.Write("Dado 1: ");
                    dado1 = int.Parse(Console.ReadLine());

                    Console.Write("Dado 2:");
                    dado2 = int.Parse(Console.ReadLine());

                    suma = dado1 + dado2;

                    if (suma == 7 || suma == 11)
                    {
                        apuesta = apuesta * 2;
                        creditos = creditos + apuesta;
                        Console.WriteLine("GANASTE");

                    }
                    else
                    {
                        creditos = creditos - apuesta;
                        Console.WriteLine("Perdiste");

                    }


                }

            } while (creditos > 0 || apuesta > 0  );
            Console.WriteLine("Saldo final: " + creditos);
        }
    }

}



