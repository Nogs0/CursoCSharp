using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace SoluçãoEstoque
{
    class Estoque
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }
       

        public Estoque()
        {
            Quantidade = 0;
        }
        public Estoque(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }
        public Estoque(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionaProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoveProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Nome: " + _nome + " Preço: R$" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " Unidades: " + Quantidade + " Valor Total Em Estoque: R$" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
