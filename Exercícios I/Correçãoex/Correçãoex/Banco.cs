using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Correçãoex
{
    class Banco
    {

        public double Saldo { get; private set; }
        public int Conta { get; private set; }
        public string Nome { get; set; }

        public Banco(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }
        
        public void Deposito(double dep)
        {
            Saldo += dep;
        }
        public void Saque(double saq)
        {
            Saldo -= (saq + 5);
        }
        public override string ToString()
        {
            return "Conta: " + Conta + ", Nome: " + Nome + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
