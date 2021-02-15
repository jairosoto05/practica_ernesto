using System;

namespace ejercicio6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] cadena = new string[10];
            int[] posicion = new int[10];
            int n = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero:");
                cadena[i] = Console.ReadLine();
                if (cadena[i].Length > 3)
                {
                    posicion[i] = 1;
                    n++;
                }

            }

            if (n == 0)
            {
                Console.WriteLine("No hay posiciones con mas de 3 digitos");
            }
            else
            {
                Console.WriteLine("Las posiciones con mas de tres digitos son:");
                int count = 0;
                foreach (int num in posicion)
                {
                    if (num == 1)
                    {
                        Console.WriteLine(count);
                    }
                    count++;
                }
            }

            Console.ReadKey();
        }
    }
}
