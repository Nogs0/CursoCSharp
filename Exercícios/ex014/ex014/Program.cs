using System;

namespace ex014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas de um plano cartesiano:");
            string[] coordenadas = Console.ReadLine().Split(" ");

            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("Primeiro Quadrante");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Segundo Quadrante");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Terceiro Quadrante");
                else
                    Console.WriteLine("Quarto quadrante");

                Console.WriteLine("Digite as coordenadas de um plano cartesiano:");
                coordenadas = Console.ReadLine().Split(" ");

                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }
            Console.WriteLine("Nulo");
        }
    }
}
