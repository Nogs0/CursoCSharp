namespace SistemaProcessamentoContratos.Entities
{
    internal class Contract
    {
        public int ContractNumber { get; private set; }
        public DateTime ContractDate { get; private set; }
        public double ContractValue { get; private set; }


        public List<Installment> Installments { get; set; }

        public Contract(int contractNumber, DateTime contractDate, double contractValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractValue = contractValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
