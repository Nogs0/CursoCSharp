using System;

namespace ex022
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Linha: " + i + " Quadrado: " + i * i + " Cubo: " + i * i * i);
            }
        }
    }
}
