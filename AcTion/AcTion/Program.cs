using System;
using System.Collections.Generic;

namespace AcTion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            /*Criando um Action que recebe uma referência para a função UpdatePrice*/
            //Action<Product> act = UpdatePrice;

            /*Criando um Action que recebe uma função Lambda que recebe um argumento p e leva numa ação.
             No caso de uma ação eu vou ter que colocar o {} para indicar que a fuñção tem um corpo, mas
            que ela não vai retornar alguma coisa.*/
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            /*ForEach é uma função de listas. Essa função recebe um action do tipo product, ou seja, 
             * tem que ser uma função que receba um produto e que seja uma função void, então a função
             UpdatePrice serve como argumento para o ForEach.*/

            /*Posso também colocar a expressão Lambda diretamente no argumento da função ForEach que seria colocar
             inline*/
            list.ForEach(p => { p.Price += p.Price * 0.1; });

            
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += (p.Price * 0.1);
        }
    }
}
