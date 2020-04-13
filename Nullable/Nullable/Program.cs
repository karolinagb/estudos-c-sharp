using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //O nullable permite que uma variável tipo valor (struct) receba null

            Nullable<double> x = null;

            //O nullable tambem pode ser escrito de um jeito mais simples:

            double? y = 10.0;

            //O GetValueOrDefault pega o valor do x ou o valor default do tipo da variável x.
            Console.WriteLine(x.GetValueOrDefault());

            //O HasValue vai dizer se dentro da variável x existe ou não um valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //O x.Value é como se pegasse o valor direto do x
            //O x.Value só funciona se houver valor

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("Y é null");
            }
        }
    }
}
