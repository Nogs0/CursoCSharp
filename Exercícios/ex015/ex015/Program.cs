using System;

namespace ex015
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            int[] combustiveis = new int[4];

            Console.WriteLine("Digite o código do combustível que desejar:\n > 1 - Álcool\n > 2 - Gasolina" +
                "\n > 3 - Diesel\n > 4 - Para sair da escolha");
            escolha = int.Parse(Console.ReadLine());

            while (escolha != 4)
            {
                if (escolha == 1)
                    combustiveis[0]++;
                else if (escolha == 2)
                    combustiveis[1]++;
                else if (escolha == 3)
                    combustiveis[2]++;
                Console.WriteLine("Digite o código do combustível que desejar:\n > 1 - Álcool\n > 2 - Gasolina" +
                "\n > 3 - Diesel\n > 4 - Para sair da escolha");
                escolha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Clientes que desejaram álcool:"+combustiveis[0]);
            Console.WriteLine("Clientes que desejaram gasolina:" + combustiveis[1]);
            Console.WriteLine("Clientes que desejaram diesel:" + combustiveis[2]);


        }
    }
}
