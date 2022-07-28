using System;
using System.Globalization;

namespace SoluçãoEmOutraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do círculo = ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Circunferência = " + Calculadora.Circunferencia(r).ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = " + Calculadora.Volume(r).ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi = "+ Calculadora.Pi);
        }
    }
}
 