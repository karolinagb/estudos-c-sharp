using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            Console.WriteLine();

            //Convertendo de tipo enumerado para string utilizando ToString():
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            //Como converter de string para o tipo enumerado
            //Deve se parametrizar o Parse igual a parametrização de listas onde dentro do < > eu coloco para qual tipo
            //Entre () eu boto o tipo que eu quero que seja convertido para o tipo enumerado:
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            //Nome delivered igual ao definido no OrderStatus

            Console.WriteLine("\n" + os);
        }
    }
}
