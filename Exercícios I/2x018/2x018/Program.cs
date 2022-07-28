using System;
using System.Globalization;

namespace _2x018
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int numeroCasos = int.Parse(Console.ReadLine());
            string[] Testes;
            double[] notas = new double[3];
            double mediaPonderada;

            for (i = 0; i < numeroCasos; i++)
            {
                Testes = Console.ReadLine().Split(' ');
                notas[0] = double.Parse(Testes[0], CultureInfo.InvariantCulture);
                notas[1] = double.Parse(Testes[1], CultureInfo.InvariantCulture);
                notas[2] = double.Parse(Testes[2], CultureInfo.InvariantCulture);

                mediaPonderada = (notas[0] * 2.0 + notas[1] * 3.0 + notas[2] * 5.0) / 10;
                Console.WriteLine("A média ponderada deste caso é : " + mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
