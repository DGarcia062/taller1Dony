using System;

namespace Taller2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realizar un algoritmo que lea dos números e imprima la suma de los 2, en caso que el primero sea mayor al segundo");

            try
            {
                Console.WriteLine("Dame número 1: ");
                float numero1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame número 2: ");
                float numero2 = float.Parse(Console.ReadLine());

                if (numero1 > numero2)
                
                    Console.WriteLine($"Su suma es {numero1+numero2}");
                    
                 else
                
                    Console.WriteLine("El primero no es mayor o son iguales");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
                
            }
        }
    }
}
