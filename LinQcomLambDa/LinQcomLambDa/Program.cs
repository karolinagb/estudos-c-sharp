using System;
using LinQcomLambDa.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LinQcomLambDa
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);

            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category { Id = 3, Name = "Eletronics", Tier = 1 };

            //Data Source:
            List<Product> products = new List<Product>()
            {
                new Product(){Id = 1, Name = "Computer", Price = 1100.00, Category = c2},
                new Product(){Id = 2, Name = "Hammer", Price = 90.00, Category = c1},
                new Product(){Id = 3, Name = "TV", Price = 1700.00, Category = c3},
                new Product(){Id = 4, Name = "Notebook", Price = 1300.00, Category = c2},
                new Product(){Id = 5, Name = "Saw", Price = 80.00, Category = c1},
                new Product(){Id = 6, Name = "Tablet", Price = 700.00, Category = c2},
                new Product(){Id = 7, Name = "Câmera", Price = 700.00, Category = c3},
                new Product(){Id = 8, Name = "Printer", Price = 350.00, Category = c3},
                new Product(){Id = 9, Name = "MacBook", Price = 1800.00, Category = c2},
                new Product(){Id = 10, Name = "Sound Bar", Price = 700.00, Category = c3},
                new Product(){Id = 10, Name = "Sound Bar", Price = 70.00, Category = c1},
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900:", r1);

            //A partir do resultado, para gerar uma lista só de nomes uso Select
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);


            /*Quero os produtos que comecem com a letra C, mas não quero tudo sobr eos produtos,
             apenas nome, preço e o nome da categoria. Para isso eu uso o select.
            Dentro do select eu crio um objeto anônimo, ou seja, que não está declarado em alguma
            das classes do projeto.
            No objeto anônimo eu não posso ter dois campos chamados Name, então eu dou um apelido para o campo*/
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMED STARTED WITH 'C' AND ANONYMOUS OBJECTS", r3);
        }
    }
}
