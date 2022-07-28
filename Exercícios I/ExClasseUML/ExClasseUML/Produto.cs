using System.Globalization;

namespace ExClasseUML
{
    class Produto
    {
        public string Nome;
        public int Quantidade;
        public double Preco;

        public double ValorTotalEmEstoque()
        {
            return (Preco * Quantidade);
        }
        public void AdicionarProdutos(int Recebimento)
        {
            Quantidade += Recebimento;
        }
        
        public void RemoverProdutos(int Retirada)
        {
            Quantidade -= Retirada;
        }
        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2",CultureInfo.InvariantCulture) + " Quantidade em estoque: " + Quantidade + " Valor armazenado R$"
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }

}
