using System;
using System.Collections.Generic;

namespace ListasParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> ();

            //Comando para adicionar elementos a lista:

            list.Add("Maria");
            list.Add("Alex");
            list.Add("João");
            list.Add("Bob");
            list.Add("Ana");

            //Com o insert voce pode escolher a posição que quer inserir o elemento:
            list.Insert(2, "Marco");

            foreach(string pessoa in list)
            {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("List cout: " + list.Count);

            Console.WriteLine("-----------------------------------------------");

            //Utilizar o find para procurar a primeira ocorrência que começa com a letra a.
            /*O find espera a entrada de um predicado. Predicado é uma função que pega um valor e vai retornar verdadeirou ou
             falso conforme a lógica que estiver implementada nessa função.*/
            //o FIND vai buscar o primeiro da lista.
            //Entre o parenteses do find temos uma função lambda que é uma expressão anônima
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);

            Console.WriteLine("-------------------------------------------------");

            //O FindLast busca a ultima ocorrência que começa com A:
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            Console.WriteLine("-------------------------------------------------");

            //O FindIndex vai achar a posição do primeiro elemento que começa com A:
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos1);

            Console.WriteLine("-------------------------------------------------");

            //O FindLastIndex encontra a  ultima posição que tem a ocorrência entre parenteses:
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2);

            Console.WriteLine("-------------------------------------------------");

            //Agora vamos filtrar a lista com base em um predicado.
            //Vai ser criada uma nova lista com os elementos que satisfaçam o predicado.
            //Tenho que criar outra lista e usar o FindAll:
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
                Console.WriteLine("-------------------------------------------");
            }

            //Agora vamos remover elementos da lista.
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------------");

            //O RemoveAll permite adicionar um predicado:
            list.RemoveAll(x => x[0] == 'M');
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------------");

            //Vamos agora remover um elemento pela posição dele com o RemoveAt:
            list.RemoveAt(2);
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("-------------------------------------------");

            list.Add("Karol");
            list.Add("Alexandra");
            list.Add("Telma");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------------");

            //RemoveRange remove os elementos de uma faixa:
            //A partir da posição 2 eu quero remover 2 itens:
            list.RemoveRange(2, 2);
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
