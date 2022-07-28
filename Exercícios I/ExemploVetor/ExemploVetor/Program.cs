using System;
using System.Globalization;

namespace ExemploVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double Soma = 0.0;
            int N = int.Parse(Console.ReadLine());

            double[] Alturas = new double[N];

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite a altura");
                Alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Soma += Alturas[i];

            }
            Console.WriteLine("AVERAGE HEIGHT: "+ (Soma/N).ToString("F2"));
               
        }
    }
}
