using System;

namespace CalculadoraRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número cujo queira o triplo:");
            int a = int.Parse(Console.ReadLine());
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
