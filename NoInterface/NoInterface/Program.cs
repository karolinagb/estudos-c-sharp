﻿using System;
using System.Globalization;
using NoInterface.Entities;
using NoInterface.Services;

namespace NoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");

            //UTILIZANDO ParseExact para escolher como a variavel guardará a data:
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando o aluguel do carro:
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            /*Estou incluindo a implementaçãod a classe concreta BrazilTaxService e a mesma casa com o objeto ITaxService
             no construtor por meio de Upcasting já que o BrazilTaxService é subtipo de ITaxService*/
            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

            //A operação abaixo deve instanciar o meu invoice associado ao meu carRental
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
