using System;
using ComparacaoObjetosParteII.Entities;

namespace ComparacaoObjetosParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));

            //O == compara a referência de memória e não o conteúdo e portanto ele continua dando sempre diferente os objetos
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
