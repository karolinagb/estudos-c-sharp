using DelegaTes.Services;
using System;

namespace DelegaTes
{
    //Declarando um delegate:
    //Ele vai ser referência para uma função que recebe 2 números double e retorna um número double
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //O objeto op é uma referência para a função sum
            BinaryNumericOperation op = CalculationService.Sum;
            //Sintaxes alternativas:
            /*BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);*/

            //O result recebe o op aplicado a a e b que vai realizar a soma
            double result = op(a, b);
            //Sintaxe alternativa:
            //double result = op.Invoke(a, b);  - Invoca a função definica a cima (SUM)

            /*O delegate é uma referência para a função com typeSfety. Isso significa que o Delegate do tipo BinaryNumericOperation, 
             só pode receber funções que recebem 2 doubles e retorna um double.*/


            Console.WriteLine(result);
        }
    }
}
