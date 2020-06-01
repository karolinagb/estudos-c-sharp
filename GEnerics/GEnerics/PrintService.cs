﻿using System;

namespace GEnerics
{
    class PrintService
    {
        //varável interna do tipo vetor para receber até 10 valores
        private int[] _values = new int[10];

        //Variável interna para contar quantos valores foram inseridos
        private int _count = 0;

        //Adiciona o valor do argumento dentro do vetor
        public void AddValue (int value)
        {
            //Verificando se o vetor está cheio
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
           _count++;
        }

        //Retorna o primeiro elemento do PrintService
        public int First()
        {
            //Verificando se o PrintService está vazio:
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            //Impressão até o penultimo valor com a vígula e espaço
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
