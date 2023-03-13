using System;

namespace Exercício11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para verificar se um número é primo.

            Console.Write("Digite seu número a ser verificado: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            int verificacao = 1;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    verificacao = verificacao + 1;
                }
            }
            if (verificacao == 2)
            {
                Console.WriteLine($"O número {numero} é primo.");
            }
            else
            {
                Console.WriteLine($"O número {numero} NÃO é primo.");
            }
            
            Console.ReadLine();
        }
    }
}