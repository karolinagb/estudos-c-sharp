using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("O maior número é " + resultado);

            /* Posso escrever tudo que está abaixo numa função
             * 
            if(n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O maior é o " + n1);
            } else if (n2 > n3)
            {
                Console.WriteLine("O maior é o " + n2);
            } else
            {
                Console.WriteLine("O maior é o " + n3);
            } */
        }

        static int Maior(int a, int b, int c)
        {
            int m = 0;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;

        }
    }
}
