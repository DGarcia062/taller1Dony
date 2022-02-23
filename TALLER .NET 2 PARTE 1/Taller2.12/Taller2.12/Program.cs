using System;

namespace Taller2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacer un algoritmo que lea la estatura de una persona y si es mayor de 1.70, imprima que es alta");

            try
            {
                Console.WriteLine("Dame tu estarura: ");
                float estatura = float.Parse(Console.ReadLine());

                if (estatura > 1.70)
                
                    Console.WriteLine("Eres alto/a");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
