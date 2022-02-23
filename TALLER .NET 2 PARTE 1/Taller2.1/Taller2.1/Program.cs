using System;

namespace Taller2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leer un número e imprimir un mensaje en caso que sea par.");

            try
            {
                Console.WriteLine("Dame un número: ");
                float numero = float.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                
                    Console.WriteLine("Par");
                
                else
                
                    Console.WriteLine("Impar");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
                
            }
        }
    }
}
