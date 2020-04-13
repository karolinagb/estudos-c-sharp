using System;

namespace ExerciciosPropostosWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            /*EX1) Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
            Console.WriteLine("Digite a senha de 6 dígitos: ");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha inválida");
                Console.WriteLine("Digite novamente:");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido."); */

            /*Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).

            Console.WriteLine("Digite a coordenada x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a coordenada y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            while(x !=0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("Coordenadas no primeiro quadrante");
                } else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Coordenadas no segundo quadrante");
                } else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Coordenadas no terceiro quadrante");
                } else
                {
                    Console.WriteLine("Coordenadas no quarto quadrante");
                }

                Console.WriteLine("");

                Console.WriteLine("Digite novamente a coordenada x:");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                Console.WriteLine("Digite novamente a coordenada y:");
                y = int.Parse(Console.ReadLine()); */


            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Digite o combustível preferido onde 1 = alcool, 2 = gasolina, 3 = diesel e 4 = fim:");
            int combustivel = int.Parse(Console.ReadLine());

            while (combustivel < 1 || combustivel > 4)
            {
                Console.WriteLine("Informe um código válido de 1 a 4:");
                combustivel = int.Parse(Console.ReadLine());

                while (combustivel >= 1 && combustivel <= 4)
                {

                    if (combustivel == 1)
                    {
                        alcool++;
                    }
                    else if (combustivel == 2)
                    {
                        gasolina++;
                    }
                    else if (combustivel == 3)
                    {
                        diesel++;
                    } else
                    {
                        break;
                    }

                    Console.WriteLine("Digite o combustível preferido onde 1 = alcool, 2 = gasolina, 3 = diesel e 4 = fim:");
                    combustivel = int.Parse(Console.ReadLine());

                }

            }

            Console.WriteLine("Muito Obrigada!");
            Console.WriteLine("Alcool = " + alcool);
            Console.WriteLine("Gasolina = " + gasolina);
            Console.WriteLine("Diesel = " + diesel);

        }
    }
}

