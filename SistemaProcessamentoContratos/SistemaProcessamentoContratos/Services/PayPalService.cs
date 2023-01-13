using SistemaProcessamentoContratos.Entities;
using System.Threading.Tasks;

namespace SistemaProcessamentoContratos.Services
{
    internal class PayPalService : IPaytRateService
    {
        private const double MonthlyInterest = 0.01;
        private const double FeePercentage = 0.02;
        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
