using System;
using System.Globalization;

namespace SegundoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Maria";
            char genero = 'F';
            int idade = 35;
            double saldo = 10.56789;

            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            /*O método ToString(F2) fará com que o numero double seja impresso com 2 casas decimais*/
            Console.WriteLine(saldo.ToString("F2"));
            /*O CultureInfor.InvariantCulture é usado para colocar o ponto como separação do numero
             e desconsiderar qualquer padrão de formato  por país. Precisa inserir a biblioteca System.Globalization*/
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
