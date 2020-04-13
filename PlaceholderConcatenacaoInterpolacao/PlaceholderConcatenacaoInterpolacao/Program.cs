using System;
using System.Globalization;

namespace PlaceholderConcatenacaoInterpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            string nome = "Maria";
            double saldo = 10.35784;

            /*Placeholder:*/
            //{2:F2 é para dizer a quantidade de casas decimais}
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            /*Interpolação*/
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            /*Concatenação:*/
            //Só no ToString conseguimos alterar formatação de ponto ou virgula
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " 
                + saldo.ToString("F2" , CultureInfo.InvariantCulture) + " reais ");
        }
    }
}
