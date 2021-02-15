using System;

namespace ejercicio10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] enteros = new int[10];
            int[] divisores = new int[10];
            int dividendo = 0;
            int num = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un divisor:");
                enteros[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("ingrese el numero dividendo:");
            dividendo = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<10; i++)
            {
                if(dividendo % enteros[i] == 0)
                {
                    divisores[i] = 1;
                    num++;
                }
            }
            if(num == 0)
            {
                Console.WriteLine("No hay divisores exactos de {0} en el arreglo",dividendo);
            }
            else
            {
                Console.WriteLine("Hay {0} divisores exactos de {1}", num, dividendo);
                for (int i=0;i < 10; i++)
                {
                    if(divisores[i] == 1)
                    {
                        Console.WriteLine("{0}",enteros[i]);
                    }
                    Console.ReadKey();
                }
            }

        }
        
    }
}
