namespace Enumeracoes.Entities.Enums
{
    //:int especifica que cada valor do OrderStatus será um número inteiro:
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
