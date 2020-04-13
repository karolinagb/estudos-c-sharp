using System;

namespace ModificadorRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //Tem que colocar o ref também na variável do programa principal:
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 40;
            int triple;
            Calculator.Triple(b, out triple);
            Console.WriteLine(triple);

        }
    }
}
