using System;
using System.Globalization;

namespace Properties
{
    class Produto
    {
        //Por convenção atributos privativos devem começar por _ e letra minúscula
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        //Construtor da classe para tornar obrigatória a implementação dos atributos na hora de instanciar.
        public Produto(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }

        //Posso usar os atributos como propriedades possuindo as operações de get e set:
        public string Nome
        {
            get { return this._nome; }
            set {
                //O value corresponde ao parametro que será recebido para alteração do nome
                if (value != null && value.Length > 1)
                {
                    this._nome = value;
                }
            }
        }

        public double Preco
        {
            get { return this._preco; }
        }

        public int Quantidade
        {
            get { return this._quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            return this._preco * this._quantidade;
        }

        /*Variável de parâmetro de entrada de função deve ser colocada em letra minúscula*/
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        /*A função ToString pertence a classe Object portanto eu tenho que fazer uma sobreposição usando override*/
        //override indica que a operação venho de outra classe
        //Assinatura da função ToString
        public override string ToString()
        {
            //definição da lógica para transformar um produto em string
            return this._nome + ", $ " + this._preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + this._quantidade + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
