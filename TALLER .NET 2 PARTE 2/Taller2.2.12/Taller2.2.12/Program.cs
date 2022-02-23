using System;

namespace Taller2._2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elaborar un algoritmo que permita calcular el valor total a pagar en una papelería teniendo en cuenta que, si lleva 5 cuadernos o más, se le cobrarán $2.000 por cada uno, mientras que, si lleva menos, se le cobrarán $2.500 por cada uno.");

            try
            {
                Console.WriteLine("Cuántos cuadernos vas a llevar: ");
                int cuadernos = int.Parse(Console.ReadLine());

                if (cuadernos >= 5)
                {
                    Console.WriteLine($"Su total a pagar será de {cuadernos*2000}");
                }
                else
                {
                    Console.WriteLine($"Su total a pagar será de {cuadernos*2500}");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
