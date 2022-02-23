using System;

namespace Taller1._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suponga que tiene Ud. una tienda y desea registrar las ventas en una computadora. Diseñe un algoritmo en pseudocódigo que lea por cada cliente: El monto de la venta, calcule e imprima el IVA, calcule e imprima el monto a pagar y lea la cantidad con la que paga el cliente (solo efectivo) e imprima el cambio");


            try
            {
                bool i = true;
                float cont = 0;

                while (i == true)
                {
                    Console.WriteLine("Bienvenido, dame el valor de tu compra\n");

                    float compra = float.Parse(Console.ReadLine());

                    cont = compra + cont;

                    Console.WriteLine("Deseas registrar otra compra? (sí)(no)");
                    string registrar = Console.ReadLine();

                    if(registrar != "sí")
                    {
                        break;
                    }                   

                }
                Console.WriteLine($"El valor total de su compra es {cont}");
            } 
            
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");              
            }
            
        }
        
    }
}
