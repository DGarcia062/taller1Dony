using System;

namespace Taller2._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinar el precio de un pasaje de ida y vuelta por avión, conociendo la distancia a recorrer y sabiendo que que esta es superior a 1.000 km, la línea aérea le hace un descuento del 30%. El precio por kilómetro es de $150.");

            try
            {
                Console.WriteLine("Dame la distancia a recorrer del avión: ");
                float distancia = float.Parse(Console.ReadLine());

                float precio = distancia * 150;

                if (distancia > 1000) Console.WriteLine($"Su valor a pagar es {precio - (precio * 0.3)}");

                else Console.WriteLine($"Su valor a pagar es {precio}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
