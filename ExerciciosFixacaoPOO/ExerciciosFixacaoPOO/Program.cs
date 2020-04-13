using System;
using System.Globalization;

namespace ExerciciosFixacaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex1) Fazer um programa para ler os valores da largura e altura de um retângulo. Em
seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
como mostrado no projeto ao lado.*/

            /* Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a altura e a largura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)); */

            /*Ex2) Fazer um programa para ler os dados de um funcionário (nome,
salário bruto e imposto). Em seguida, mostrar os dados do
funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o
salário bruto é afetado pela porcentagem) e mostrar novamente os
dados do funcionário. Use a classe projetada abaixo.*/

            /* Funcionario f1 = new Funcionario();

            f1.Nome = Console.ReadLine();
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(f1);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(porcentAumento);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(f1); */

            Aluno aluno1 = new Aluno();

            Console.WriteLine("Nome do aluno: ");
            aluno1.Nome = Console.ReadLine();

            Console.WriteLine("Nota 1: ");
            aluno1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota 2: ");
            aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota 3: ");
            aluno1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final: " + aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno1.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + aluno1.PontosRestantes().ToString("F2", CultureInfo.InvariantCulture) 
                    + " pontos.");
            }


        }
    }
}
