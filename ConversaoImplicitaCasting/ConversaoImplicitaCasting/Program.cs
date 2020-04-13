using System;

namespace ConversaoImplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Conversao implicita de tipos.
             O float cabe em double.*/
            float x = 4.5f;
            double y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            double a = 5.1;
            float b;

            /*Casting = coloca-se o nome do tipo que deve ser convertido entre parenteses.
             Pode ocorrer perda de informação.*/
            b = (float) a;

            Console.WriteLine(b);

            double c = 6.1;
            int d;
            //Quando tento atribuir double ou float em um int, os valores serão truncados.
            d = (int)c;

            Console.WriteLine(c);
            Console.WriteLine(d);

            int e = 5;
            int f = 2;
            //Se eu quiser garantir que o resultado seja double, eu coloco um casting e isso vai converter a para double.
            double resultado = (double) e / f;

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(resultado);
        }
    }
}
