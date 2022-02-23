using System;

namespace Taller1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente desea saber cuánto deberá pagar finalmente por su compra.");

            try
            {
                Console.WriteLine("Dame el valor de la compra: ");
                float compra = float.Parse(Console.ReadLine());

                float descuento = (float)(compra * 0.15);

                Console.WriteLine($"El valor final de su compra con el descuento del 15% es de {compra-descuento}");


            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
