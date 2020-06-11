using System;
using System.Collections.Generic;
using System.Text;

namespace DelegaTes.Services
{
    class CalculationService
    {
        //Função que retorna o maior valor
        public static double Max (double x, double y)
        {
            return (x > y) ? x : y;
        }

        //Função que retorna a soma dos valores
        public static double Sum(double x, double y)
        {
            return x + y;
        }

        //Função que retorna o quadrado do valor
        public static double Square(double x)
        {
            return x * x;
        }
    }
}
