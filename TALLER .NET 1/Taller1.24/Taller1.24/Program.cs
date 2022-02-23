using System;

namespace Taller1._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Un estudiante realiza un préstamo a un plazo de 5 años, donde la tasa fija de interés es del 5% anual, se debe solicitar el monto del préstamo y se desea calcular la siguiente información.Cuanto dinero se ha pagado de intereses en un año.  Cuanto dinero se ha pagado de intereses en el tercer trimestre del año. Cuanto dinero se ha pagado de intereses en el primer mes. Cuanto dinero se paga en total del préstamo solicitado incluyendo intereses. ");



            try
            {
                float interesAnual = (float)(0.05);

                Console.WriteLine("A cuántos años va a pedir el préstamo: ");
                float agnios = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame el valor del préstamo: ");
                float prestamo = float.Parse(Console.ReadLine());

                float valorAnual = prestamo / agnios;
                
                Console.WriteLine($"En un año habrás pagado {valorAnual*interesAnual} de interés. En el tercer trimestre del año habrás pagado {((valorAnual*interesAnual)*9)/12} de interés. En el primer mes habrás pagado {((valorAnual*interesAnual)*1)/12} pesos de interés. En total pagarás {(interesAnual*agnios)*prestamo} de interés en {agnios} años");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
