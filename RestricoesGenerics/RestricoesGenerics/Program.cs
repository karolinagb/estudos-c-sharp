﻿using RestricoesGenerics.Services;
using System;
using System.Collections.Generic;
using RestricoesGenerics.Entities;
using System.Globalization;

namespace RestricoesGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter with value N:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do produto e o preço separados por vírgula:");
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            //O tipo product também tem que implementar o IComparable a fim de que o CompareTo do Max() retorne o valor
            Product max = calculationService.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}
