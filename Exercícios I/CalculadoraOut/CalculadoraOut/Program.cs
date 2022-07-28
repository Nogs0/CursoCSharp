using System;

namespace CalculadoraOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número cujo queira o triplo: ");
            int a = int.Parse(Console.ReadLine());
            int result;
            Calculator.Triple(a, out result);
            Console.WriteLine(result);
        }
    }
}
