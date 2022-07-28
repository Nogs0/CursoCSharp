using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioClasse3
{
    class Aluno
    {
        public string Nome;
        double Soma;

        public double AvaliaNotas(double n1, double n2, double n3)
        {
            Soma = n1 + n2 + n3;
            return Soma;
        }
        public bool Situacao()
        {
            if (Soma >= 60)
                return true;
            else
                return false;
        }
        public double Faltam()
        {   if (Situacao())
                return 0.0;
            else
                return 60.0 - Soma;
        }

    }
}
