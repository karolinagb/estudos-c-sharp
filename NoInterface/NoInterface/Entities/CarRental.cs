using System;

namespace NoInterface.Entities
{
    //Implementando o aluguel do carro associado a nota de pagamento e ao modelo do veículo
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        /*A nota de pagamento só é gerada quando é processado o aluguel de carro 
         * portanto ela não entra no construtor pois começa com nulo (automaticamente)*/
        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
