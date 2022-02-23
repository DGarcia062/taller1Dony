using System;

namespace Taller2._15
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo");
            try
            {
                Console.WriteLine("Dame el número de sueldos: ");
                int cantidadSueldos = int.Parse(Console.ReadLine()); 

                int i = 0;
                float max = 0;

                while (i < cantidadSueldos)
                {
                    Console.WriteLine("Dame el sueldo: ");
                    float sueldo = float.Parse(Console.ReadLine()); 

                    i++;

                    if (sueldo > max) max = sueldo;
                }
                Console.WriteLine($"El sueldo máximo es {max}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}




