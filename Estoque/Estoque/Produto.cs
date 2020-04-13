using System;
using System.Globalization;

namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            this.Quantidade = 10;
        }

        //this para referenciar o construtor padrão
        public Produto (string nome, double preco) : this()
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        //referenciando o construtor anterior
        public Produto (string nome, double preco, int quantidade) : this(nome, preco)
        {

        }

        /*public Produto ()
        {

        }

        //Construtor da classe para tornar obrigatória a implementação dos atributos na hora de instanciar.
        public Produto (string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public Produto (string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
            this. Quantidade = 0;
        }*/

        public double ValorTotalEmEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        /*Variável de parâmetro de entrada de função deve ser colocada em letra minúscula*/
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        /*A função ToString pertence a classe Object portanto eu tenho que fazer uma sobreposição usando override*/
        //override indica que a operação venho de outra classe
        //Assinatura da função ToString
        public override string ToString()
        {
            //definição da lógica para transformar um produto em string
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
