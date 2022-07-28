using System;
using System.Collections.Generic;
using System.Text;

namespace SoluçãoDolar
{
    class ConverorDeMoeda
    {
        public static double Iof = 0.06;
        public static double Conversor(double Cotacao, double Quantidade)
        {
            return (Cotacao * Quantidade) + (Iof * (Cotacao * Quantidade));
        }
    } 
}
