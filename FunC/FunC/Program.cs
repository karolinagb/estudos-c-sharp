using System;
using System.Collections.Generic;
using FunC.Entities;
using System.Linq;

namespace FunC
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

            /*Posso criar um delegate que será referência para um função que recebe um product e retorna uma string*/
            //Delegate recebendo a referência para o método func

            /*--- Func<Product, string> func = NameUpper  ---*/;

            /*Select transforma uma coleção em outra coleção*/
            //O select recebe um func
            /*Recebe um func que recebe um produto e retorna um valor do tipo TResult*/
            /*A função Select retorna um IEnumerable. Tenho que converter essa função genérica (IEnumerable)
             para lista (ToList).*/

            /*-- List<string> result = list.Select(NameUpper).ToList(); ---*/

            /*Dentro do select posso colocar a variável do tipo do delegate
             
             --- List<string> result = list.Select(func).ToList(); ---         
             */

            /*Versão com a expressão Lambda no parâmetro do Select:*/
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        /*static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }*/

    }
}
