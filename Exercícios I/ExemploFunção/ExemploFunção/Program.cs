using System;

namespace ExemploFunção
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar;
            do
            {
                Console.WriteLine("Digite três números");
                string[] numeros = Console.ReadLine().Split(' ');
                int[] vetNum = new int[3];
                

                vetNum[0] = int.Parse(numeros[0]);
                vetNum[1] = int.Parse(numeros[1]);
                vetNum[2] = int.Parse(numeros[2]);

                int resultado = Maior(vetNum, 3);

                Console.WriteLine("O maior dos números é = " + resultado);
                Console.WriteLine("Gostaria de Continuar?\nCaso sim, digite '1', se não, digite '0'");
                continuar = int.Parse(Console.ReadLine());
            } while (continuar == 1);
        }

        static int Maior(int[] vetor, int extensao)
        {
            int i, Maior = vetor[0];

            for (i = 0; i < extensao; i++)
            {
                if (Maior <= vetor[i])
                    Maior = vetor[i];
            }
            return Maior;

        }
    }
}
