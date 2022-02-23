using System;

namespace Taller2._2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Una empresa desea hacer una compra de varias piezas de la misma clase a una fábrica. La empresa, dependiendo del valor de la compra, decidirá la forma en que le pagará al fabricante. Si el valor de la compra excede o es igual a $5.000.000, la empresa tendrá la capacidad de pagar con recursos propios el 55% del valor de la compra, pedirá prestado a un banco el 30% y el resto lo pagará solicitando un crédito al fabricante. Si el monto total de la compra no excede de $5.000.000, la empresa tendrá la capacidad de pagar con recursos propios un 70% y el 30% restante, lo pagará solicitando un crédito al fabricante. El fabricante cobra un 15% de interés sobre la cantidad que le pague a crédito.");

            try
            {
                Console.WriteLine("Dame el monto total de las piezas: ");
                float monto = float.Parse(Console.ReadLine());

                if (monto >= 5000000)
                {                  
                    float interesFabricante = (float)(monto * 0.15);
                    float interesFinal = (float)(interesFabricante * 0.15);
                  
                    Console.WriteLine($"Pagará {monto*0.55} con recursos propios, {monto*0.30} con un préstamo al banco y {monto*0.15} con un crédito al fabricante para un total de {monto + interesFinal}");
                }
                else
                {
                    float interesFabricante = (float)(monto * 0.30);
                    float interesFinal = (float)(interesFabricante * 0.15);

                    Console.WriteLine($"Pagará {monto * 0.70} con recursos propios y {monto * 0.30} con un crédito al fabricante para un total de {monto + interesFinal}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
