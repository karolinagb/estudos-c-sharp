using System;
using System.Globalization;

namespace EscopoInicialização
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = 0.0;

            //Quando você declara uma variável dentro de uma estrutura, a variável só existe dentro daquela estrutura:
            //Posso usar variáveis que estão no escopo maior que é a estrutura do programa
            //Mas o escopo maior não exerga variáveis de estruturas menores
            if (preco > 100)
            {
                desconto = preco * 0.1;

            }

            double total = (double)preco - desconto;

            Console.WriteLine("Você recebeu: " + desconto.ToString("F2", CultureInfo.InvariantCulture) + " reais de desconto.");
            Console.WriteLine("O valor total a pagar é igual a: " + total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
