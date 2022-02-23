using System;

namespace Taller1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Un alumno desea saber cuál será su calificación final en la materia de Algoritmos. Dicha calificación se compone de los siguientes porcentajes: 55% del promedio de sus 3 calificaciones parciales, 30% de la calificación del examen final y 15% de la calificación de un trabajo final");

            try
            {
                Console.WriteLine("Dame la nota de tu parcial 1: ");
                float nota1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la nota de tu parcial 2: ");
                float nota2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la nota de tu parcial 3: ");
                float nota3 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la nota del examen final: ");
                float examenFinal = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la nota del trabajo final: ");
                float trabajoFinal = float.Parse(Console.ReadLine());

                Console.WriteLine($"Su calificación final es {((nota1+nota2+nota3)/3*0.55)+(examenFinal*0.3)+(trabajoFinal*0.15)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
