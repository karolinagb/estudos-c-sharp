using System;
using PredicaTeParteII.Entities;
using System.Collections.Generic;

namespace PredicaTeParteII
{
    class Program
    {
        //Versão sem a função lambda como argumento do RemoveAll

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(ProductTest);

            /*VAMOS verificar a exclusão:*/
            foreach (Product pr in list)
            {
                Console.WriteLine(pr);
            }
        }

        /*Depois do método Main eu vou criar uma função que recebe um produto e devolve um booleano*/
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
