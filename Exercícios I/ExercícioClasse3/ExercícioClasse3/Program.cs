using System;

namespace ExercícioClasse3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x;
            x = new Aluno();
            Console.Write("Digite o nome do Aluno: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final: " + x.AvaliaNotas(n1, n2, n3).ToString("f2"));

            if (x.Situacao())
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram: " + x.Faltam());
            }                

        }
    }
}
