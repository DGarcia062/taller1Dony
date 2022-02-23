using System;

namespace Taller1._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realice un algoritmo que permita realizar el cálculo del siguiente enunciado, se solicita el año de nacimiento del aprendiz, el nombre, la dirección, se requiere conocer la edad de la persona y la información completa ingresada. ");

            try
            {
                int agnioActual = 2022;
                Console.WriteLine("Dame tu nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Dame tu año de nacimiento: ");
                int agnio = int.Parse(Console.ReadLine());

                Console.WriteLine("Dame tu adirección: ");
                string direccion= Console.ReadLine();

                Console.WriteLine($"El aprendiz {nombre}, con dirección {direccion}, nacido en el año {agnio}, tiene una edad de {agnioActual-agnio} años");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
