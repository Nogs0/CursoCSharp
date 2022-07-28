using System;

namespace ex017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos números você gostaria que lêssemos...");
            int n = int.Parse(Console.ReadLine());
            int i;
            int[] analise = new int[3];

            for (i = 0; i < n; i++)
            {
                analise[0] = int.Parse(Console.ReadLine());
                if (10 <= analise[0] && analise[0] <= 20)
                    analise[1]++;
                else
                    analise[2]++;
            }
            Console.WriteLine("In : "+analise[1] + " Out : "+analise[2]);
        }
    }
}
