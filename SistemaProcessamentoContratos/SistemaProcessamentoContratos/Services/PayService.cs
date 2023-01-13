using SistemaProcessamentoContratos.Entities;
namespace SistemaProcessamentoContratos.Services
{
    internal class PayService
    {
        public IPaytRateService _payRateService;
        public PayService(IPaytRateService payRateService)
        {
            _payRateService = payRateService;
        }
        public void ProcessContract (Contract contract, int month)
        {
            double basicQuota = contract.ContractValue / month;
            for(int i = 1; i <= month; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(1);
                double updatedQuota = basicQuota + _payRateService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _payRateService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(fullQuota, date));
            }
        }
    }
}