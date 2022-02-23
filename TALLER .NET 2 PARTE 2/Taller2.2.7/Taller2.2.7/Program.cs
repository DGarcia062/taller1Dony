using System;

namespace Taller2._2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leer un número e imprimir un mensaje si es par o impar.");

            try
            {
                Console.WriteLine("Dame un número: ");
                float numero = float.Parse(Console.ReadLine());

                if (numero % 2 != 0) Console.WriteLine("Impar");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
