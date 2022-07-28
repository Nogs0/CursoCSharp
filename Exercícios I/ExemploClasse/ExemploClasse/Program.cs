
using System;
using System.Globalization;

namespace ExemploClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            double px, py;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                       

            double[] area = new double[2];

            area[0] = x.Area();
            area[1] = y.Area();

            Console.WriteLine("Área de X = " + area[0].ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + area[1].ToString("F4", CultureInfo.InvariantCulture));
            
            if(area[0]>area[1])
                Console.WriteLine("Área do triângulo X é maior");
            else
                Console.WriteLine("Área do triângulo Y é maior");

        }
    }
}
