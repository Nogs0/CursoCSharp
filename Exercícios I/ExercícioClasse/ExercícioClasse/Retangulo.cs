using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercícioClasse
{
    class Retangulo
    {
        public double Largura, Altura;

        public double Area()
        {
            return (Largura * Altura);
        }
        public double Perimetro()
        {
            return ((2 * Largura) + (2 * Altura));
        }
        public double Diagonal()
        {
            return (Math.Sqrt((Math.Pow(Largura, 2) + Math.Pow(Altura, 2))));
        }

        public override string ToString()
        {
            return "Área = "+Area()+"\nPerímetro = "+Perimetro()+"\nDiagonal = "+Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
