using System;

namespace Taller1._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar, para un estudiante, sus 5 notas de un curso, nombre, programa, ficha.  Hacer un algoritmo que: muestre el nombre, muestre programa de formación mostrar y calcular promedio final");

            try
            {
                Console.WriteLine("Dame tu nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Dame tu programa: ");
                string programa = Console.ReadLine();

                Console.WriteLine("Dame tu ficha: ");
                float ficha = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la primera nota: ");
                float nota1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la segunda nota: ");
                float nota2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la tercera nota: ");
                float nota3 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la cuarta nota: ");
                float nota4 = float.Parse(Console.ReadLine());

                Console.WriteLine("Dame la quinta nota: ");
                float nota5 = float.Parse(Console.ReadLine());

                float promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

               Console.WriteLine($"Señor/a {nombre}, del programa {programa}, con número de ficha {ficha}, su nota final es de {promedio}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
