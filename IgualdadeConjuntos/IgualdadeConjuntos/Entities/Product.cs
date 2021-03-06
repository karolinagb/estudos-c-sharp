﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IgualdadeConjuntos.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            //Somando os GetHashCode para ver se os objetos são iguais:
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Product))
            {
                return false;
            }
            Product other = (Product) obj;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}