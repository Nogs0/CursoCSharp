using SistemaProcessamentoContratos.Entities;
using System.Globalization;
using SistemaProcessamentoContratos.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data");

        Console.Write("Number: ");
        int Cnumber = int.Parse(Console.ReadLine()?? string.Empty);
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime Cdate = DateTime.ParseExact(Console.ReadLine() ?? string.Empty, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Contract Value: ");
        double cValue = double.Parse(Console.ReadLine()?? string.Empty, CultureInfo.InvariantCulture);
        Console.Write("Enter number of installments: ");
        int cInstallments = int.Parse(Console.ReadLine() ?? string.Empty);

        Contract contract = new Contract(Cnumber, Cdate, cValue);
        PayService payService = new PayService(new PayPalService());

        payService.ProcessContract(contract, cInstallments);
        Console.WriteLine("INSTALLMENTS:");
        foreach (Installment installment in contract.Installments)
            Console.WriteLine(installment);
    }
}