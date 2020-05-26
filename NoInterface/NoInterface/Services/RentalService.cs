using System;
using NoInterface.Entities;

namespace NoInterface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //Associação do serviço RentalService com A INTERFACE ITaxService 
        private ITaxService _taxService;

        //Inversão de controle por meio de injeção de dependências
        //Esse serviço apenas recebe a implementação da interface
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            //Descobrindo a duração do aluguel:
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            //Verificando regras de pagamento de acordo com horas ou dias:

            if (duration.TotalHours <= 12.0)
            {
                //Math.Ceiling arredonda para cima o valor no parenteses:
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            //Calculando o imposto:
            double tax = _taxService.Tax(basicPayment);

            //Instanciando uma folha de pagamento associada a um aluguel de carro
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
