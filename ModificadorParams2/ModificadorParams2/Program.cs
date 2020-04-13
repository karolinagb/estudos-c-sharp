using System;

namespace ModificadorParams2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando o params, não é preciso instanciar o vetor e sim apenas colocar os valores entre parênteses:
            int result = Calculator.Sum(10, 20, 30, 40);

            Console.WriteLine(result);
        }
    }
}
