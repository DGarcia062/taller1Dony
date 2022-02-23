using System;

namespace Taller1._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dada las horas trabajadas de una persona y el valor por hora. Calcular su salario e imprimirlo. ");

            try
            {
                Console.WriteLine("Dame las horas trabajadas: ");
                float horas = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame el valor por hora: ");
                float valorHoras = float.Parse(Console.ReadLine());

                Console.WriteLine($"Su salario total es de {horas * valorHoras}");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos"); 
            }
        }
    }
}
