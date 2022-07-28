using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercícioClasse2
{
    class Salario
    {
        public double SalarioBruto;
        public string Nome;
        double Imposto;
        double Livre;
        double Aumento;
        public double Desconto()
        {
            Imposto = SalarioBruto * 0.16;
            return Imposto;
        }
        
        public double AumentoSalarial(double Porcentagem)
        {
            Aumento = 0.01 * Porcentagem;
            SalarioBruto += (Aumento * SalarioBruto);

            return SalarioBruto - (SalarioBruto * 0.16);
        }
        public double SalarioLivre()
        {
            Livre = SalarioBruto - Imposto;
            return Livre;
        }

        public override string ToString()
        {
            return "Nome do funcionário: " + Nome + "\nImposto: R$" + Desconto().ToString("F2", CultureInfo.InvariantCulture) +
                "\nSalário livre de impostos: R$" + SalarioLivre().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
