
using System;

namespace CalculadoraVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quais números gostaria de somar");
            string[] Numbers = Console.ReadLine().Split(' ');
            int[] NumerosSoma = new int [Numbers.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                NumerosSoma[i] = int.Parse(Numbers[i]); 
            }

            Console.WriteLine(Calculator.Sum(NumerosSoma));
        }
    }
}
