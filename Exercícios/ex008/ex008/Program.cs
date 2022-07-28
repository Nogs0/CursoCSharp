using System;

namespace ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Descubra se o número é par ou ímpar!");
            x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine(x + " é par!");
            }
            else
            {
                Console.WriteLine(x + " é ímpar!");
            }
        }
    }
}
