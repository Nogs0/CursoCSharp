using System;

namespace ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoItem = 0, quantidadeItem, i;
            double valorTotal = 0;
            double[] precoItem = new double[5];
            precoItem[0] = 4.00;
            precoItem[1] = 4.50;
            precoItem[2] = 5.00;
            precoItem[3] = 6.50;
            precoItem[4] = 9.53;

            Console.WriteLine("Que tal fazer umas comprinhas?\nDigite o código do item desejado:\n  > 1 - Cachorro Quente\n" +
                "  > 2 - XSalada\n  > 3 - XBacon\n  > 4 - Xfrango\n  > 5 - XPamonhão");
            codigoItem = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos gostaria?");
            quantidadeItem = int.Parse(Console.ReadLine());

            for (i = 0; i < 5; i++)
            {
                if((codigoItem-1) == i)
                {
                    valorTotal = precoItem[codigoItem-1] * quantidadeItem;
                }
            }

            Console.Write("Muito obrigado!\n   Total : R$" + valorTotal.ToString("F2"));

        }
    }
}
