using System;

namespace Taller2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En un almacén se hace un 20% de descuento a los clientes cuya compra sea superior a $100.000. ¿Cuánto deberá pagar cada cliente?");

            try
            {
                Console.WriteLine("Dame el valor de tu compra: ");
                float compra = float.Parse(Console.ReadLine());

                if (compra > 100000)
                
                    Console.WriteLine($"Su factura final es de {compra-(compra*0.2)}");
                
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
