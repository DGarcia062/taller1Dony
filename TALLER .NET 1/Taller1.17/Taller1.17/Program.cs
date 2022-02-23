using System;

namespace Taller1._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desarrollar un algoritmo que permita generar la colilla de pago de los empleados de una empresa. La colilla debe mostrar: El Salario del Empleado, el valor de ahorro mensual programado, la suma a deducir por aporte de la EPS(12,5%), la suma adeducir por aporte al fondo de pensiones (16%), Toda la información que debe proveer el usuario del programa es el  Salario del Empleado y el Valor de Ahorro mensual programado. El programa debe calcular y devolver el resto de los datos.");

            try
            {
                Console.WriteLine("Dame tu salario: ");
                float salario = float.Parse(Console.ReadLine());

                Console.WriteLine("Cuánto ahorras mensualmente en porcentaje?");
                float ahorro = float.Parse(Console.ReadLine());
                float porcentajeAhorro = ahorro / 100;
                float eps = (float)(salario * 0.125);
                float fondoPensiones = (float)(salario * 0.16);

                Console.WriteLine($"Su salario es {salario}, el valor de ahorro mensual programado es {salario * porcentajeAhorro}, su deducción de EPS es {eps} y su aporte al fondo de pensiones es {fondoPensiones}");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
