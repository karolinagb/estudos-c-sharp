using System;
using System.Globalization;

namespace DataHora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            //O Ticks pega quantos nanosegundos já passaram desde o dia 1 de janeiro da era atual até o dia de hoje:
            Console.WriteLine(d1.Ticks);

            Console.WriteLine();

            //Utilizando as sobrecargas do DateTime
           
            //Ano-Mes-Dia
            DateTime d2 = new DateTime(2018, 11, 25);
            Console.WriteLine(d2);

            Console.WriteLine();

            //Ano-Mes-Dia-Hora-Minuto-Segundo
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 30);
            Console.WriteLine(d3);

            Console.WriteLine();

            //Ano-Mes-Dia-Hora-Minuto-Segundo-Milisegundo
            //Para imprimir com milisegundo tem que ter uma formatação específica:
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 30, 500);
            Console.WriteLine(d4);

            Console.WriteLine();

            //O DateTimeKind é para fala se a sua hora é local ou global

            //Today vai gerar uma data no formato de zero horas
            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            Console.WriteLine();

            //Horário atual global:
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);

            Console.WriteLine();

            //Convertendo de string para DateTime:
            DateTime d7 = DateTime.Parse("2000-05-15");
            Console.WriteLine(d7);

            Console.WriteLine();

            DateTime d8 = DateTime.Parse("2000-05-15 13:58:50");
            Console.WriteLine(d8);

            Console.WriteLine();

            DateTime d9 = DateTime.Parse("15/08/2020");
            Console.WriteLine(d9);

            Console.WriteLine();

            DateTime d10 = DateTime.Parse("15/08/2020 15:20:04");
            Console.WriteLine(d10);

            Console.WriteLine();

            //Se você quiser determinar o formato da sua data:
            DateTime d11 = DateTime.ParseExact("08/10/2016", "MM/dd/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

            Console.WriteLine();

            DateTime d12 = DateTime.ParseExact("09/0400/20", "MM/yyyy/dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);

            Console.WriteLine();

            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d13);
        }
    }
}
