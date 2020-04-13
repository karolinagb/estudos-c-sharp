using System;

namespace LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "José", "Bob" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("----------------------------------------------");

            //string é o tipo do vetor
            //obj é um apelido para os elementos dele. Posso colocar qualquer apelido.
            //Agora consigo imprimir só através do apelido. Sem precisar colocar vect[i]

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
