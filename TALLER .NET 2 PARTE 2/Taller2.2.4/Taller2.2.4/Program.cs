using System;

namespace Taller2._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacer un algoritmo que lea dos números y los imprima en orden ascendente.");

            try
            {
                Console.WriteLine("Dame el número 1: ");
                float numero1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame el número 2: ");
                float numero2 = float.Parse(Console.ReadLine());

                if (numero1 > numero2)
                {
                    Console.WriteLine(numero2);
                    Console.WriteLine(numero1);
                }
                else
                {
                    Console.WriteLine(numero1);
                    Console.WriteLine(numero2);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
