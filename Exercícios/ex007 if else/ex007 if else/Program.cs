using System;

namespace ex007_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorCarro, i;
            int[] resposta = new int[3];
            string[] adicionais = new string[3];
            adicionais[0] = "Vidro elétrico?";
            adicionais[1] = "Rodas de liga leve?";
            adicionais[2] = "Travas elétricas?";
            int[] valorAdicionais = new int[3];
            valorAdicionais[0] = 500;
            valorAdicionais[1] = 2000;
            valorAdicionais[2] = 500;

            Console.WriteLine("Vamos simular o valor de seu futuro carro!");
            Console.WriteLine("==========================================");
            Console.WriteLine("Digite seu valor inicial (sem adicionais):");

            valorCarro = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora nos informe quais adicionais você gostaria no seu veículo:");
            Console.WriteLine("1 = sim || 0 = não");
            for(i=0; i < 3; i++)
            {
                Console.WriteLine(adicionais[i]);
                resposta[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 3; i++)
            {
                if(resposta[i] == 1)
                {
                    valorCarro += valorAdicionais[i];
                }
            }
            Console.WriteLine("O valor final do seu carro é: R$" + valorCarro.ToString("F2"));
            
        }
    }
}
