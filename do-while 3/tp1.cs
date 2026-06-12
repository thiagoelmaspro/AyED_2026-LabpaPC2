using System;

class Program
{
    static void Main()
    {
        double precio;
        double subtotal = 0;
        double descuento = 0;
        double total;

        Console.Write("Ingrese un precio (0 para terminar): ");
        precio = double.Parse(Console.ReadLine());

        while (precio != 0)
        {
            subtotal = subtotal + precio;

            Console.Write("Ingrese un precio (0 para terminar): ");
            precio = double.Parse(Console.ReadLine());
        }

        if (subtotal > 15000)
        {
            descuento = subtotal * 0.10;
        }

        total = subtotal - descuento;

        Console.WriteLine("Subtotal: " + subtotal);
        Console.WriteLine("Descuento: " + descuento);
        Console.WriteLine("Total a pagar: " + total);
    }
}
