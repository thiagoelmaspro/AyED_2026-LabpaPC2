using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            int saldo = 10000;
            int opcion = 0;
            int dinero;

            while (opcion != 4)
            {
                Console.WriteLine("CAJERO AUTOMATICO ");
                Console.WriteLine("1-Depositar dinero ");
                Console.WriteLine("2-Retirar dinero ");
                Console.WriteLine("3-Ver saldo actual ");
                Console.WriteLine("4-Salir ");
                Console.Write("Elija una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)

                {
                    case 1:

                        Console.Write("Ingrese el dinero a depositar ");
                        dinero = int.Parse(Console.ReadLine());
                        saldo = saldo + dinero;
                        Console.WriteLine("Deposito realizado");
                        break;

                    case 2:


                        Console.WriteLine("Ingrese el dinero a retirar ");
                        dinero = int.Parse(Console.ReadLine());
                        saldo = saldo - dinero;
                        Console.WriteLine("Dinero retirado con exito ");
                        break;




                    case 3:
                        Console.WriteLine("El dinero actual es de $" + saldo );
                        break;



                    case 4:
                        Console.WriteLine("Saliendo del cajero... ");
                        break;






                }




            }



            
        }
    }
}
