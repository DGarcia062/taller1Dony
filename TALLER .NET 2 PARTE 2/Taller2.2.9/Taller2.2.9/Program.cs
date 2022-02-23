using System;

namespace Taller2._2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera: si trabaja 40 horas o menos, se le pagará 10.000 la hora, si trabaja más de 40 horas, se le pagará 10.000 por las primeras 40 horas y 15.000 por cada hora extra");

            try
            {
                Console.WriteLine("Dame la cantidad de horas trabajadas: ");
                float horas = float.Parse(Console.ReadLine());
                

                if (horas <= 40)
                {
                    Console.WriteLine($"Su salarió es de {horas*10000}");
                }
                else
                {
                    float horasExtra = horas - 40;
                    Console.WriteLine($"Su salarió será de {(40*10000)+(horasExtra*15000)}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
