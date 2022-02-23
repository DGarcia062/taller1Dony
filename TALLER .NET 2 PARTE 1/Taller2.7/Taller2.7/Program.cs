using System;

namespace Taller2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leer un número e imprimir un mensaje en caso que sea negativo.");

            try
            {
                Console.WriteLine("Dame un número: ");
                float numero = float.Parse(Console.ReadLine());

                if (numero < 0) Console.WriteLine("Negativo");
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
