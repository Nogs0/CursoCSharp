using System;
using System.Globalization;

namespace ExClasse002
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] salarioMes = new double[2];
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            f1.Nome = Console.ReadLine();
            f1.SalarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            f2.Nome = Console.ReadLine();
            f2.SalarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMes[0] = f1.SalarioHora * 30;
            salarioMes[1] = f2.SalarioHora * 30;

            Console.WriteLine("O salário do funcionário " + f1.Nome + " é : R$" + salarioMes[0].ToString("F2"));
            Console.WriteLine("O salário do funcionário " + f2.Nome + " é : R$" + salarioMes[1].ToString("F2"));


        }
    }
}
