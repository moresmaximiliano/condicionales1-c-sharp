using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
            int n1,n2,n3,n4;
            Console.WriteLine("Ingrese 4 números:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            if (n1 > 100)
                Console.WriteLine(n1 + " es mayor a 100");
            if (n2 > 100)
                Console.WriteLine(n2 + " es mayor a 100");
            if (n3 > 100)
                Console.WriteLine(n3 + " es mayor a 100");
            if (n4 > 100)
                Console.WriteLine(n4 + " es mayor a 100");
        }
    }
}
