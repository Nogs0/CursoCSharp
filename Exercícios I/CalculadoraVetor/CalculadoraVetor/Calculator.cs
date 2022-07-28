using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraVetor
{
    class Calculator
    {
        public static int Sum(params int[] vetor)
        {
            int soma = 0;
            for(int i = 0; i<vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma;
        }
    }
}
