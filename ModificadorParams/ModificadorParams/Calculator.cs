using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorParams
{
    class Calculator
    {
        //Fazendo uma função que recebe valores variáveis através de um vetor:
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
