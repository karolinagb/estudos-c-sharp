using System;
using System.Globalization;

namespace MetodoEstaticoI
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //A chamada do metodo utilizará direto o nome da classe.
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI = " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        /*NÃO se pode chamar uma funçãó não estática dentro de uma função estática se as duas pertecerem a mesma classe.
         Portanto as funções abaixo serão criadas como estaticas*/

    }
}
