using System;

namespace ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("esses números são múltiplos? \n\n Digite e descubra!");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x % y == 0 || y % x == 0)
            {
                Console.WriteLine("Sim, são!");
            }
            else
            {
                Console.WriteLine("É, não são...");
            }
        }
    }
}
