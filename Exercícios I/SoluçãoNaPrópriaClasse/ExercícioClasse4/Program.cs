using System;

namespace ExercícioClasse4
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do círculo: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Circunferência = "+Circunferencia(r).ToString("f2"));
            Console.WriteLine("Volume = " + Volume(r).ToString("f2"));
            Console.WriteLine("Pi = "+Pi);


        }
        static double Circunferencia(double raio)
        {            
            return 2 * Pi * raio;
        }
        static double Volume(double raio)
        {
            return (4.0 / 3.0) * Pi * Math.Pow(raio,3);
        }
    }
}
