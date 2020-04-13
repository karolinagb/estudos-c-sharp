using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorRefOut
{
    class Calculator
    {
        //Para conseguir alterar o valor da variável do programa principal através da função Triple, basta colocar a palavra ref:
        //Quando você coloca ref o parâmetro da função vai se tornar uma referência para a variável do programa principal:
        //O x vai mecher na variável original:
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        /*Já o modificador out ele é como o ref (faz o parâmetro fazer referência para a variável original), porém não exige que
         * a variável original seja iniciada:*/

        //Agora vamos dizer que você quer passar um valor de origem e guardar o resultado em outro parâmetro de saída:

        //Origem é o valor de origem do programa principal. O mesmo fará uma cópia da variável do programa principal:
        //result é uma variável de saída que vai referenciar a variável de saída do programa principal, 
        //guardando lá o resultado da conta:
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
