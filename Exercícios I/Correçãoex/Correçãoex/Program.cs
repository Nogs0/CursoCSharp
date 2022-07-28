using System;
using System.Globalization;

namespace Correçãoex
{
    class Program
    {
        static void Main(string[] args)
        {
            double dep;
            double saq;

            Console.WriteLine("ENTRE COM O NÚMERO DA CONTA: ");
            int conta = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTRE COM O TITULAR: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Gostaria de fazer um depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine().ToUpper());
            Banco Novo = new Banco(conta, nome);
            
            if(opcao == 'S')
            {
                Console.Write("Digite o valor do depósito: ");
                dep = double.Parse(Console.ReadLine());
                Novo.Deposito(dep);
            }

            Console.WriteLine("Dados da conta: "+ Novo);

            Console.WriteLine("Entre um valor para depósito: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Novo.Deposito(dep);
            Console.WriteLine("Dados da conta atualizados: " + Novo);


            Console.WriteLine("Entre com um valor para saque: ");
            saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Novo.Saque(saq);
            Console.WriteLine("Dados da conta atualizados: " + Novo);
        }
    }
}
