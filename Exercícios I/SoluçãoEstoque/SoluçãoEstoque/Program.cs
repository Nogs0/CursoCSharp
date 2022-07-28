using System;
using System.Globalization;
namespace SoluçãoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque p = new Estoque("TV", 500.00, 10);
            
            p.Nome = "Tt";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }

    }
}
