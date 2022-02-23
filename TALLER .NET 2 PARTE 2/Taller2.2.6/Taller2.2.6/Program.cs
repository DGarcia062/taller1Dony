using System;

namespace Taller2._2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular e imprimir el salario de un empleado, teniendo en cuenta que si el salario bruto es igual o superior a $2.000.000, debe hacerse una retención del 10%, si el salario es inferior, la retención será del 3%.");

            try
            {
                Console.WriteLine("Dame tu salario: ");
                float salario = float.Parse(Console.ReadLine());

                if (salario >= 2000000) Console.WriteLine($"Su salario total es de {salario - (salario * 0.10)}");

                else Console.WriteLine($"Su salario total es de {salario - (salario * 0.03)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
