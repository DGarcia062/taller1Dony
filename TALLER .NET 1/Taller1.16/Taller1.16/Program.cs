using System;

namespace Taller1._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suponga que un conductor le pide a usted que le haga un algoritmo para calcular cuánto le corresponde en un día trabajado, teniendo en cuenta que tiene derecho a el 19% del total recaudado.");
            try
            {
                Console.WriteLine("Cuánto dinero recaudaste el día de hoy: ");
                float total = float.Parse(Console.ReadLine());

                Console.WriteLine($"Total recaudado es: {total * 0.19}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos invalidos");
            }
        }
    }
}
    
