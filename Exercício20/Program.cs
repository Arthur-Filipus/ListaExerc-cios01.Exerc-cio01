namespace Exercício20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

            Console.Write("Digite o número a ser verificado: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"Seu número, {numero}, é par");
            }
            else
            {
                Console.WriteLine($"Seu número, {numero}, é impar");
            }

            Console.ReadLine();
        }
    }
}