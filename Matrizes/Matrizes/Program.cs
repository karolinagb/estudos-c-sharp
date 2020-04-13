using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            //mat.Length diz quantos elementos a matriz tem no total:
            Console.WriteLine(mat.Length);

            Console.WriteLine("\n");

            //mat.Rank diz quanto é a primeira dimensão da matriz, no caso a quantidade de linhas:
            Console.WriteLine(mat.Rank);

            Console.WriteLine("\n");

            //mat.GetLength abaixo diz quanto é a dimensão 0 da matriz, que no caso é a quantidade de linhas.
            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));
        }
    }
}
