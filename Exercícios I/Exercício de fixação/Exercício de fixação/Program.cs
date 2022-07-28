using System;
using System.Globalization;

namespace Exercício_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Digite o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ? ");
            string opcao = Console.ReadLine().ToUpper();
            Banco NovaConta = new Banco(Titular, NumeroConta);
            Console.WriteLine();
            
            if (opcao == "S")
            {
                Console.WriteLine("Digite o valor do depósito: ");
                double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                NovaConta.Deposito(dep);
            }

            Console.WriteLine("Dados da conta: "+ NovaConta);
            Console.WriteLine();

            Console.WriteLine("Gostaria de realizar mais alguma operação (s/n) ? ");
            string continuar = Console.ReadLine();
            
            while(continuar == "s")
            {
                Console.WriteLine();
                Console.WriteLine("Depósito ou saque? ");
                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "DEPÓSITO")
                {
                    Console.Write("Você escolheu fazer um dépósito, digite o valor a ser depositado: ");
                    double dep = double.Parse(Console.ReadLine());
                    NovaConta.Deposito(dep);
                }
                if (escolha == "SAQUE") {
                    Console.Write("Você escolheu fzaer um saque, digite o valor a ser sacado: ");
                    double saq = double.Parse(Console.ReadLine());
                    NovaConta.Saque(saq);

                }

                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados: "+NovaConta);
                Console.WriteLine("Gostaria de realizar mais alguma operação (s/n) ? ");
                continuar = Console.ReadLine();
            }


        }
    }
}
