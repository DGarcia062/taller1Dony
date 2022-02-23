using System;

namespace Taller2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elabore un algoritmo que lea un número y si este es mayor o igual a 10 devuelva el triple de este.");

            try
            {
                Console.WriteLine("Dame el número: ");
                float numero = float.Parse(Console.ReadLine());

                if (numero >= 10)
                
                    Console.WriteLine($"El resultado es {numero*3}");
                else
                
                    Console.WriteLine("No es mayor o igual a 10");
                
                
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
            

        }
    }
}
