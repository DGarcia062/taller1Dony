using System;

namespace Taller2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realizar un algoritmo que lea un número y si éste es superior o igual a 10, permita imprimir su cubo.");

            try
            {
                Console.WriteLine("Dame el número: ");
                float numero = float.Parse(Console.ReadLine());

                if (numero >= 10)
                {
                    float elevar = (float)Math.Pow(numero, 3);
                    Console.WriteLine($"Su cubo es {elevar}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
