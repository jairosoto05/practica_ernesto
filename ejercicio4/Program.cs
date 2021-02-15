using System;

namespace ejercicio4
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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero:");
                string cadena = Console.ReadLine();
                int primer_digito = Convert.ToInt32(cadena[0]);
                enteros[i] = Convert.ToInt32(cadena);
                if (EsPrimo(primer_digito))
                {
                    c++;
                }

            }

            Console.WriteLine("Hay {0} numeros que empiezan con digitos primos", c);

            Console.ReadKey();
        }
    }
}
