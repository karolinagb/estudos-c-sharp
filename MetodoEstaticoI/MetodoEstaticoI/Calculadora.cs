using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoEstaticoI
{
    class Calculadora
    {
        //coloco o static para poder chamar os membros sem ter que instanciar objetos
        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        public static double Volume(double r)
        {
            return (4.0 / 3.0) * Pi * Math.Pow(r, 3.0);
        }
    }
}
