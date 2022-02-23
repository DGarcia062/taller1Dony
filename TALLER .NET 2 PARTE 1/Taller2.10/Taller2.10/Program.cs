using System;

namespace Taller2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leer la edad de una persona e imprimir un mensaje en caso que sea mayor de edad.");

            try
            {
                Console.WriteLine("Dame tu edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad>=18) Console.WriteLine("Eres mayor de edad");

                else Console.WriteLine ("Eres menor de edad");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
