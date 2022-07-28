using System;
using System.Globalization;

namespace ExercícioClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R;
            R = new Retangulo();
            Console.WriteLine("Digite as dimensões de um retângulo, dimensionaremos para você:");
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine(R);

        }
    }
}
