using System;

namespace ejercicio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool EsPrimo(int numero)
            {
                for (int i = 2; i < numero; i++)
                {
                    if ((numero % i) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            int[] enteros = new int[10];
            int c = 0;
            int posicion = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero:");
                enteros[i] = Convert.ToInt32(Console.ReadLine());
                if (enteros[i] > c && EsPrimo(enteros[i]))
                {
                    c = enteros[i];
                    posicion = i;
                }

            }
            if (c == 0)
            {
                Console.WriteLine("No hay numeros primos en el arreglo");
            }
            else
            {
                Console.WriteLine("El numero primo mas grande del arreglo es {0} y esta en la posicion {1}", c, posicion);
            }
            Console.ReadKey();

        }
    }
}
