using System;

namespace Taller2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original y su precio con descuento. El descuento lo hace en base a la clave, si la clave es 01 el descuento es del 10% y si la clave es 02 el descuento es del 20% (solo existen dos claves).");

            try
            {
                Console.WriteLine("Nombre: PC");
                float clave = 01;
                float precioOriginal = 1000000;

                if (clave == 01) Console.WriteLine($"Precio con descuento: {precioOriginal - (precioOriginal * 0.1)}");

                Console.WriteLine("Nombre: PC");
                float clave2 = 02;
                float precioOriginal2 = 1000000;

                if (clave2 == 02) Console.WriteLine($"Precio con descuento: {precioOriginal2 - (precioOriginal2 * 0.2)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
