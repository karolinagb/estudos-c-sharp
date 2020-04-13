using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            /*Para indicar que o numero abaixo é do tipo double coloque o casting antes "(double) 
             * ou coloque o numero com casas decimais tipo 10.0"*/
            double n4 = (double)10 / 8;

            double a = 1.0, b = -3.0, c = -4.0;

            //Math.Pow é para potência onde o primeiro parâmetro é a base e o segundo o expoente.
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            //Math.Sqrt é para calcular raiz quadrada
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
