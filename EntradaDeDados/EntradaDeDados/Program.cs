using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            Console.WriteLine("Você digitou: " + frase);

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            /*A função Split corta strings em vários pedaços de acordo com o que você determinar por separação*/
            //string s = Console.ReadLine(); posso trocar a variavel pelo console diretamente
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
