using System;

namespace ExercícioMatrizes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');

                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = int.Parse(numeros[j]);
                }
            }

            Console.WriteLine("\nDigite um número pertencente a matriz, para descobrir quais números o cercam");
            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (search == matriz[i, j])
                    {
                        Console.WriteLine("Position " + i + "," + j);
                        if (i > 0)
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        if (i < linhas - 1)
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        if (j > 0)
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        if (j < colunas - 1)
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                    }
                }
            }
        }
    }
}
