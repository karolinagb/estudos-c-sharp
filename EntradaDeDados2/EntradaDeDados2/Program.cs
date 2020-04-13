using System;
using System.Globalization;

namespace EntradaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tem que converter para inteiro
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: " + n1);

            //Se introduzir uma string com esse comando int.Parse vai dar erro.

            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("você digitou: " + ch);

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Posso Imprimire tambem com o ponto:
            //Console.WriteLine("Você digitou: " + n2);
            Console.WriteLine("Você digitou: " + n2.ToString("F2", CultureInfo.InvariantCulture));

            /*Na tela tenho que digitar com a virgula pq o pc está em portugues, mas posso digitar com ponto:
             * basta adicionar a biblioteca using System.Globalization e o Culture info*/

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char genero = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
