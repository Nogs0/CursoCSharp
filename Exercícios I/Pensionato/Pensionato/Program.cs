using System;
using System.Globalization;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Friends! Welcome to Jhon's hostel!");
            Console.WriteLine("How many rooms will be rented?");
            int Residentes = int.Parse(Console.ReadLine());
            Moradores[] People = new Moradores[Residentes]; 
            for(int i =0; i < Residentes; i++)
            {
                Console.WriteLine("Rent #"+(i+1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine("Rent: ");
                double rent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                People[i] = new Moradores(name, email, room, rent);
            }

            Console.WriteLine("Busy rooms: ");
            string[] Busy = new string[Residentes];
            for(int i = 0; i < Residentes; i++)
            {
                if(People[i].Nome != null)
                {
                    Console.WriteLine("#"+People[i].Quarto+ ": "+People[i].Nome+ ", "+People[i].Email+" Rent: $"+(People[i].Aluguel).ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
