using System;

namespace Taller1._15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suponga que tiene Ud. una tienda y desea registrar las ventas en una computadora. Diseñe un algoritmo en pseudocódigo que lea por cada cliente:El monto de la venta, calcule e imprima el IVA.          Calcule e imprima el total a pagar. Lea la cantidad con la que paga el cliente(solo efectivo), calcule e imprima el cambio");

            try
            {
                Console.WriteLine("¿Cual es el total de su compra?");
                float compra = float.Parse(Console.ReadLine());

                float iva = (float)(compra * 0.19);
                
                Console.WriteLine($"El iva de su compra es: {iva} \n El total a pagar con iva es: {compra+(compra*0.19)} ");

                Console.WriteLine("¿Con cuanto dinero en efectivo va a pagar?");
                float efectivo = float.Parse(Console.ReadLine());

                float cambio = efectivo - (compra + compra * 0.19f);

                Console.WriteLine($"Su cambio es: {cambio} ");
            }
            catch (Exception)
            {
                Console.WriteLine("Error, datos equivocados");
            }
        }
    }
}
    

