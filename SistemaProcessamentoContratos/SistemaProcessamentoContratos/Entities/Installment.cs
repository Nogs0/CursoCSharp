using System.Globalization;

namespace SistemaProcessamentoContratos.Entities
{
    internal class Installment
    {
        public double InstallmentValue { get; set; }
        public DateTime DueDate { get; set; }
        public Installment(double installmentValue, DateTime dueDate)
        {
            InstallmentValue = installmentValue;
            DueDate = dueDate;
            
        }
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - R$" + 
                InstallmentValue.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
