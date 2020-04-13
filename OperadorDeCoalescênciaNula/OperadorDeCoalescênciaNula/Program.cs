using System;

namespace OperadorDeCoalescênciaNula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operador de Coalescência Nula:
            //Uso esse operador quando quero coloca uma variável nula dentro de uma não nula

            double? x = null;

            double? y = 10;

            //O operador de coalescência (??) serve para o caso de x for nulo, ele acrescenta o 5 a variável a
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
