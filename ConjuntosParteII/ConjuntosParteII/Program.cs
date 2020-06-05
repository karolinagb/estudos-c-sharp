using System;
using System.Collections.Generic;

namespace ConjuntosParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando um conjunto do tipo HashSet
            HashSet<string> set = new HashSet<string>();

            //Adicionando itens ao conjunto
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            //Verificando se há um elemento no conjunto
            Console.WriteLine(set.Contains("Notebook"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
