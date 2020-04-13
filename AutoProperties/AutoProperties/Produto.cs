using System;
using System.Globalization;

namespace AutoProperties
{
    class Produto
    {
        //Na mesma linha de declaração do atributo, posso declarar a propriedade com as operações get e set
        //private set porque nenhum outro componente pode acessar o set de preco e quantidade
        //Para o nome não poderá ser feito o auto Property porque ele tem uma lógica particular
        public string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }

        //Construtor da classe para tornar obrigatória a implementação dos atributos na hora de instanciar.
        public Produto(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        //Posso usar os atributos como propriedades possuindo as operações de get e set:
        public string Nome
        {
            get { return this._nome; }
            set
            {
                //O value corresponde ao parametro que será recebido para alteração do nome
                if (value != null && value.Length > 1)
                {
                    this._nome = value;
                }
            }
        }

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
            return this._nome + ", $ " + this.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + this.Quantidade + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
