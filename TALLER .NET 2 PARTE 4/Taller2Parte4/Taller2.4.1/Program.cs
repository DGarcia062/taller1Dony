using System;

namespace Taller2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementando la estructura Switch - Case y For, desarrolle un algoritmo que le permita al usuario escoger entre los siguientes ejercicios:");

            try
            {
                Console.WriteLine("Elige uno de los 4 ejercicios (1, 2, 3 o 4)"); 

                string elegir = Console.ReadLine();

                switch (elegir)
                {
                    case "1":
                        Console.WriteLine("Elegiste el ejercicio número 1"); 
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
                        break;

                        }
                    case "2":
                        Console.WriteLine("Elegiste el ejercicio número 2");
                        Console.WriteLine("Dame el número de sueldos: ");
                        int cantidadSueldos = int.Parse(Console.ReadLine());

                        int o = 0;
                        int max = 0;

                        while (o < cantidadSueldos)
                        {
                            Console.WriteLine("Dame el sueldo: ");
                            int sueldo = int.Parse(Console.ReadLine());

                            o++;

                            if (sueldo > max)
                            {
                                max = sueldo;
                            }
                            Console.WriteLine($"El sueldo máximo es {max}");
                        }
                        break;
                    case "3":

                        Console.WriteLine("Elegiste el ejercicio número 3");

                        numAletra();
                        break;

                    case "4":
                        Console.WriteLine("Elegiste el ejercicio número 4");
                        Console.WriteLine("Dame una letra: ");
                        string letra = Console.ReadLine();

                        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
                        {
                            Console.WriteLine($" La letra {letra} es una vocal");
                        }
                        else
                        {
                            Console.WriteLine($" La letra {letra} es una consonante");
                        }
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error, datos incorrectos");
            }
        }


        //EJERCICIO 3
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
    }
}
