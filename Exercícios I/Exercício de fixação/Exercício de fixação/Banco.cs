using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercício_de_fixação
{
    class Banco
    {
        private double Saldo;
        public string Nome { get; set; }
        public int NumeroConta { get; private set; }
        public Banco(string nome, int conta)
        {
            Nome = nome;
            NumeroConta = conta;
        }
        public Banco() { }
        public double Deposito(double dep) => Saldo += dep;
        public double Saque(double saq) => (Saldo -= (saq+5));

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
