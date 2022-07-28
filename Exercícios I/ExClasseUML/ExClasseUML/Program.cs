using System;
using System.Globalization; 

namespace ExClasseUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto ProdutoUm;
            ProdutoUm = new Produto();
            int continuar;
            do
            {
                Console.WriteLine("Digite os dados do produto: ");
                Console.Write("Nome: ");
                ProdutoUm.Nome = Console.ReadLine();
                Console.Write("Preço: ");
                ProdutoUm.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantidade no estoque: ");
                ProdutoUm.Quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine("Dados do produto : " +ProdutoUm);

                Console.Write("\nDigite o número de produtos a serem adicionados no estoque: ");
                int adicionar = int.Parse(Console.ReadLine());
                ProdutoUm.AdicionarProdutos(adicionar);
                Console.WriteLine("Dados do produto : " + ProdutoUm);

                Console.Write("\nDigite o número de itens a serem retirados do estoque: ");
                int retirar = int.Parse(Console.ReadLine());
                ProdutoUm.RemoverProdutos(retirar);
                Console.WriteLine("Dados do produto : " + ProdutoUm);

                Console.Write("\nPara manipular outro produto digite '1'");
                continuar = int.Parse(Console.ReadLine());
            } while (continuar == 1);

        }
    }
}
