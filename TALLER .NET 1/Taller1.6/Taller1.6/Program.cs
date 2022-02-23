using System;

namespace Taller1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lea la cantidad de dinero correspondiente a una compra y calcule el valor del IVA (19%), y el valor total de la factura, si al valor de la compra se le autoriza un descuento del 10% (antes de aplicarle el IVA).");

            try
            {
                Console.WriteLine("Dame el monto de la compra: ");
                float compra = float.Parse(Console.ReadLine());

                float iva = (float)(compra * 0.19);

                Console.WriteLine($"El total del iva es {iva} y el valor total de la factura con IVA incluido es de {compra + iva}$");

                float descuento = (float)(compra * 0.1); 
                float iva2 = (float)(descuento * 0.19);

                Console.WriteLine($"Si se le autoriza descuento del 10%, su compra quedará en {compra - (descuento+iva2)}$");
                          }
            catch (Exception)
            {
                Console.WriteLine("Error, ingresaste mal los datos");               
            }
        }
    }
}
