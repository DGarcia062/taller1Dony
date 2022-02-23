using System;

namespace Taller2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacer un algoritmo que calcule el total a pagar por la compra de camisas. Si se compran tres camisas o más se aplica un descuento del 20% sobre el total de la compra y si son menos de tres camisas un descuento del 10%");

            try
            {
                bool i = true;
                int contCamisas = 0;
                float contPrecio = 0;

                while (i == true)
                {
                    Console.WriteLine("Inserte precio de la camisa: ");
                    float precio = float.Parse(Console.ReadLine());

                    contCamisas++;

                    contPrecio = contPrecio + precio;

                    Console.WriteLine("Vas a comprar más camisas? (sí) (no)");
                    string compra = Console.ReadLine();

                    if (compra != "sí")
                    {
                        break;
                    }
                }
                if (contCamisas >= 3)
                {
                    contPrecio = (float)(contPrecio - (contPrecio * 0.2));
                    Console.WriteLine($"Compraste más de 3 camisas, recibes un descuento del 20% y pagarás {contPrecio}");
                    
                } else
                {
                    contPrecio = (float)(contPrecio - (contPrecio * 0.1));
                    Console.WriteLine($"Compraste menos de 3 camisas, recibes descuento del 10% para un total del {contPrecio}");
                }
                



            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
