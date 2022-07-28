using System;
using System.Globalization;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double pi = 3.14159;
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * Math.Pow(r,2);

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
