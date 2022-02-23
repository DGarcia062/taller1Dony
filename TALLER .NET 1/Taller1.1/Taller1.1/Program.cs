using System;

namespace Taller1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lea tres números y calcule el resultado de su suma.");

            try
            {
                Console.WriteLine("Dame el valor del número 1: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Dame el valor del número 2: ");
                int numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Dame el valor del número 3: ");
                int numero3 = int.Parse(Console.ReadLine());

                Console.WriteLine($"El resultado de su suma es {numero1+numero2+numero3}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, no ingresaste un número");               
            }


            


        }
    }
}
