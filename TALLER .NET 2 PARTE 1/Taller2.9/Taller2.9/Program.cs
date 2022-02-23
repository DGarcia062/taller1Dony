using System;

namespace Taller2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leer un número e imprimir un mensaje en caso que sea múltiplo de 5.");

            try
            {
                Console.WriteLine("Dame el número: ");
                float numero = float.Parse(Console.ReadLine());

                if (numero % 5 == 0)
                
                    Console.WriteLine("Múltiplo de 5");
                else
                
                    Console.WriteLine("No es múltiplo de 5");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
