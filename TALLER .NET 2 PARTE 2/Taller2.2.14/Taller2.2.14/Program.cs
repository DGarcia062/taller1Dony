using System;

namespace Taller2._2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elaborar un algoritmo que lea un número, si es par, que imprima el cubo y si es impar, que imprima el triple.");

            try
            {
                Console.WriteLine("Dame un número: ");
                float numero = float.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    double cubo = Math.Pow(numero, 3);
                    Console.WriteLine($"Su número es par y el cubo es {cubo}");
                } else
                {
                    Console.WriteLine($"Su número es impar, y su triple es {numero*3}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
