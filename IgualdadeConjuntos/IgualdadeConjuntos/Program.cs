﻿using System;
using System.Collections.Generic;
using IgualdadeConjuntos.Entities;

namespace IgualdadeConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00);

            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);

            //Point é tipo struct e já possui a implementação do GetHashCode e Equals e compara o valor contido
            Console.WriteLine(b.Contains(p));
        }
    }
}
