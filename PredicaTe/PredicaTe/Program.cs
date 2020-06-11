using System;
using PredicaTe.Entities;
using System.Collections.Generic;

namespace PredicaTe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*O RemoveAll possui um argumento que é o Predicate. 
             O Predicate é uma função que recebe um objeto e devolve um booleano.*/
            /*>= tal que
             p => p.Price >= 100.0  -- é uma função lambda (função anônima) que recebe um produto p
            e devolve o resultado da condição.*/
            list.RemoveAll(p => p.Price >= 100.0);

            /*VAMOS verificar a exclusão:*/
            foreach (Product pr in list)
            {
                Console.WriteLine(pr);
            }
        }
    }
}
