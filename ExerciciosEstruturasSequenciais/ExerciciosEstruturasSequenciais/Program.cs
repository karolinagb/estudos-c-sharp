using System;
using System.Globalization;

namespace ExerciciosEstruturasSequenciais
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EX1) Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa*/

            /* Console.WriteLine("Digite o primeiro valor inteiro:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: " + n1);

            Console.WriteLine("Digite o segundo número inteiro:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou: {n2}");

            int soma = n1 + n2;
            Console.WriteLine("A soma dos números digitados é: {0}", soma);*/

            /*EX2)Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159*/

            /*Console.WriteLine("Digite o valor do raio do círculo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou o raio com valor: " + raio.ToString("F2", CultureInfo.InvariantCulture));

            double pi = 3.14159;
            double area = pi * (Math.Pow(raio, 2));

            Console.WriteLine("O valor da área desse círculo é: " + area.ToString("F4", CultureInfo.InvariantCulture));*/

            /*EX3) Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

            /*Console.WriteLine("Digite 4 valores inteiros na mesma linha e separados por espaço: ");
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            int d = int.Parse(vet[3]);

            int diferenca = ((a * b) - (c * d));

            Console.WriteLine($"A diferença do produto de {a} e {b} pelo produto de {c} e {d} é: {diferenca}");*/

            /*EX4)Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.*/

            /*Console.WriteLine("Digite o número do funcionário: ");
            int numFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual é o número de horas trabalhadas do funcionário {numFuncionario}?");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quanto o funcionário " + numFuncionario + " recebe por hora? ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calcSalario = horas * valorHora;

            Console.WriteLine("O funcionário " + numFuncionario + " recebe um salário no valor de: R$ " 
                + calcSalario.ToString("F2", CultureInfo.InvariantCulture));*/

            /*EX5) Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/

            /*Console.WriteLine("Digite o código da peça 1, o número de peças 1 e o valor unitário de cada peça 1: ");
            string[] vet1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(vet1[0]);
            int numPeca1 = int.Parse(vet1[1]);
            double vlUnitPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da peça 2, o número de peças 2 e o valor unitário de cada peça 2: ");
            string[] vet2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(vet2[0]);
            int numPeca2 = int.Parse(vet2[1]);
            double vlUnitPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double pagamento1 = (double)numPeca1 * vlUnitPeca1;
            double pagamento2 = (double)numPeca2 * vlUnitPeca2;

            double total = pagamento1 + pagamento2;

            Console.WriteLine("O valor da peça 1 foi de: " + pagamento1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor da peça 2 foi de: " + pagamento2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor total nas 2 peças é de: " + total.ToString("F2", CultureInfo.InvariantCulture));*/

            /*EX6) Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.*/

            Console.WriteLine("Digite um valor a: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um valor b: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um valor c: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaTriangulo = (double)(a*c) / 2;

            double pi = 3.14159;
            double areaCirculo = (double) pi * (Math.Pow(c, 2));

            double areaTrapezio = (double) ((a + b) * c) / 2;

            double areaQuadrado = (double) Math.Pow(b, 2);

            double areaRetangulo = (double) a * b;

            Console.WriteLine("A área do triângulo que tem base " + a.ToString(CultureInfo.InvariantCulture) + " e altura " + c.ToString(CultureInfo.InvariantCulture) + " é igual a " 
                + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do círculo que tem raio igual a " + c.ToString(CultureInfo.InvariantCulture) +
                " é " + areaCirculo.ToString("F3",CultureInfo.InvariantCulture));

            Console.WriteLine("A área do Trapézio que tem base 1 igual a " + a.ToString(CultureInfo.InvariantCulture) 
                + " e base 2 igual a " + b.ToString(CultureInfo.InvariantCulture) + " é igual a: " 
                + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do quadrado que tem lado " + b.ToString(CultureInfo.InvariantCulture) + " é igual a: " 
                + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do retângulo de lado 1 " + a.ToString(CultureInfo.InvariantCulture) + " lado 2 " 
                + b.ToString(CultureInfo.InvariantCulture) + " é igual a: " 
                + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}