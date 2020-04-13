using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O name space SByte pertence ao namespace System do .net. 
             O sbyte minúsculo já é o tipo do C#. Esse é um tipo do predefinido.*/
            sbyte x = 127;

            x++;

            /*A variavel do tipo byte so aceita numero com sinal e até 256.
             Overflow = quando um calculo estrapola o limite da sua variável. Quando isso acontece
             o valor da variável vai para o limite oposto que no caso do byte é zero.*/
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            /*Quando vai se guardar dessa forma valores muito longos, recomenda botar o L depois indicando
             explicitamente que esta trabalhando com o tipo long.*/

            bool completo = false;
            char genero = 'F';
            /*Voce tambem pode colocar o caracter atraves do seu codigo unicode como abaixo:*/
            char letra = '\u0041';

            /*Dados do tipo float como abaixo, o c# entende como double, para especificar que é float deve-se colocar f*/
            float n5 = 4.5f;
            double n6 = 4.5;

            string nome = "Maria";

            /*O tipo object é um tipo genérico. Aceita qualquer coisa.*/
            object obj1 = "Karolina Gomes";
            object obj2 = 4.6f;

            n1++;

            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            /*Função para menor valor de int*/
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            decimal n9 = decimal.MaxValue;

            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
        }
    }
}
