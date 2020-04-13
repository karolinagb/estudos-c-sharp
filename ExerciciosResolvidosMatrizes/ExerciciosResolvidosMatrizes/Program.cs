using System;
using System.Globalization;

namespace ExerciciosResolvidosMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            //Tenho que fazer um for para linhas e um for para colunas:
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite os valores da linha {i}: ");

                //O vetor abaixo vai percorrer uma linha toda e separar os valores por espaço:
                string[] values = Console.ReadLine().Split(' ');

                //Agora cada valor separado pelo Split eu tenho que colocar nas posições do vetor na primeira linah e 3 colunas:
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.WriteLine("\n");

            Console.Write("Main diagonal: ");

            //Mostrando os elementos da diagonal principal:
            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }

            Console.WriteLine("\n");

            //variável para contar a quantidade de negativos:
            int count = 0;

            //Para mostar os números negativos eu tenho que percorrer cada linha e cada coluna usando for:
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
