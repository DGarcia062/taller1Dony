using System;

namespace Taller1._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("18.	En una universidad los estudiantes pueden pagar el valor de su matrícula en cuatro cuotas de la siguiente forma: primera cuota 40%, segunda cuota 25%, tercera cuota 20%, cuarta cuota 15% Diga cuanto es el valor que tiene que pagar por cuota un estudiante.");

            try
            {
                Console.WriteLine("Dame el valor de tu matrícula: ");
                float matricula = float.Parse(Console.ReadLine());

                Console.WriteLine($"Su primera cuota es de {matricula*0.40}, la segunda es de {matricula*0.25}, la tercera es de {matricula*0.20} y la cuarta es de {matricula*0.15}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
