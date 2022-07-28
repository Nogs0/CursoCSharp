using System;
using System.Globalization;

namespace ExemploVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos gostaria de comparar? ");
            int N = int.Parse(Console.ReadLine());
            Produto[] p = new Produto[N];

            for(int i = 0; i < N; i++)
            {
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Produto { Nome = nome, Preco = preco };
                           
            }
            
            double Soma = 0.0;

            for(int i = 0; i <N; i++)
            {
                Soma += p[i].Preco;
            }

            Console.WriteLine("Average Price: R$"+ (Soma/N).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
