using System;

namespace Taller2._2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En un almacén se hace un 17% de descuento a los clientes cuya compra sea superior a $200.000, para las compras inferiores, el descuento será del 5%. ¿Cuánto deberá pagar cada cliente?");

            try
            {
                Console.WriteLine("Dame el valor de tu compra: ");
                float compra = float.Parse(Console.ReadLine());

                if (compra > 200000)
                {
                    Console.WriteLine($"Su compra queda en {compra-(compra*0.17)}$");
                }
                else
                {
                    Console.WriteLine($"Su compra queda en {compra - (compra * 0.05)}$");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
