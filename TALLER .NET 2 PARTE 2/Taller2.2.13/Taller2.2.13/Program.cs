using System;

namespace Taller2._2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Una constructora ofrece vivienda de interés social, bajo las siguientes condiciones: Si los ingresos del comprador son iguales o superiores a $1.200.000, la cuota inicial será del 15% del valor de la vivienda y el resto, se distribuirá en 120 cuotas mensuales con un interés del 2% mensual. Si los ingresos del comprador son inferiores a $1.200.000, la cuota inicial será del 30% del valor de la vivienda y el resto, lo distribuirá en 84 cuotas mensuales con un interés del 1% mensual. La constructora desea saber cuánto debe pagar un comprador por concepto de cuota inicial y cuánto por cada cuota mensual.");

            try
            {

                Console.WriteLine("Dame el valor de la vivienda: ");
                float valor= float.Parse(Console.ReadLine());

                Console.WriteLine("Dame tus ingresos: ");
                float ingresos = float.Parse(Console.ReadLine());

                if (ingresos >= 1200000)
                {
                    float cuotaInicial = (float)(valor * 0.15);
                    float valorACuotas = valor - cuotaInicial;
                    float cuotasFinales = valorACuotas / 120;
                    
                    Console.WriteLine($"Usted debe pagar {cuotaInicial} como cuota inicial, y 120 cuotas mensuales de {(cuotasFinales)+(cuotasFinales*0.02)}");
                }
                else
                {
                    float cuotaInicial = (float)(valor * 0.30);
                    float valorACuotas = valor - cuotaInicial;
                    float cuotasFinales = valorACuotas / 84;

                    Console.WriteLine($"Usted debe pagar {cuotaInicial} como cuota inicial, y 84 cuotas mensuales de {(cuotasFinales) + (cuotasFinales * 0.01)}");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
