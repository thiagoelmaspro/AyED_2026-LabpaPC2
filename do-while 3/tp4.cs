using System;

class Program
{
    static void Main()
    {
        int numero;
        int menor = 0;

        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());

        if (numero >= 0)
        {
            menor = numero;
        }

        while (numero >= 0)
        {
            if (numero < menor)
            {
                menor = numero;
            }

            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("El número menor es: " + menor);
    }
}