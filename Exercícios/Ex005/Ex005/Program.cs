using System;
using System.Globalization;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca, numeroPeca;
            double valorUnitario, valorTotal;

            string[] notaFiscal = Console.ReadLine().Split(' ');
            codigoPeca = int.Parse(notaFiscal[0]);
            numeroPeca = int.Parse(notaFiscal[1]);
            valorUnitario = double.Parse(notaFiscal[2]);
            valorTotal = numeroPeca * valorUnitario;
            notaFiscal = Console.ReadLine().Split(' ');
            codigoPeca = int.Parse(notaFiscal[0]);
            numeroPeca = int.Parse(notaFiscal[1]);
            valorUnitario = double.Parse(notaFiscal[2]);
            valorTotal += numeroPeca * valorUnitario;
            Console.WriteLine("VALOR A PAGAR : R$ " + valorTotal.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
