﻿using System;

namespace GEnerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //No programa principal eu coloco o tipo que quero trabalhar:
            PrintService<int> printService = new PrintService<int>();
            Console.WriteLine("How many values?");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();

            Console.Write("First: " + printService.First());
        }
    }
}