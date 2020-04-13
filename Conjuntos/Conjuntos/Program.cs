using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de conjunto:
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            //Adicionando elementos no conjunto:
            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            //Para ler os elementos do conjunto eu tenho que usar o foreach porque o conjunto não possui posições
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n");

            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nDigite um número inteiro: \n");
            int n = int.Parse(Console.ReadLine());

            //Para ver se um elemento pertence ao conjunto:
            if (B.Contains(n))
            {
                Console.WriteLine(n + " pertence ao conjunto B.\n");
            }
            else
            {
                Console.WriteLine(n + " não pertence ao conjunto B.\n");
            }

            //Removendo um elemento do conjunto:
            //B.Remove(4);

            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            //Diferença entre conjunto:
            A.ExceptWith(B);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            B.Add(8);
            B.Add(7);

            //União entre conjuntos:
            /*A.UnionWith(B);

            foreach(int x in A)
            {
                Console.WriteLine(x);
            }*/

            Console.WriteLine();

            //Intersecção entre conjuntos:
            A.IntersectWith(B);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }
        }
    }
}
