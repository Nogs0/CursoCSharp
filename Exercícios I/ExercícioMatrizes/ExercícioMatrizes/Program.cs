using System;

namespace ExercícioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a ordem da matriz");
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];
                      
            for (int i = 0; i < N; i++)
            {
                string[] Numbers = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(Numbers[j]);                  
                }
            }
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                        Console.Write(matriz[i, j] + " ");
                }
            }
            int cont = 0;
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                        cont++;
                }
            }
            Console.WriteLine("\nNegative Numbers: " + cont);
        }
    }
}
