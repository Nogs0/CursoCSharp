using System;
using System.Globalization;

namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Atriangulo, Acirculo, Atrapezio, Aquadrado, Aretangulo, pi;
            pi = 3.14159;

            string[] calculo = Console.ReadLine().Split(' ');

            A = double.Parse(calculo[0]);
            B = double.Parse(calculo[1]);
            C = double.Parse(calculo[2]);

            Atriangulo = (A * C) / 2;
            Acirculo = pi * Math.Pow(C, 2);
            Atrapezio = ((A +B) * C) / 2;
            Aquadrado = Math.Pow(B, 2);
            Aretangulo = A * B;

            Console.WriteLine("TRIÂNGULO: " + Atriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " + Acirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + Atrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + Aquadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + Aretangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
