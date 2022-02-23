using System;

namespace Taller1._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se tienen tres baldes de agua, uno de cinco litros, otros de tres litros y otro de un litro; si el de un litro tarda una hora y media en llenarse, resuelva cuanto tiempo pueden tardar en llenarse los otros baldes. Si tiene tres baldes, pero se desconoce su tamaño debe de resolver igualmente el ejercicio");

            try
            {

                float litro = 90;

                Console.WriteLine("Dame la capacidad del balde 1: ");
                float balde1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la capacidad del balde 2: ");
                float balde2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la capacidad del balde 3: ");
                float balde3 = float.Parse(Console.ReadLine());

                Console.WriteLine($"El primer balde se demorará {litro*balde1} minutos en llenarse, el segundo balde se demorará {litro*balde2} minutos en llenarse y el tercer balde se demorará {litro*balde3} minutos en llenarse");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
