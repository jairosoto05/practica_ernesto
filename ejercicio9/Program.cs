using System;

namespace ejercicio9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] enteros = new int[10];
            int[] factoriales = new int[10];

            int CalcFactorial(int num){
                int factorial = 1;
                for(int i = 2; i <= num; i++)
                {
                    factorial = factorial * i;
                }

                return factorial;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero del 1 al 10:");
                enteros[i] = Convert.ToInt32(Console.ReadLine());
                factoriales[i] = CalcFactorial(enteros[i]);

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("numero: {0}   factorial: {1}", enteros[i], factoriales[i]);
            }

            Console.ReadKey();
        }
    }
}
