using System;
using System.Collections.Generic;
using System.Text;

namespace RestricoesGenerics.Services
{
    class CalculationService
    {
        //Posso colocar o método como generico tambem assim: public T Max<T>
        //Where T: IComparable = permite tipo genericos que implementem a interface IComparable, ou seja, 
        //que tenham o método CompareTo (possam ser comparados)
        public T Max<T> (List<T> list) where T : IComparable
        {
            //Verificando se a lista está vazia:
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty!");
            }

            //Guardando o primeiro elemento da lista a fim de fazer as comparações
            T max = list[0];

            //Percorrendo o restante dos itens para ver qual é maior
            //list.Count = todos os elementos da lista até o final
            for (int i = 1; i < list.Count; i++)
            {
                //Comparando max com list e vendo se é maior que zero = se o elemento no parametro for maior que
                //o elemento atual, então o elemento do parâmetro do CompareTo é maior que o elemento atual
                if(list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
