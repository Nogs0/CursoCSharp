using System;

namespace ex011
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar = 0;
            do
            {
                Console.WriteLine("Digite o número e descubra seu intervalo!");
                double number = double.Parse(Console.ReadLine());
                if (number < 0 || number > 100)
                {
                    Console.WriteLine(number + " Está fora de qualquer intervalo");
                }
                else if (number >= 0.00 && number <= 25.00)
                {
                    Console.WriteLine(number + " Está no intervalo [0,25]");
                }
                else if (number <= 50.00)
                {
                    Console.WriteLine(number + " Está no intervalo (25,50]");
                }
                else if (number <= 75.00)
                {
                    Console.WriteLine(number + " Está no intervalo (50,75]");
                }
                else
                {
                    Console.WriteLine(number + "Está no intervalo (75,100]");
                }

                Console.WriteLine("Gostaria de tentar novamente?\n  1 para sim || 0 para não\n");
                continuar = int.Parse(Console.ReadLine());

            } while (continuar == 1);
        }
    }
}
