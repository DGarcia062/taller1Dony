using System;

namespace Taller2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular el salario de un empleado, teniendo en cuenta que si el salario bruto es superior a $2.000.000, debe hacerse una retención del 10%.");

            try
            {
                Console.WriteLine("Dame tu salario: ");
                float salario = float.Parse(Console.ReadLine());

                if (salario > 2000000)
                
                    Console.WriteLine($"Su salario bruto es mayor a 2,000,000, por ende se le hace retención del 10%, para un total de {salario-(salario*0.1)}");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
