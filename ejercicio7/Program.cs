using System;

namespace ejercicio7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = 10;
            int[] enteros = new int[n];
            int total = 0;
            int promedio = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero:");
                enteros[i] = Convert.ToInt32(Console.ReadLine());
                total += enteros[i];

            }
            promedio = total / n;
            
            Console.WriteLine("La suma de los datos es {0} y el promedio {1}",total,promedio);

            Console.ReadKey();
        }
    }
}
