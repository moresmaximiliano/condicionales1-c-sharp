using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // BLOQUE IF: Condicionales. Si edad > 30 desc 30%, si edad > 20 desc 21%, si edad = 18 desc 10%, si no es ninguna desc 5%
            int edad;
           Console.WriteLine("ingrese su edad por favor:");
           edad = int.Parse(Console.ReadLine());

            if(edad > 30)
                Console.WriteLine("30 OFF");
            else if(edad > 20)
                Console.WriteLine("21 OFF");
            else if(edad == 18)
                Console.WriteLine("10 OFF");
            else
                Console.WriteLine("5 OFF");
            
            Console.WriteLine("Fin del programa");
            
        
        }
    }
}
