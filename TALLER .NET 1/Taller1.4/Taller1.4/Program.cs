using System;

namespace Taller1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dadas las 3 notas de un aprendiz, calcule la definitiva de la asignatura si la primera nota tiene un valor del 20%, la segunda del 30% y la última del 50%.");

            try
            {
                Console.WriteLine("Dame la primera nota: ");
                float nota1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la segunda nota: ");
                float nota2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la tercera nota: ");
                float nota3 = float.Parse(Console.ReadLine());

                Console.WriteLine($"Su nota definitiva es: {(nota1*0.2)+(nota2*0.3)+(nota3*0.5)}");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error, ingresaste mal las notas");
                
            }
        }
    }
}
