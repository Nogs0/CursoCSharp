using SistemaProcessamentoContratos.Entities;

namespace SistemaProcessamentoContratos.Services
{
    interface IPaytRateService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
