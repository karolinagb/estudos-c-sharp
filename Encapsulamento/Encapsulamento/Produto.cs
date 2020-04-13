using System;
using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
        //Por convenção atributos privativos devem começar por _ e letra minúscula
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto ()
        {

        }

        //Construtor da classe para tornar obrigatória a implementação dos atributos na hora de instanciar.
        public Produto (string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }

        //Método acessador para obter nome
        public string GetNome()
        {
            return this._nome;
        }

        //Método modificador. Não retorna nada e por isso é void
        public void SetNome(string nome)
        {
            //O length é uma propriedade do string para tamanho de strings
            if (nome != null && nome.Length > 1) { 
            this._nome = nome;
            }
        }

        //Método get apenas afim de que preco e quant não possam ser alterados:
        public double GetPreco()
        {
            return this._preco;
        }

        public int GetQuantidade()
        {
            return this._quantidade;
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

