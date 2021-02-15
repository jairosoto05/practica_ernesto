using System;

namespace ejercicio8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] enteros = new int[10];
            int c = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero:");
                enteros[i] = Convert.ToInt32(Console.ReadLine()); 
                if (enteros[i] < 0)
                {
                    c++;
                }

            }

            Console.WriteLine("Hay {0} numeros negativos en el arreglo", c);

            Console.ReadKey();
        }
    }
}
