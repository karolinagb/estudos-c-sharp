using System;
using System.Globalization;

namespace PrimeirosExerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex1) Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.*/

            /* Pessoa P1, P2;

            P1 = new Pessoa();
            P2 = new Pessoa();

            Console.WriteLine("Qual o nome da pessoa 1 ?");
            P1.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Qual a idade de " + P1.Nome + " ?");
            P1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Qual o nome da pessoa 2 ?");
            P2.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Qual a idade de " + P2.Nome + " ?");
            P2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------------------");

            if (P1.Idade > P2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + P1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + P2.Nome);
            } */

            /*Ex2) Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.*/

            Funcionarios F1, F2;

            F1 = new Funcionarios();
            F2 = new Funcionarios();

            Console.WriteLine("Qual o nome do funcionario?");
            F1.Nome = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Qual o salário de " + F1.Nome);
            F1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual o nome do funcionario?");
            F2.Nome = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Qual o salário de " + F2.Nome);
            F2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (double)(F1.Salario + F2.Salario) / 2.00;

            Console.WriteLine("A média salarial é de: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
