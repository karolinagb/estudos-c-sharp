using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forma compacta de instanciar um vetor e já colocar os dados nele:
            int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });

            Console.WriteLine(result);
        }
    }
}
