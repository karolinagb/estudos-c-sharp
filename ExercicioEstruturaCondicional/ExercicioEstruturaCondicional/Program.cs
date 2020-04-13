using System;
using System.Globalization;

namespace ExercicioEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EX1) Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.*/

            /*Console.WriteLine("Digite o número inteiro: ");
            int n1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(n1 >= 0)
            {
                Console.WriteLine("Numero positivo");
            } else
            {
                Console.WriteLine("Numero negativo");
            }*/

            /*EX2)Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar */

            /*Console.WriteLine("Digite um numero inteiro");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 % 2 == 0)
            {
                Console.WriteLine("Numero par");
            }
            else
            {
                Console.WriteLine("Numero ímpar");
            }*/

            /*Ex3)Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.
 */

            /*Console.WriteLine("Digite dois numeros inteiros na mesma linha: ");
            String[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São números múltiplos:");
            } else
            {
                Console.WriteLine("Não são números múltiplos");
            }*/

            /*EX4) Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

            /*Console.WriteLine("Digite a hora inicial do jogo: ");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora final do jogo: ");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao = 0;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = (24 - horaInicial) + horaFinal;
            }

            Console.WriteLine("A duração do jogo foi de " + duracao + " horas."); */

            /*EX5) Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.*/

            /*Console.WriteLine("Digite o código do item: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos itens são no total: ");
            int quantidade = int.Parse(Console.ReadLine());

            double total = 0.00;

            double preco1 = 4.0;
            double preco2 = 4.50;
            double preco3 = 5.00;
            double preco4 = 2.00;
            double preco5 = 1.50;

            if(codigo == 1)
            {
                total = (double) (preco1 * quantidade);

            } else if (codigo == 2)
            {
                total = (double) (preco2 * quantidade);
            } else if (codigo == 3)
            {
                total = (double)(preco3 * quantidade);
            } else if (codigo == 4)
            {
                total = (double)(preco4 * quantidade);
            } else if (codigo == 5)
            {
                total = (double)(preco5 * quantidade);
            } else
            {
                Console.WriteLine("Produto não cadastrado");
            }

            Console.WriteLine("O total a pagar é: " + total.ToString("F2", CultureInfo.InvariantCulture));*/

            /*Ex6)Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/

            /*Console.WriteLine("Digite um número: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 0 && numero <= 25)
            {
                Console.WriteLine("O numero está no intervalo [0,25]");
            } else if (numero >= 25 && numero <=50)
            {
                Console.WriteLine("O numero está no intervalo [25,50]");
            } else if (numero >= 50 && numero <= 75)
            {
                Console.WriteLine("O numero está no intervalo [50,75]");
            } else if (numero >= 75 && numero <= 100)
            {
                Console.WriteLine("O numero está no intervalo [75,100]");
            }
            else
            {
                Console.WriteLine("Numero fora de intervalo");
            }*/

            /*Ex7) Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
situação.*/

            /*Console.WriteLine("Escreve dois valores com ponto flutuante:");
            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if(x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            } else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            } else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            } else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            } else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            } else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            } else
            {
                Console.WriteLine("Q4");
            }*/

            /*Ex8) Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
duas casas decimais.*/

            Console.WriteLine("Insira o salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0.00 && salario <= 2000.00)
            {
                Console.WriteLine("Isento de pagar imposto");
            } else if (salario >= 2000.01 && salario <= 3000.00)
            {

            }
        }
    }
}
