using System;

namespace Taller1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lea la distancia (en kilómetros) recorrida por un auto, el tiempo (en horas) en que la recorrió y calcule la velocidad a la cual se desplazaba el auto (V=D/T).");

            try
            {
                Console.WriteLine("Dame la distancia en kilómetros: ");
                float distancia = float.Parse(Console.ReadLine());                 

                Console.WriteLine("Dame el tiempo en horas: ");
                float tiempo = float.Parse(Console.ReadLine());

                Console.WriteLine($"La velocidad a la cual se desplazaba el auto era de {distancia/tiempo} km/h");
            }
            catch (Exception)
            {
                Console.WriteLine("Error, ingresaste valores erróneos");                
            }
        }
    }
}
