using System;

namespace Taller2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leer 4 notas, calcular el promedio e imprimir un mensaje indicando que reprobó en caso que la nota sea menor a 3.5");

            try
            {
                Console.WriteLine("Dame la primera nota: ");
                float nota1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la segunda nota: ");
                float nota2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la tercera nota: ");
                float nota3 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la cuarta nota: ");
                float nota4 = float.Parse(Console.ReadLine());

                float promedio = ((nota1 + nota2 + nota3 + nota4) / 4);

                if (promedio < 3.5)
                
                    Console.WriteLine($"Reprobaste con una nota de {promedio}");
                
                else
                
                    Console.WriteLine($"Aprobaste con una nota de {promedio}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
