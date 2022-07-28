using System;
using System.Globalization;

namespace Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, H;
            double valorHora, s;

            id = int.Parse(Console.ReadLine());
            H = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            s = H * valorHora;
            Console.WriteLine("O salário do funcionário " + id + " é U$" + s.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
