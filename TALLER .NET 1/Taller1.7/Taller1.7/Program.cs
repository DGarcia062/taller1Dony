using System;

namespace Taller1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dada una cantidad de tiempo medida en horas, minutos y segundos, diga a cuántos segundos equivale.");


            try
            {
                Console.WriteLine("Dame las horas: ");
                float horas = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame los minutos: ");
                float minutos = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame los segundos: ");
                float segundos = float.Parse(Console.ReadLine());

                Console.WriteLine($"El total de horas, minutos y segundos convertido a segundos es de {(horas * 3600)+(minutos * 60)+segundos}");

            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }

           


        }
    }
}
