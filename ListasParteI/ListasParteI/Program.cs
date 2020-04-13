using System;
using System.Collections.Generic;

namespace ListasParteI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declaração de uma lista. Tipo lista, tipo do dado e nome da lista.*/
            //Podemos instanciar também.
            //Essa instanciação criou uma lista vazia.
            List<string> list = new List<string>();
             

            //Mas também podemos instanciar e já colocar elementos nela:
            List<string> list2 = new List<string> { "Maria", "Fernanda" };
        }
    }
}
