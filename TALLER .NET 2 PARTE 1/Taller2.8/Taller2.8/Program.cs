using System;

namespace Taller2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Un hombre desea saber cuánto dinero se genera por concepto de intereses sobre la cantidad que tiene en inversión en el banco. El decidirá reinvertir los intereses siempre y cuando no excedan a $7000, y en ese caso desea saber cuánto dinero tendrá finalmente en su cuenta.");

            try
            {
                Console.WriteLine("Dame tu cantidad en el banco: ");
                float cantidad = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la tasa de interes: ");
                float tasa = float.Parse(Console.ReadLine());

                float interes = cantidad * tasa;

                if (interes > 7000)
                
                    Console.WriteLine("La cantidad generada por concepto de interés es mayor a 7000");
                
                else
                
                    Console.WriteLine("La cantidad generada por concepto de interés es menor a 7000");
                
                Console.WriteLine($"Su saldo final es de {cantidad+interes}");

            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
