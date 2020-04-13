using System;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            //Uma variáve string em c# não pode ter seu conteúdo mudado apenas pode apontar para outro conteúdo

            //Passar tudo para maiúscula:
            string s1 = original.ToUpper();

            //Passar tudo para minusculo:
            string s2 = original.ToLower();

            //Apagando espaços em branco:
            string s3 = original.Trim();

            //Função para procurar primeira ocorrência:
            int n1 = original.IndexOf("bc");

            //Procura a ultima ocorrência:
            int n2 = original.LastIndexOf("bc");

            //Cortar a string a partir de um certo ponto:
            //Com Substring voce pode falar o indice inicia apenas ou o indice inicial e o tamanho que você quer cortar:
            string s4 = original.Substring(3);

            //Começando na posição 3 e cortando 5 caracteres:
            string s5 = original.Substring(3, 5);

            //Como substituir uma parte da string por outra:
            //O Replace possui duas sobrecargas: substituir um caracter ou substituir um string:
            string s6 = original.Replace('a', 'x');

            //Com string:
            string s7 = original.Replace("abc", "xy");

            //Funções para testar se a string é vazia:
            bool b1 = String.IsNullOrEmpty(original);

            //Testa se a string é espaço em branco:
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3, 5): " + s5);
            Console.WriteLine("Replace (a, x): " + s6);
            Console.WriteLine("Replace(abc, xy): " + s7);
            Console.WriteLine("IsNullOrEmpty(original): " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
