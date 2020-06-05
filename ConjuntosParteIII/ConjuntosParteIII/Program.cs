using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ConjuntosParteIII
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Instanciando um conjunto do tipo SortedSet
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10};

            PrintCollection(a);
            Console.WriteLine();

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);
            Console.WriteLine();

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);
            Console.WriteLine();

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        //IEnumerable é uma interface implementada por todas as coleções básica do pacote do System.Collections
        //Essa interface disponibiliza uma forma de percorrer a coleção
        //Criando uma função para imprimir o conjunto
        //A coleção é do tipo T e implementa o IEnumerable
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            //O foreach funciona em cima de coleções que implementam o IEnumerable
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
