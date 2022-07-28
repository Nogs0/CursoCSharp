using System;

namespace ex019
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int numerodePares = int.Parse(Console.ReadLine());

            for (i = 0; i < numerodePares; i++)
            {
                string[] pares = Console.ReadLine().Split(' ');
                double a, b;
                a = double.Parse(pares[0]);
                b = double.Parse(pares[1]);
                double result;

                if (b != 0)
                {
                    result = a / b;
                    Console.WriteLine("O Resultado da divisão é : " + result.ToString("F1"));
                }
                else
                Console.WriteLine("Divisão Impossível!");                                
            }
            
        }
    }
}
