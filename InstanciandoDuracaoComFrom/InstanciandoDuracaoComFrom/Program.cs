using System;

namespace InstanciandoDuracaoComFrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //O from permite conversar na unidade que quiser:
            TimeSpan t1 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t1);

            Console.WriteLine();

            TimeSpan t2 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t2);

            Console.WriteLine();

            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t3);

            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t4);

            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t5);

            //O tick não aceita quebrado. So numero long:
            TimeSpan t6 = TimeSpan.FromTicks(900000000);
            Console.WriteLine(t6);

            Console.WriteLine();


        }
    }
}
