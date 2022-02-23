using System;

namespace Taller1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dadas las 3 notas de un aprendiz, calcule la definitiva de la asignatura.");



            try
            {
                Console.WriteLine("Dame la primera nota: ");
                float nota1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la segunda nota: ");
                float nota2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la tercera nota: ");
                float nota3 = float.Parse(Console.ReadLine());

                Console.WriteLine($"Su nota definitiva es {(nota1+nota2+nota3)/3}");
                //Paréntesis, potencia, raíz, multi, div, suma y resta
            }   
            catch (Exception)
            {
                Console.WriteLine("Error, no ingresaste correctamente las notas");     
            }
        }
    }
}
