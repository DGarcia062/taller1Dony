using System;

namespace Taller1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suponga que un individuo desea invertir su capital en un banco y desea saber cuánto dinero ganará después de un mes si el banco paga a razón de 2% mensual.");

            try
            {
                Console.WriteLine("Cuánto es el monto a invertir: ");
                float capital = float.Parse(Console.ReadLine());
          

                Console.WriteLine($"Su ganancia en un mes {capital*0.02}, para un total de {capital+(capital*0.02)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, ingresaste mal los datos");               
            }
        }
    }
}
