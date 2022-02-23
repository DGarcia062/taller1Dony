using System;

namespace Taller1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se trata de escribir el algoritmo que permita emitir la factura correspondiente a una compra de varios artículos (4) determinados, del que se adquieren una o varias unidades. El IVA es del 19%.");
            try
            {
                Console.WriteLine("Valor articulo 1");
                float articulo1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Valor articulo 2");
                float articulo2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Valor articulo 3");
                float articulo3 = float.Parse(Console.ReadLine());

                Console.WriteLine("Valor articulo 4");
                float articulo4 = float.Parse(Console.ReadLine());

                float iva = ((float)((articulo1 + articulo2 + articulo3
                    + articulo4) * 0.19));

                Console.WriteLine($"El total con IVA incluido es: {articulo1 + articulo2 + articulo3 + articulo4 + iva}");

            }
            catch (Exception e)
            {

                Console.WriteLine("Error, " + e.Message);
            }
        }
    }
}
