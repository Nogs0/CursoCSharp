using System;

namespace ex020
{
    class Program
    {
        static void Main(string[] args)
        {
            int fat = int.Parse(Console.ReadLine());
            int result = 1;
            int i;
                       
            for (i = 0; i < fat; i++)
            {
                result *= (fat - i);
            }
            Console.WriteLine("o Fatorial de "+ fat + " é "+ result);
        }
    }
}
