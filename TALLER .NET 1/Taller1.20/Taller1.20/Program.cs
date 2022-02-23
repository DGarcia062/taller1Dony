using System;

namespace Taller1._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el precio de compra unitario de un producto y la cantidad de compra de dicho producto y un descuento. Calcular y mostrar el subtotal, el monto del IVA que es el 19% del subtotal, y el precio neto (precio parcial con el Monto del IVA).");

            try
            {
                Console.WriteLine("Dame el precio de la compra: ");
                float compra = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la cantidad de compra: ");
                float cantidadCompra = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame el descuento: ");
                float descuentoCompra= float.Parse(Console.ReadLine());

                descuentoCompra = descuentoCompra / 100;
                float descuentoFinal = compra * descuentoCompra;
                float subtotal = (float)(compra - (compra * 0.19));
                float final = subtotal * cantidadCompra;

                Console.WriteLine($"El subtotal de su compra es {final}, con un IVA igual a {final*0.19} y un precio NETO de {final+(final*0.19)}. Usted debe pagar {final+(final*0.19)+descuentoFinal}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }


        }
    }
}
