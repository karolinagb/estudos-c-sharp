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

            /*Para pegar os produtos com tier igual a 1 e ordená-los por preço basta chamar a função OrderBy (crescente) e 
             * OrderByDescending(descrescente). Para ordenar tenho que colocar uma expressão Lambda dentro da função:
             Caso empate também posso ordenar por nome, por exemplo, basta colocar o ThenBy*/
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("PRODUCTS WITH TIER 1 AND ORDER BY PRICE THEN BY NAME", r4);

            /*Skip(2) - pule 2 --- take(4) - e pegue 4 elementos*/
            var r5 = r4.Skip(2).Take(4);
            Print("PRODUCTS WITH TIER 1 AND ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            /*First() - pega o primeiro elemento do data source.
             Nesse caso não posso utilizar a função print para a impressão pois é apenas um elemento.*/
            var r6 = products.First();
            Console.WriteLine("PRODUCT FIRST OF PRODUCTS: " + r6);

            /*Quando tentamos chamar o First numa operação que vai dar vazia (não há produto com preço maior que 3 mil) gera uma exceção.
             Para corrigir isso podemos tratar a exceção ou então utilizando o FirstOrDefault pois se ele não encontrar nada, retorna nulo.*/
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or Default of product with price > 3000.00: ", r7);
            Console.WriteLine();

            /*Busca que pode retornar 1 resultado ou nenhum.
             Pode utilizar o Single para retornar o elemento apenas ou SingleOrDefault para retornar nulo caso não tiver.
            O SingleOrDefault não funciona se o retorno der mais de 1 elemento.*/
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("SINGLE OR DEFAULT OF ID = 3" + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("SINGLE OR DEFAULT OF ID = 30: " + r9);

            /*A função Max() pega o máximo da minha coleção*/
            var r10 = products.Max(P => P.Price);
            Console.WriteLine("Max price: " + r10);

            /*A função Max() pega o mínimo da minha coleção*/
            var r11 = products.Min(P => P.Price);
            Console.WriteLine("Max price: " + r11);

            /*Soma dos preços de todos com id 1*/
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 with Sum prices: " + r12);

            /*Média dos preços de todos com id 1*/
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 with Average prices: " + r13);

            /*Para fazer uma proteção no caso da função Average se a coleção estiver vazia, vamos fazer da seguinte forma
             Usamos o select para pegar só a sequência de preços. Então na sequência de preços, aplicamos a função
            DefaultIfEmpty(0.0) que quer dizer que se o resultado até aqui for vazio, aplique 0. E por ultimo chamo
            a função Average sem argumentos (já que o select já puxou o preço).*/
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 with Average prices: " + r14);
        }
    }
}
