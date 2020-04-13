using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());*/

            //Produto p = new Produto(nome, preco);
            //Console.WriteLine(p);

            //Outra sintaxe para iniciar valores
            Produto p2 = new Produto
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };

            /*Agora automaticamente quando você coloca um  objeto dentro do Console.WriteLine, ele implicitamente
             vai chamar o método ToString e fazer a conversão que colocamos lá na classe Produto.*/

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("--------------------------------------------------------");

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);



        }
    }
}
