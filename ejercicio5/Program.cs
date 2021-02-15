using System;

namespace ejercicio5
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


            int[,] enteros = new int[10,2];
            int primos = 0;
            int pares = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero:");
                string cadena = Console.ReadLine();
                enteros[i,0] = Convert.ToInt32(cadena);
                if (EsPrimo(enteros[i,0]))
                {
                    primos++;
                    string cad = Convert.ToString(enteros[i,0]);
                    foreach(int a in cad)
                    {
                        if(a % 2 == 0)
                        {
                            enteros[i, 1]++;
                        }
                        if (enteros[i, 1] > pares)
                        {
                            pares = i;
                        }
                    }

                }

            }
            if (primos == 0)
            {
                Console.WriteLine("no hay numeros primos en el arreglo");
            }
            else if(pares == 0)
            {
                Console.WriteLine("no hay numeros primos que contengan digitos pares en el arreglo");
            }
            else
            {
                Console.WriteLine("el numero primo con mas digitos pares es {0} y esta en la posicion {1}", enteros[pares, 0], pares);
            }
            Console.ReadKey();
        }
    }
}