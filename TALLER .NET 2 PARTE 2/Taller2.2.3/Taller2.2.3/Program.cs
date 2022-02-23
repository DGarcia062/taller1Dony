using System;

namespace Taller2._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elabore un algoritmo que lea un número y si este es mayor o igual a 10 devuelva el triple de este de lo contrario la cuarta parte de este.");

            try
            {
                Console.WriteLine("Dame un número: ");
                float numero = float.Parse(Console.ReadLine());

                if (numero >= 10)
                
                    Console.WriteLine($"Su resultado es {numero*3}");
                else
                
                    Console.WriteLine($"Su resultado es {numero/4}");              
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
