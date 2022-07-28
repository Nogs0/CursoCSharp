
using System;

namespace ExClasse001
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite o nome e idade da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome e idade da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade)
                Console.WriteLine(p1.Nome + " é mais velho(a)!");
            else
                Console.WriteLine(p2.Nome + " é mais velho(a)!");
            

        }
    }
}
