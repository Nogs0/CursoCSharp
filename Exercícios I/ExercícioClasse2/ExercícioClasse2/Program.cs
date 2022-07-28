using System;
using System.Globalization;

namespace ExercícioClasse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario x;
            x = new Salario();
            double up;
            Console.WriteLine("Digite o nome do funcionário: ");
            x.Nome = Console.ReadLine();
            Console.Write("Digite o salário Bruto de funcionário: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(x);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumento do salário: ");
            up = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Salário após aumento: R$"+x.AumentoSalarial(up).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
