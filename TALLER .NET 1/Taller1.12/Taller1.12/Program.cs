using System;

namespace Taller1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Un maestro desea saber qué porcentaje de hombres y qué porcentaje de mujeres hay en un grupo de alumnos.");

            try
            {
                Console.WriteLine("Cuántas mujeres hay en el salón: ");
                int mujeres = int.Parse(Console.ReadLine());

                Console.WriteLine("Cuántos manes hay en el salón: ");
                int manes = int.Parse(Console.ReadLine());

                int total = (int)(mujeres + manes);

                Console.WriteLine($"El porcentaje de mujeres es {(mujeres*100)/total}% y el porcentaje de manes es {(manes * 100)/total}% para un total de {total} alumnos");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
