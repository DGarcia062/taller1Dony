using System;

namespace Taller2._2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elaborar un algoritmo que permita calcular el número de pulsaciones que debe tener una persona por cada 10 segundos de ejercicio aeróbico; la fórmula que se aplica cuando el sexo es femenino, es: numpulsaciones = (220-edad)/10 y si es masculino es numplsaciones (210-edad)/10 ");

            try
            {
                Console.WriteLine("Dame tu género: (M) o (F)");
                string genero = Console.ReadLine();

                if (genero == "M")
                {
                    Console.WriteLine("Dame tu edad: ");
                    int edad = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Tus pulsaciones deberían ser {(220-edad)/10}");
                }
                else 
                {
                    Console.WriteLine("Dame tu edad: ");
                    int edad = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Tus pulsaciones deberían ser {(220-edad)/10}");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }

    }
}
