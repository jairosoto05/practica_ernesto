using System;

namespace ejercicio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] enteros = new int[10];
            int c = 0;
            int posicion = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero");
                enteros[i] = Convert.ToInt32(Console.ReadLine());
                if (enteros[i] > c && enteros[i] % 2 == 0)
                {
                    c = enteros[i];
                    posicion = i;
                }

            }

            if (c == 0)
            {
                Console.WriteLine("No hay numeros pares en el arreglo");
            }
            else
            {
                Console.WriteLine("El numero par mas grande del arreglo es {0} y esta en la posicion {1}", c, posicion);
            }
            Console.ReadKey();
        }
    }
}
