using System;
using MultiCastDelegates.Services;
namespace MultiCastDelegates
{
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //Referenciando dois métodos
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            //Como ele não tem retorno, então não posso recebê-lo na variável
            op.Invoke(a, b);
            //Pode ser também op(a, b)
        }
    }
}