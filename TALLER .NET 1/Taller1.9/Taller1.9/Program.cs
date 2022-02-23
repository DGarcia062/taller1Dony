using System;

namespace Taller1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas, el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes y el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones.");

            try
            {
                Console.WriteLine("Dame tu sueldo base: ");
                float sueldo = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame el valor de la primera venta: ");
                float venta1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame el valor de la segunda venta: ");
                float venta2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame el valor de la tercera venta: ");
                float venta3 = float.Parse(Console.ReadLine());

                Console.WriteLine($"Su sueldo base este mes más comisiones es de {sueldo + (venta1*0.1)+(venta2*0.1)+(venta3*0.1)}");




            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
