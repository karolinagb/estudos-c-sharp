using System;
using System.Collections.Generic;

namespace EstruturaDictionaRySortEdDictionaRy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            //Adicionando elementos ao Dictionary
            //user é a chave e maria é o value
            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";

            //Dictionary não aceita repetições então minha chave será sobrescrita com o novo phone
            cookies["phone"] = "837337388";

            //Imprimindo chaves
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            //Removendo uma chave
            cookies.Remove("email");

            //Verificando se uma chave existe:
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There's no e-mail key");
            }

            //Para ver o tamanho do dictionary
            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES: ");
            /*KeyValuePair<string, string> pode ser substituido por var*/
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item);
            }
        }
    }
}
