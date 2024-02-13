using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            int n1,n2,n3,n4,minimo;
            Console.WriteLine("Ingrese 4 números por favor:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            // evaluo a todos los números entre sí INDIRECTAMENTE  
            if (n1 < n2)
                minimo = n1;
            else
                minimo = n2;
            if (n3 < minimo)
                minimo = n3;
            if (n4 < minimo)
                minimo = n4;
            Console.WriteLine("El menor de los numeros ingresados es el " + minimo);
        }
    }
}
