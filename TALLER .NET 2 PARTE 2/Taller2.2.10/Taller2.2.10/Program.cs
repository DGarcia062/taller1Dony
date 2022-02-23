using System;

namespace Taller2._2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Una persona enferma y cuyo peso es 70 kg, se encuentra en reposo y desea saber cuántas calorías consume su cuerpo durante el tiempo que realice una misma actividad. Las actividades que puede realizar son únicamente dormir o estar sentado. Los datos que tiene son que estando dormido consume 1.08 calorías por minuto y estando sentado en reposo consume 1.66 calorías por minuto.");

            try
            {
                Console.WriteLine("Qué actividad realizaste? (dormir)o(sentado)");
                string actividad = Console.ReadLine();

                if(actividad == "dormir")
                {
                    Console.WriteLine("Cuántas horas dormiste? ");
                    float horas = float.Parse(Console.ReadLine());

                    float minutos = horas * 60;

                    Console.WriteLine($"Consumiste un total de {minutos*1.08} calorías");
                }
                else
                {
                    Console.WriteLine("Cuántas horas dormiste? ");
                    float horas = float.Parse(Console.ReadLine());

                    float minutos = horas * 60;

                    Console.WriteLine($"Consumiste un total de {minutos * 1.66} calorías");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
