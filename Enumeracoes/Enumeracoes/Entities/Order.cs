using System;
using Enumeracoes.Entities.Enums;

//Tenho que chamar a biblioteca onde está os Enums

//Nome do projeto e nome da pasta:
namespace Enumeracoes.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
