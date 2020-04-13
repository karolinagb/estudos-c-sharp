using System;

namespace Duracao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando o TimeSpan e utilizando o construtor de 3 argumentos: horas, minutos, segundos.
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            Console.WriteLine();

            //Construtor vazio:
            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);

            Console.WriteLine();

            //Construto para indicar quantos ticks
            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);

            Console.WriteLine();

            //Construtor com dias, horas, minutos e segundos:
            TimeSpan t4 = new TimeSpan(1 , 2, 11, 21);
            Console.WriteLine(t4);

            Console.WriteLine();

            //Construtor dia, hora, minuto, segundo e milisegundo:
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t5);

        }
    }
}
