using System;

namespace Classes
{
    class Triangulo
    {
        //Nome de atributo começa com letra maiúscula
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return raiz;
        }

    }
}
