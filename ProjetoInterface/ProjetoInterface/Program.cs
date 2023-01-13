using ProjetoInterface.Domain;
using System.Globalization;
using ProjetoInterface.Services;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Rental Data");
        Console.Write("Car model: ");
        string model = Console.ReadLine() ?? string.Empty;
        Console.Write("PickUp (dd/MM/yyyy HH:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine() ?? string.Empty, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Return (dd/MM/yyyy HH:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine() ?? string.Empty, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Enter price per hour: ");
        double phour = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Enter price per day: ");
        double pday = double.Parse(Console.ReadLine() ?? string.Empty);

        CarRental carRental = new CarRental(new Vehicle(model), start, finish);

        RentalService rentalService = new RentalService(phour, pday, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);
        Console.WriteLine("INVOICE");
        Console.WriteLine(carRental.Invoice);
    }
}