using System;

namespace DataHoraFormatacao
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2020, 4, 10, 19, 44, 58);

            //Data em string completa
            Console.WriteLine(d.ToLongDateString() + "\n");

            //Hora em string
            string s2 = d.ToLongTimeString();

            Console.WriteLine(s2 + "\n");

            //Data curta em formato resumido:
            string s3 = d.ToShortDateString();
            Console.WriteLine(s3 + "\n");

            //Hora resumida: (Hora e minuto)
            string s4 = d.ToShortTimeString();
            Console.WriteLine(s4 + "\n");

            //Formato padrão já conhecido:
            string s5 = d.ToString();
            Console.WriteLine(s5 + "\n");

            //Máscara de formatação:
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6 + "\n");

            //Imprime milisegundos:
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s7 + "\n");
        }
    }
}
