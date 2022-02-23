using System;

namespace Taller1._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Una persona tarda 5 horas en subir una montaña de 7 metros, si un escalador desea subir más o menos de la montaña, cuanto tiempo tarda en subir. Debe de resolver el ejercicio. ");

            try
            {
                int minutos = 43;

                Console.WriteLine("Cuántos metros de montaña subirás: ");
                float metros = float.Parse(Console.ReadLine());
                float horas = metros * (float)(minutos*0.0166667);

                Console.WriteLine($"Tardarás {metros*minutos} minutos en subir la montaña si vas a escalar {metros} metros. Equivalente a {horas} horas");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
