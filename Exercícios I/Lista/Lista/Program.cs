using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Marco");
            list.Add("Tonho");
            list.Add("Dias");


            list.Insert(2, "Thiago");

            //Percorrer a combinação
            foreach (string um in list)
                Console.WriteLine(um);
            Console.WriteLine("list count: " + list.Count);

            //Expressão Lambda 
            //Buscar o primeiro elemento com tal lógica 
            string s1 = list.Find(x => x[0] == 'T');
            Console.WriteLine("First 'T' : " + s1);

            //Buscar o último elemento com tal lógica 
            string s2 = list.FindLast(x => x[0] == 'T');
            Console.WriteLine("Last 'T' : " + s2);

            //Buscar a primeira posição do elemento com tal lógica
            int pos1 = list.FindIndex(x => x[0] == 'T');
            Console.WriteLine("First Position 'T' : "+ pos1);

            //Buscar a última posição do elemento com tal lógica
            int pos2 = list.FindLastIndex(x => x[0] == 'T');
            Console.WriteLine("Last Position 'T' : " + pos2);

            //Criar um filtro na lista
            List<string> listFilter = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------------------");
            foreach(string ex in listFilter)
                Console.WriteLine(ex);

            //Remove um item específico da lista
            list.Remove("Marco");
            Console.WriteLine("--------------------------------------");
            foreach( string excluir in list)
                Console.WriteLine(excluir);

            Console.WriteLine("--------------------------------------");
            //Remove todos os itens com tal lógica da lista
            list.RemoveAll(x => x[0] == 'D');
            foreach (string excluir in list)
                Console.WriteLine(excluir);
            Console.WriteLine("--------------------------------------");
            //Remover um elemento com base na sua posição
            /*list.RemoveAt(1);
            foreach(string ex in list)
                Console.WriteLine(ex);*/

            //Remover uma faixa de itens
            list.RemoveRange(0, 1);
            foreach(string ex in list)
                Console.WriteLine(ex);

        }

    }
}
