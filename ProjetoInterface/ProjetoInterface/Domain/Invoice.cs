using System.Globalization;

namespace ProjetoInterface.Domain
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }

        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic Payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("f2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
