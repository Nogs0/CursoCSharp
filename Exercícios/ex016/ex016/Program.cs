using System;

namespace ex016
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int i;

            while(1<=x && x<=1000)
            {
                for (i = 0; i <= x; i++)
                {
                    if(i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                x = int.Parse(Console.ReadLine());

            }
        }
    }
}
