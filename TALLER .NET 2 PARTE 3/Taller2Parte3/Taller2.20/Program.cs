using System;

namespace Taller2._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Debes elegir cuál ejercicio hacer");
                int elegir = int.Parse(Console.ReadLine());

                int acceso = 1;

                while (acceso == 1)
                {
                    if (elegir == 1)
                    {
                        NumPrimos();
                        acceso = 0;
                        break;
                    }
                    else if (elegir == 2)
                    {
                        sueldoMax();
                        acceso = 0;
                        break;
                    }
                    else if (elegir == 3)
                    {
                        numAletra();
                        acceso = 0;
                        break;
                    }
                    else if (elegir == 4)
                    {
                        vocalConsonante();
                        acceso = 0;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
            
        }
        public static void NumPrimos()
        {

            Console.WriteLine("Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.");

            try
            {
                Console.WriteLine("Dame un número: ");
                int numero = int.Parse(Console.ReadLine());
                int contadorpri = 0;
                {
                    for (int i = 1; i <= numero; i++)
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
        public static void sueldoMax()
        {
            try
            {
                Console.WriteLine("Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo");
                try
                {
                    Console.WriteLine("Dame el número de sueldos: ");
                    int cantidadSueldos = int.Parse(Console.ReadLine());

                    int i = 0;
                    int max = 0;

                    while (i < cantidadSueldos)
                    {
                        Console.WriteLine("Dame el sueldo: ");
                        int sueldo = int.Parse(Console.ReadLine());

                        i++;

                        if (sueldo > max)
                        {
                            max = sueldo;
                        }

                    }
                    Console.WriteLine($"El sueldo máximo es {max}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error, datos incorrectos");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
        public static void numAletra()
        {
            try
            {
                Console.WriteLine("Dame un número del 0 al 99 para pasarlo a letras: ");

                int numero = int.Parse(Console.ReadLine());

                int decenas = retornoDecenas(numero);

                int unidades = retornoUnidades(numero);

                LeerNumero(decenas, unidades);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrerctos");
            }
        }
        static int retornoDecenas(int numero)
        {
            return numero / 10;
        }
        static int retornoUnidades(int numero)
        {
            return numero % 10;
        }
        static void LeerNumero(int decenas, int unidades)
        {

            string[] unidadesStr = { "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            string[] decenasStr = { "diez", "veinti", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

            if (decenas == 0 && unidades == 0)
            {
                Console.WriteLine("Cero");
            }
            else if (decenas == 0 && unidades == 1)
            {
                Console.WriteLine($"{unidadesStr[unidades - 1]}");
            }
            else if (decenas == 0 && unidades == 2)
            {
                Console.WriteLine($"{unidadesStr[unidades - 1]}");
            }
            else if (decenas == 0 && unidades == 3)
            {
                Console.WriteLine($"{unidadesStr[unidades - 1]}");
            }
            else if (decenas == 0 && unidades == 4)
            {
                Console.WriteLine($"{unidadesStr[unidades - 1]}");
            }
            else if (decenas == 0 && unidades == 5)
            {
                Console.WriteLine($"{unidadesStr[unidades - 1]}");
            }
            else if (decenas == 0 && unidades == 6)
            {
                Console.WriteLine($"{unidadesStr[unidades - 1]}");
            }
            else if (decenas == 0 && unidades == 7)
            {
                Console.WriteLine($"{unidadesStr[unidades - 1]}");
            }
            else if (decenas == 0 && unidades == 8)
            {
                Console.WriteLine($"{unidadesStr[unidades - 1]}");
            }
            else if (decenas == 0 && unidades == 9)
            {
                Console.WriteLine($"{unidadesStr[unidades - 1]}");
            }
            else if (decenas == 2)
            {
                Console.WriteLine($"{decenasStr[decenas - 1]} {unidadesStr[unidades - 1]}");
            }else if (decenas == 1 && unidades == 1)
            {
                Console.WriteLine("Once");
            }
            else if (decenas == 1 && unidades == 2)
            {
                Console.WriteLine("Doce");
            }
            else if (decenas == 1 && unidades == 3)
            {
                Console.WriteLine("Trece");
            }
            else if (decenas == 1 && unidades == 4)
            {
                Console.WriteLine("Catorce");
            }
            else if (decenas == 1 && unidades == 5)
            {
                Console.WriteLine("Quince");
            }
            else
            {
                Console.WriteLine($"{decenasStr[decenas - 1]} y {unidadesStr[unidades - 1]}");
            }
        }


        public static void vocalConsonante()
        {
            Console.WriteLine("Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por consola si se trata de un vocal o una consonante.");


            try
            {
                Console.WriteLine("Dame una letra: ");
                string letra = Console.ReadLine();

                if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
                {
                    Console.WriteLine("Vocal");
                }
                else
                {
                    Console.WriteLine("Consonante");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, datos incorrectos");
            }
        }
    }
}

