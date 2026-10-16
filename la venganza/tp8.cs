using System;

class Program
{
    static void Main(string[] args)
    {
        int numero1, numero2;

        Console.WriteLine("Ingrese un numero:");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese otro numero:");
        numero2 = int.Parse(Console.ReadLine());

        MostrarPrimos(numero1, numero2);
    }

    static void MostrarPrimos(int Numero1, int Numero2)
    {
        int cantidad = 0;
        int primo;

        if (Numero1 > Numero2)
        {
            int aux = Numero1;
            Numero1 = Numero2;
            Numero2 = aux;
        }

        for (int i = Numero1; i <= Numero2; i++)
        {
            primo = 1;

            if (i < 2)
            {
                primo = 0;
            }
            else
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primo = 0;
                    }
                }
            }

            if (primo == 1)
            {
                Console.WriteLine(i);
                cantidad++;
            }
        }

        Console.WriteLine("Cantidad de numeros primos: " + cantidad);
    }
}

