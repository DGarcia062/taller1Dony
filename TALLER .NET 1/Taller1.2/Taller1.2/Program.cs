using System;

namespace Taller1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lea dos números y calcule el resultado de su suma, resta, multiplicación y división.");

            try
            {
                Console.WriteLine("Dame el valor del número 1: ");
                float numero1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame el valor del número 2: ");
                float numero2 = float.Parse(Console.ReadLine());

                Console.WriteLine($"El resultado de su suma es {numero1+numero2}, el resultado de su resta es {numero1-numero2}, el resultado de su multiplicación es {numero1*numero2} y el resultado de su división es {numero1/numero2}");             
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, no ingresaste números");                
            }
        }
    }
}
