using System;

namespace Taller2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.	Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.");

            try
            {
                Console.WriteLine("Dame un número: ");
                int numero = int.Parse(Console.ReadLine());
                int contadorpri = 0;                        
                {
                    for(int i = 1; i <= numero; i++)
                    {
                        bool primo = true;
                        int j = 2;

                        while (j <= i - 1 && primo == true)
                        {
                            if (i % j == 0)
                                primo = false;
                                j++;
                        }
                        if (primo == true)
                        {
                            contadorpri++;
                            Console.WriteLine($" {i} Es primo");
                        }

                    }
                    Console.WriteLine($"En el rango desde 1 hasta {numero} hay {contadorpri} primos");
                    
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}
