using System;

namespace Taller2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000 o más. Determinar cuánto pagará, con IVA incluido (19%), un cliente si la compra cumple con esta condición.");

            try
            {
                Console.WriteLine("Dame el precio del computador: ");
                float precioPc = float.Parse(Console.ReadLine());

                if (precioPc >= 1000000)
                {                   
                    float descuento = (float)(precioPc * 0.10);
                    float iva = (float)(precioPc * 0.19);

                    Console.WriteLine($"El iva es de {iva} y su precio final será de {(precioPc-descuento)+iva}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
