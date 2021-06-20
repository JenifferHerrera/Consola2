using System;

namespace MiPrimerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola Mundo");

            if (args != null && args.Length > 0)
            {
                Console.WriteLine($"Hay" + args.Length + "Argumentos");
                Console.WriteLine($"Tu nombre es: " + args[0]);
                Console.WriteLine($"Tu apellido es: " + args[1]);
            }
            else
                Console.WriteLine("No hay Argumentos");
        }
    }
}
