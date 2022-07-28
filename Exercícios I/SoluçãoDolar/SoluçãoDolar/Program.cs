using System;
using System.Globalization;
namespace SoluçãoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em R$"+ConverorDeMoeda.Conversor(Dolar, Quantidade).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
